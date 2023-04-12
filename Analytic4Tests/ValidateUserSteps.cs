using System;
using TechTalk.SpecFlow;

namespace Analytic4Tests
{
    [Binding]
    public class ValidateUserSteps
    {
        [Given(@"1")]
        public void Given()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"2")]
        public void When()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"3")]
        public void Then()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
