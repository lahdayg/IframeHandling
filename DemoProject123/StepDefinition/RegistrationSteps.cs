using DemoProject123.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }




        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            Thread.Sleep(5000);
            registrationPage.NavigateToWebsite();
                    
                                                                                                                                                                                                                                                                                                        
        }
        
        [When(@"I click on Hello sign in")]
        public void WhenIClickOnHelloSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }
        
        [When(@"I click on create your amazon account")]
        public void WhenIClickOnCreateYourAmazonAccount()
        {
            registrationPage.ClickOnCreateYourAmazonAccount1();
        }


        
        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
            registrationPage.EnterYourName();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I re enter my password")]
        public void WhenIReEnterMyPassword()
        {
            registrationPage.EnterPassword2();
        }
        
        [When(@"I create your amazon account on the registration page")]
        public void WhenICreateYourAmazonAccountOnTheRegistrationPage()
        {
            registrationPage.ClickOnCreateYourAmazonAccount2();
            
        }
        
        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            // Different types of Aseertion
            // 1. NUnit Assertion
            // 2. JUnit Assertion
            // 3. MSTest
            Assert.That(registrationPage.IsHelloDemoDisplayed);
        }

        [When(@"I created another step for demo purpose")]
        public void WhenICreatedAnotherStepForDemoPurpose()
        {
            ScenarioContext.Current.Pending();

        }

        [Given(@"I click on Sign In")]
        public void GivenIClickOnSignIn()
        {
            registrationPage.ClickSignIn();
        }


        [Given(@"my email address ""(.*)""")]
        public void GivenMyEmailAddress(string email)
        {
            registrationPage.EnterEmailAddress(email);
        }

        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            registrationPage.EnterPasswordText(password);
        }

        [When(@"I click on Sign In")]
        public void WhenIClickOnSignIn()
        {
            registrationPage.ClickOnSignInButton();
        }

        [When(@"I click on post item")]
        public void WhenIClickOnPostItem()
        {
            registrationPage.ClickOnPostItem();
        }

        [When(@"I enter item description")]
        public void WhenIEnterItemDescription()
        {
            registrationPage.EnterItemType();
        }

        [When(@"I enter item name")]
        public void WhenIEnterItemName()
        {
            registrationPage.EnterItemName();
        }

        [When(@"I click on choose file")]
        public void WhenIClickOnChooseFile()
        {
            registrationPage.ChooseFile();
        }



    }
}
