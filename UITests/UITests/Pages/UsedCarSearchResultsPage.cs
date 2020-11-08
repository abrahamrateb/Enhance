using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UITests.Pages
{
    class UsedCarSearchResultsPage
    {
        //You could do some string concatenation if you wanted to parameterize the "2" at the end. 
        //You could also get a list of all elements/divs and loop through the array if there was a massive list. 
        private readonly By searchResult2 = By.XPath("//div[@class='supergrid-listing  medium card2']/div[@class='image ' and 1]");

        public By SearchResult2 => searchResult2; 
    }
}
