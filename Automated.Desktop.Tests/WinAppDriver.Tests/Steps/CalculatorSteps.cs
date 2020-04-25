using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using WinAppDriver.Tests.Calculator;

namespace Automated.FlaUI.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(double number)
        {
            CalculatorApp.Session.Keyboard.SendKeys(number.ToString().Replace(".",","));

            if (number < default(double))
                CalculatorApp.Standard.NegateButton.Click();          
        }
       
        [When(@"I press the operator (.*)")]
        public void WhenIPressTheOperator(string operation)
        {
            string value;

            switch (operation)
            {
                case "+":
                    value = Keys.Add;
                    break;
                case "-":
                    value = Keys.Subtract;
                    break;
                case "*":
                    value = Keys.Multiply;
                    break;
                case @"/":
                    value = Keys.Divide;
                    break;
                default:
                    value = null;
                    break;
            }


            CalculatorApp.Session.Keyboard.SendKeys(value);

        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(double number)
        {
            CalculatorApp.Session.Keyboard.SendKeys(number.ToString().Replace(".",","));
            CalculatorApp.Session.Keyboard.SendKeys(Keys.Enter);
        }

        [When(@"I press the square function")]
        public void WhenIPressTheSquareFunction()
        {
            CalculatorApp.Standard.SquareRootButton.Click();
        }

        [When(@"I press the x squared function")]
        public void WhenIPressTheXSquaredFunction()
        {
            CalculatorApp.Standard.XSquaredButton.Click();
        }

        [When(@"I press the x cubed function")]
        public void WhenIPressTheXCubedFunction()
        {
            CalculatorApp.Scientific.XCubeButton.Click();
        }

        [When(@"I press the factorial function")]
        public void WhenIPressTheFactorialFunction()
        {
            CalculatorApp.Scientific.FactorialButton.Click();
        }


        [Then(@"the result (.*) should be shown on the screen")]
        public void ThenTheResultShouldBeShownOnTheScreen(string result)
        {
            var element = CalculatorApp.CalculatorResults;
            element.Should().NotBeNull();
            element.Text.Should().Contain(result.ToString());
        }

        [BeforeTestRun]
        public static void LaunchApplication()
        {
            CalculatorApp.StartCalculator();
        }

        [BeforeFeature("Scientific")]
        public static void GoToScentificCalculator()
        {
            CalculatorApp.SwitchToMenu("Scientific");
        }

        [BeforeFeature("Standard")]
        public static void GoToStandardCalculator()
        {
            CalculatorApp.SwitchToMenu("Standard");
        }

        [AfterTestRun]
        public static void CloseApplication()
        {
            CalculatorApp.CloseCalculator();
        }

        [AfterScenario("Standard", "Scientific")]
        public void ClearOperations()
        {
            var element = CalculatorApp.ClearEntry;
            element.Should().NotBeNull();
            element.Click();
        }
    }
}
