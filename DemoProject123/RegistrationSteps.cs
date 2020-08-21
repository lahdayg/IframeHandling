using System;
using TechTalk.SpecFlow;

namespace DemoProject123
{
    [Binding]
    public class RegistrationSteps
    {
        [When(@"I created another step for demo purposes")]
        public void WhenICreatedAnotherStepForDemoPurposes()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
