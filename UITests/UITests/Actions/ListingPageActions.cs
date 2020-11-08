using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UITests.ElementFinders;
using UITests.Pages;

namespace UITests.Actions
{
    class ListingPageActions
    {
        private readonly Find find;
        private readonly ListingPage listingPage;

        public ListingPageActions(ListingPage listingPage, Find find)
        {
            this.listingPage = listingPage;
            this.find = find;
        }

        public Dictionary<string, string> getListingDetails()
        {
            Dictionary<string, string> details = new Dictionary<string, string>();
            
            find.scrollToElement(listingPage.ListingDetailsList);
            var listingDetails = find.webElements(listingPage.ListingDetailsList);

            foreach (var detail in listingDetails)
            {
                details.Add(detail.FindElement(By.ClassName("motors-attribute-label")).Text,
                   detail.FindElement(By.ClassName("motors-attribute-value")).Text);
                
            }

            return details;
        }


    }
}
