using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITests
{
    class UseCarAPITest
    {
        public string baseUrl = "https://api.tmsandbox.co.nz/v1/Search/Motors/Used.json ";

        [Test]
        public void VerifyUsedCarDetails()
        {
            RestClient client = new RestClient(baseUrl);

            var request = new RestRequest("", Method.GET, DataFormat.Json);

            var response = client.Execute(request);

            //Once we get the response, we'll need to go through the JSON, deserialize it and Assert against our desired properties. 
            //This cannot be done currently , as even with the Authorization the sandbox environment brings back a 500 response (which means something is wrong server side)
        }

    }
}
