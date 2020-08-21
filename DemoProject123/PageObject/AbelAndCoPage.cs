using DemoProject123.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoProject123.PageObject
{
    class AbelAndCoPage
    {

        public AbelAndCoPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement searchItem => driver.FindElement(By.XPath("//input[@type='search']"));

        IWebElement searchbutton => driver.FindElement(By.XPath("//input[@type='button']"));

        IWebElement addButton => driver.FindElement(By.XPath("(//div[@class='add cta-button'])[3]"));

        IWebElement acceptCookie => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));







        public void EnterSearchItem(string item)
        {
            Thread.Sleep(5000);
            searchItem.SendKeys(item);
        }

        public void ClickSearchButton()
        {
            searchbutton.Click();
        }

        public void ClickAddButton()
        {
            addButton.Click();
        }

        public void ClickAcceptCookie()
        {
            Thread.Sleep(5000);
            acceptCookie.Click();
        }









    }
}
