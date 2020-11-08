using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UITests.Actions;

namespace UITests.StepDefinitions
{
    [Binding]
    public sealed class QueryExistingUsedCarStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;
        private LandingPageActions landingPageActions;
        private UsedCarSearchResultsActions usedCarSearchResultsActions;
        private ListingPageActions listingPageActions;

        QueryExistingUsedCarStepDefinition
            (ScenarioContext scenarioContext, IWebDriver driver, LandingPageActions landingPageActions,
            UsedCarSearchResultsActions usedCarSearchResultsActions, ListingPageActions listingPageActions)
        {
            _scenarioContext = scenarioContext;
            this.driver = driver;
            this.landingPageActions = landingPageActions;
            this.usedCarSearchResultsActions = usedCarSearchResultsActions;
            this.listingPageActions = listingPageActions;
        }

        [When(@"I navigate to the TM Sandbox website")]
        public void WhenINavigateToTheTMSandboxWebsite()
        {
            driver.Navigate().GoToUrl("https://www.tmsandbox.co.nz/");
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string search)
        {
            landingPageActions.SearchFor("Toyota");
        }

        [When(@"I select listing ""(.*)"" on the page")]
        public void WhenISelectListingOnThePage(int p0)
        {
            usedCarSearchResultsActions.ClickOnSecondListing();
        }

        [Then(@"the following details exist")]
        public void ThenTheFollowingDetailsExist(Table table)
        {
            var details = listingPageActions.getListingDetails();

            foreach (var row in table.Rows)
            {
                Assert.IsNotNull(details.ContainsKey(row[0]));
                Console.WriteLine("The " + row[0] + " of the vehicle is: " + details.GetValueOrDefault(row[0]));
            }
            //Assert.IsNotNull(details.ContainsKey("Number plate"));
            //Assert.IsNotNull(details.ContainsKey("Kilometres"));
            //Assert.IsNotNull(details.ContainsKey("Body"));
            //Assert.IsNotNull(details.ContainsKey("Engine size"));

            //Console.WriteLine(details.GetValueOrDefault("Number plate"));
            //Console.WriteLine(details.GetValueOrDefault("Kilometres"));
            //Console.WriteLine(details.GetValueOrDefault("Body"));
            //Console.WriteLine(details.GetValueOrDefault("Engine size"));
        }



    }
}
