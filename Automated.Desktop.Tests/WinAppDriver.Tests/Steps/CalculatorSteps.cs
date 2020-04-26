using TechTalk.SpecFlow;
using FluentAssertions;
using OpenQA.Selenium;
using WinAppDriver.Tests.Calculator;
using WinAppDriver.Tests;
using WinAppDriver.Tests.Actions;
using WinAppDriver.Tests.Questions;
using CSF.Screenplay;
using System;
using WinAppDriver.Tests.Screenplay.Actors;
using static CSF.Screenplay.StepComposer;
using WinAppDriver.Tests.Screenplay.Actions;

namespace Automated.FlaUI.Tests.Steps
{
    [Binding]
    public class CalculatorSteps : StepsBase
    {
        public CalculatorSteps(IStage stage) : base (stage)
        {          
        }
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(double number)
        {         
            Given(User).WasAbleTo(Keyboard.TypeNumber(number));          
        }
       
        [When(@"I press the operator (.*)")]
        public void WhenIPressTheOperator(string operation)
        {
            When(User).AttemptsTo(Keyboard.TypeOperator(operation));
        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(double number)
        {
            When(User).AttemptsTo(Keyboard.TypeNumber(number));
            When(User).AttemptsTo(Keyboard.TypeKeys(Keys.Enter));
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
            Then(User).ShouldSee(CalculatorResult.Display).Should().BeEquivalentTo(expected);
        }

        
    }
}
