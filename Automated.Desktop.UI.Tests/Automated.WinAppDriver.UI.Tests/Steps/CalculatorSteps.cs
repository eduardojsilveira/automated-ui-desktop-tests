using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using FluentAssertions.Execution;
using Automated.WinAppDriver.UI.Tests;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace Automated.FlaUI.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private const string ApplicationName = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string number)
        {
            WinAppWrapper.Session.Keyboard.SendKeys(number);

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


            WinAppWrapper.Session.Keyboard.SendKeys(value);

        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(string number)
        {
            WinAppWrapper.Session.Keyboard.SendKeys(number);
            WinAppWrapper.Session.Keyboard.SendKeys(Keys.Enter);
        }

        [Then(@"the result (.*) should be shown on the screen")]
        public void ThenTheResultShouldBeShownOnTheScreen(string result)
        {
            var element = WinAppWrapper.Session.FindElementByAccessibilityId("CalculatorResults");
            element.Should().NotBeNull();
            element.Text.Should().Contain(result);
        }

        [BeforeFeature]
        public static void LaunchApplication()
        {
            //FlaUIWrapper.LaunchApplication(ApplicationName);
            WinAppWrapper.OpenSession(ApplicationName);
        }

        [AfterFeature]
        public static void CloseApplication()
        {
            WinAppWrapper.CloseSession();
        }

        [AfterScenario("Standard", "Scentific")]
        public void ClearOperations()
        {
            var element = WinAppWrapper.Session.FindElementByAccessibilityId("clearEntryButton");
            element.Click();
        }
    }
}
