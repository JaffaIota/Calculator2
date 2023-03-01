using ClassLibrary1;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private ScenarioContext _sc;
           
        public CalculatorStepDefinitions(ScenarioContext scenario) {
            _sc = scenario;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _sc.Add("firstNumber", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _sc.Add("secondNumber", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Calculator c = new Calculator();
            int res = c.AddTwoIntegers(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
            _sc.Add("result", res);
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            Calculator c = new Calculator();
            int res = c.Subtract(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
            _sc.Add("result", res);
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Calculator c = new Calculator();
            int res = c.Multiplied(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
            _sc.Add("result", res);
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            Calculator c = new Calculator();
            int res = c.Divide(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
            _sc.Add("result", res);
        }

        //There was a better way
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _sc.Get<int>("result").Should().Be(result);
        }
    }
}