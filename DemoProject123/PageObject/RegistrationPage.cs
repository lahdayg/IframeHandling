using DemoProject123.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoProject123.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement helloSignIn => driver.FindElement(By.XPath("//*[@id='nav-link-accountList']/div/span"));

        IWebElement createYourAmazonAccount1 => driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.XPath("//input[@id='ap_customer_name']"));

        IWebElement email => driver.FindElement(By.CssSelector("#ap_email"));

        IWebElement password => driver.FindElement(By.CssSelector("#ap_password"));

        IWebElement reEnterpassword => driver.FindElement(By.CssSelector("#ap_password_check"));

        IWebElement createYourAmazonAccount2 => driver.FindElement(By.CssSelector("#continue"));

        IWebElement confirmHelloDemo => driver.FindElement(By.XPath("//span[text()='Hello, Demo']"));

        IWebElement signIn => driver.FindElement(By.XPath("(//a[text()='Sign In'])[1]"));

        IWebElement emailAddress => driver.FindElement(By.XPath("//input[@id='user_email']"));
        IWebElement passwordText => driver.FindElement(By.XPath("//input[@id='user_password']"));
        IWebElement signInButton => driver.FindElement(By.XPath("//input[@id='btn_signin']"));
        IWebElement postItem => driver.FindElement(By.XPath("//li[@class='mr--5']"));
        IWebElement itemName => driver.FindElement(By.XPath("//input[@id='title']"));






        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }

        public void ClickOnPostItem()
        {
            Thread.Sleep(5000);
            postItem.Click();
        }

        public void ClickOnSignInButton()
        {
            signInButton.Click();
        }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void EnterItemType()
        {
            //IWebElement iframeElement = driver.FindElement(By.XPath("//iframe[@class='cke_wysiwyg_frame cke_reset']"));
            //now using the switch command
            Thread.Sleep(7000);
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='cke_1_contents']/iframe")));
            IWebElement itemDescription = driver.FindElement(By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr']"));
            Thread.Sleep(7000);
            itemDescription.SendKeys("demo");
            driver.SwitchTo().DefaultContent();
          
           // itemDescription.SendKeys("demo description");
        }

        public void ChooseFile()
        {
            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys("C:\\Users\\Grandma\\Pictures\\ch.jpg");
        }

        public void EnterItemName()
        {
            itemName.SendKeys("testing");
        }

        public void EnterPasswordText(string password)
        {
            passwordText.SendKeys(password);
        }

        public void ClickSignIn()
        {
            signIn.Click();
        }


        public void ClickOnCreateYourAmazonAccount1()
        {
            createYourAmazonAccount1.Click();
        }

        public void EnterYourName()
        {
            yourName.SendKeys("DemoTest");
        }
        
        
        public void EnterEmail()
        {
            email.SendKeys("info@learnwithpride.co.uk");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void EnterPassword2()
        {
            reEnterpassword.SendKeys("PasswordSecure");
        }

        public void ClickOnCreateYourAmazonAccount2()
        {
            createYourAmazonAccount2.Click();
        }

        public bool IsHelloDemoDisplayed()
        {
            return confirmHelloDemo.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }


    }
}
