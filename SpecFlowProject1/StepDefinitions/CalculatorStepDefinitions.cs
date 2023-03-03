using ClassLibrary1;
using NUnit.Framework;
using TechTalk.SpecFlow.CommonModels;

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

        [Given(@"the first real number is (.*)")]
        public void GivenTheFirstRealNumberIs(double number)
        {
            _sc.Add("firstDouble", number);
        }

        [Given(@"the second real number is (.*)")]
        public void GivenTheSecondRealNumberIs(double number)
        {
            _sc.Add("secondDouble", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Calculator c = new Calculator();
            try
            {
                int res = c.AddTwoIntegers(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
                _sc.Add("result", res);
            }
            catch (Exception ex)
            {
                _sc.Add("Error", ex);
            }
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            Calculator c = new Calculator();
            int res = c.SubTwoIntegers(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
            _sc.Add("result", res);
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            Calculator c = new Calculator();
            try
            {
                int res = c.DivTwoIntegers(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
                _sc.Add("result", res);
            }
            catch (Exception ex)
            {
                _sc.Add("Error", ex);
            }
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Calculator c = new Calculator();
            try
            {
                int res = c.MultTwoIntegers(_sc.Get<int>("firstNumber"), _sc.Get<int>("secondNumber"));
                _sc.Add("result", res);
            }
            catch (Exception ex)
            {
                _sc.Add("Error", ex);
            }
        }

        [When(@"the two real numbers are divided")]
        public void WhenTheTwoRealNumbersAreDivided()
        {
            Calculator c = new Calculator();
            try
            {
                double res = c.DivTwoDoubles(_sc.Get<double>("firstDouble"), _sc.Get<double>("secondDouble"));
                _sc.Add("result", res);
            }
            catch (Exception ex)
            {
                _sc.Add("Error", ex);
            }
        }

        [When(@"the two real numbers are multiplied")]
        public void WhenTheTwoRealNumbersAreMultiplied()
        {
            Calculator c = new Calculator();
            double res = c.MultTwoDoubles(_sc.Get<double>("firstDouble"), _sc.Get<double>("secondDouble"));
            _sc.Add("result", res);
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _sc.Get<int>("result").Should().Be(result);
        }

        [Then(@"the real result should be close to (.*)")]
        public void ThenTheRealResultShouldBeCloseTo(Double result)
        {
            double accuracy = .01;
            _sc.Get<double>("result").Should().BeInRange(result - accuracy, result + accuracy); //could have used .Should.BeApproximately if floats not doubles
        }

        [Then(@"it will throw an exception")]
        public void ThenItWillThrowAnException()
        {

            Assert.IsNotNull(_sc.Get<Exception>("Error"));
        }

    }
}