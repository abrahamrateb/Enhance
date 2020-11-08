using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace APITests
{
    class CharityAPITest
    {
        public string baseUrl = "https://api.trademe.co.nz/v1/Charities.json";

        [Test]
        public void VerifyCharityListIncludesStJohnsJSON()
        {
            RestClient client = new RestClient(baseUrl);

            var request = new RestRequest("", Method.GET, DataFormat.Json);

            var response = client.Execute(request);
            List<Charity> list = JsonConvert.DeserializeObject<List<Charity>>(response.Content);
            List<string> charityNames = new List<string>(); 
            
            foreach (var l in list)
            {
                charityNames.Add(l.Description);
            }
            Assert.Contains("St John", charityNames);

        }

    }
}
