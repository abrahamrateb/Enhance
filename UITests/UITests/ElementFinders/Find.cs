using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UITests.ElementFinders
{
    class Find
    {
        private WebDriverWait wait;
        private IWebDriver driver;

        public Find(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10)); 

        }

        public IWebElement webElement(By locator)
        {
            IWebElement element = wait.Until(driver => (IWebElement)driver.FindElement(locator));

            return element;
        }

        public List<IWebElement> webElements(By locator)
        {
            wait.Until(driver => driver.FindElements(locator));
            List<IWebElement> elements = driver.FindElements(locator).ToList();

            return elements;
        }

        public void scrollToElement(By locator)
        {
            var element = webElement(locator);

            var script = "arguments[0].scrollIntoView(true);";

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript(script, element);
        }

    }
}
