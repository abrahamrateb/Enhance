using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.Pages
{
    class ListingPage
    {
        private readonly By listingDetailsList = By.XPath("//div[@id='AttributesDisplay_attributesSection']//li");
        public By ListingDetailsList => listingDetailsList;
    }
}
