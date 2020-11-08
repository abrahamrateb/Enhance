using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace UITests.Pages
{
    class LandingPage
    {
        private readonly By searchBox = By.Id("searchString");
        private readonly By searchButton = By.XPath("//button[@class='btn btn-trademe']");

        public By SearchBox => searchBox;
        public By SearchButton => searchButton;
    }
}
