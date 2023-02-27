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
            int x = _sc.Get<int>("firstNumber");
            int y = _sc.Get<int>("secondNumber");
            int solution = x + y;
            _sc.Add("solution", solution);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Calculator c = new Calculator();
            int res = c.AddTwoIntegers(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
            _sc.Add("result", res);
        }
    }
}