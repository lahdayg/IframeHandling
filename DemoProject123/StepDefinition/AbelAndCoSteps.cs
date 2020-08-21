using DemoProject123.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class AbelAndCoSteps
    {

        AbelAndCoPage abelAndCoPage;

        public AbelAndCoSteps()
        {
            abelAndCoPage = new AbelAndCoPage();
        }


        [When(@"I enter my search item in the search ""(.*)""")]
        public void WhenIEnterMySearchItemInTheSearch(string item)
        {
            abelAndCoPage.EnterSearchItem(item);

        }
        
        [When(@"I click on Search")]
        public void WhenIClickOnSearch()
        {
            abelAndCoPage.ClickSearchButton();
        }

        [When(@"I click on Add for Brownie Tray")]
        public void WhenIClickOnAddForBrownieTray()
        {
            abelAndCoPage.ClickAddButton();
        }

        [Given(@"I click on Accept cookies")]
        public void GivenIClickOnAcceptCookies()
        {
            abelAndCoPage.ClickAcceptCookie();
        }


    }
}
