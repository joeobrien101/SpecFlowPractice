using System;
using TechTalk.SpecFlow;

namespace SpecFlowPractice
{
    [Binding]
    public class CalculatorSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public CalculatorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _scenarioContext.Pending();
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            _scenarioContext.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            _scenarioContext.Pending();
        }
    }
}
