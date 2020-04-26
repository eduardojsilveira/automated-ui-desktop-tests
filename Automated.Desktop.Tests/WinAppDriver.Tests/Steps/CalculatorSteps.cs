using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using WinAppDriver.Tests.Calculator;
using Tranquire;
using WinAppDriver.Tests;
using WinAppDriver.Tests.Actions;
using WinAppDriver.Tests.Questions;

namespace Automated.FlaUI.Tests.Steps
{
    [Binding]
    public class CalculatorSteps : StepsBase
    {
        public CalculatorSteps(ScenarioContext context) : base(context)
        {
           
        }
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(double number)
        {
            Context.User().Given(Keyboard.TypeNumber(number));        
        }
       
        [When(@"I press the operator (.*)")]
        public void WhenIPressTheOperator(string operation)
        {
            Context.User().When(Keyboard.TypeOperator(operation));
        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(double number)
        {
            Context.User().When(Keyboard.TypeKeys(number.ToString().Replace(".", ",")), Keyboard.TypeKeys(Keys.Enter));
        }

        [When(@"I press the square function")]
        public void WhenIPressTheSquareFunction()
        {
            //CalculatorApp.Standard.SquareRootButton.Click();
        }

        [When(@"I press the x squared function")]
        public void WhenIPressTheXSquaredFunction()
        {
            //CalculatorApp.Standard.XSquaredButton.Click();
        }

        [When(@"I press the x cubed function")]
        public void WhenIPressTheXCubedFunction()
        {
            //CalculatorApp.Scientific.XCubeButton.Click();
        }

        [When(@"I press the factorial function")]
        public void WhenIPressTheFactorialFunction()
        {
            //CalculatorApp.Scientific.FactorialButton.Click();
        }


        [Then(@"the result (.*) should be shown on the screen")]
        public void ThenTheResultShouldBeShownOnTheScreen(string expected)
        {
            Context.User().Then(CalculatorResult.Display, result => result.Should().BeEquivalentTo(expected));
        }

        
    }
}
