using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UITests.ElementFinders;
using UITests.Pages;

namespace UITests.Actions
{
    class LandingPageActions
    {
        private readonly Find find;
        private readonly LandingPage landingPage;

        public LandingPageActions(LandingPage landingPage, Find find)
        {
            this.landingPage = landingPage;
            this.find = find; 
        }

        public void SearchFor(string search)
        {
            find.webElement(landingPage.SearchBox).SendKeys(search);
            find.webElement(landingPage.SearchButton).Click();
            
        }
    }
}
