using DemoProject123.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoProject123.PageObject
{
    class DataDrivenWithExamplesPage
    {

        public DataDrivenWithExamplesPage()
        {
            driver = Hooks1.driver;

            // Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Fluent Wait
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);

            // Thread.Sleep
            Thread.Sleep(5000);

        }

        IWebDriver driver;

        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));











        public void EnterUsername(string Username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            usernameInput.SendKeys(Username + randomInt);
            //usernameInput.SendKeys(username);
        }

        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailInput.SendKeys(Email + randomInt + "@hushpuppi.com");
            //emailInput.SendKeys(amala);
        }

        public void EnterPassword(string Password)
        {
            Thread.Sleep(5000);
            passwordInput.SendKeys(Password);
        }

        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }

        public bool IsUserLoginDisplayed()
        {
            return userLogin.Displayed;
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }


    }
}






    

