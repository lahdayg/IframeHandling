using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DemoProject123.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
           // driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            

            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}
