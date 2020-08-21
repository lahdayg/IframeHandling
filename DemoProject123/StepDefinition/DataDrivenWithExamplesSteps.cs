using DemoProject123.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class DataDrivenWithExamplesSteps
    {
        DataDrivenWithExamplesPage dataDrivenWithExamplesPage;


        public DataDrivenWithExamplesSteps()
        {
            dataDrivenWithExamplesPage = new DataDrivenWithExamplesPage();
        }



        [When(@"the User enter Username text ""(.*)""")]
        public void WhenTheUserEnterUsernameText(string Username)
        {
            dataDrivenWithExamplesPage.EnterUsername(Username);

        }
        
        [When(@"the user enter email text ""(.*)""")]
        public void WhenTheUserEnterEmailText(string Email)
        {
            dataDrivenWithExamplesPage.EnterEmail(Email);
        }
        
        [When(@"the user enter password text ""(.*)""")]
        public void WhenTheUserEnterPasswordText(string Password)
        {
            dataDrivenWithExamplesPage.EnterPassword(Password);
        }
    }
}
