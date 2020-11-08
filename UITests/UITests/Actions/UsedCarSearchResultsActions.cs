using System;
using System.Collections.Generic;
using System.Text;
using UITests.ElementFinders;
using UITests.Pages;

namespace UITests.Actions
{
    class UsedCarSearchResultsActions
    {
        private readonly Find find;
        private readonly UsedCarSearchResultsPage usedCarSearchResultsPage;

        public UsedCarSearchResultsActions(UsedCarSearchResultsPage usedCarSearchResultsPage, Find find)
        {
            this.usedCarSearchResultsPage = usedCarSearchResultsPage;
            this.find = find;
        }

        public void ClickOnSecondListing()
        {
            find.scrollToElement(usedCarSearchResultsPage.SearchResult2);
            find.webElement(usedCarSearchResultsPage.SearchResult2).Click();
        }
    }
}
