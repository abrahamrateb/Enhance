using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace XeroTechAssessment.Hooks
{
    [Binding]
    public sealed class XeroHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private IWebDriver driver;
        private readonly IObjectContainer _objectContainer;

        public XeroHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            string browserToTest = Environment.GetEnvironmentVariable("browserToTest");
            //if (browserToTest == "Chrome")
            //{
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //    Console.WriteLine("Test was run on an Environment-driven Chrome Driver");
            //}
            //else if (browserToTest == "Firefox")
            //{
            //    driver = new FirefoxDriver();
            //    Console.WriteLine("Test was run on an Environment-driven Firefox Driver");
            //}
            //else if (browserToTest == "Docker")
            //{

            //    DriverOptions driverOptions = new ChromeOptions();
            //    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), driverOptions);
            //    Console.WriteLine("Test was run on an Environment-driven Docker Chrome Driver");
            //}
            //else
            //{
            //    driver = new ChromeDriver();
            //    Console.WriteLine("Test was run on the default Chrome Driver");
            //}


            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Dispose();
        }
    }
}