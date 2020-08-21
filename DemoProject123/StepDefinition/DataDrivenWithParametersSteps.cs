using DemoProject123.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class DataDrivenWithParametersSteps
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParametersSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }




        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [When(@"I enter Username text ""(.*)""")]
        public void WhenIEnterUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }
        
        [When(@"I enter email text ""(.*)""")]
        public void WhenIEnterEmailText(string amala)
        {
            dataDrivenWithParameterPage.EnterEmail(amala);
        }
        
        [When(@"I enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithParameterPage.ClickSignUpButton();
        }
        
        [Then(@"I am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {
            Assert.That(dataDrivenWithParameterPage.IsUserLoginDisplayed);
        }
    }
}
