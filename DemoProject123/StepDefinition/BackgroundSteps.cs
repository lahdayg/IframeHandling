using System;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class BackgroundSteps
    {
        [When(@"I click on New Article")]
        public void WhenIClickOnNewArticle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I write my Article Title")]
        public void WhenIWriteMyArticleTitle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I write what my article is all about")]
        public void WhenIWriteWhatMyArticleIsAllAbout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I write my Article")]
        public void WhenIWriteMyArticle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter tags")]
        public void WhenIEnterTags()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on publish Article")]
        public void WhenIClickOnPublishArticle()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Global Feed")]
        public void WhenIClickOnGlobalFeed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my article should be created successfully")]
        public void ThenMyArticleShouldBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see all global feed")]
        public void ThenIShouldBeAbleToSeeAllGlobalFeed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
