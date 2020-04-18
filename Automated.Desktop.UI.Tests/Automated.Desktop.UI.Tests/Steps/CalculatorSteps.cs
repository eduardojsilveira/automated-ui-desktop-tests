using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using FluentAssertions.Execution;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using FlaUI.Core.AutomationElements;

namespace Automated.FlaUI.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private const string ApplicationName = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string number)
        {
            using (FlaUIWrapper.Automation)
            {
                Keyboard.Type(number);
            }
        }
       
        [When(@"I press the operator (.*)")]
        public void WhenIPressTheOperator(string operation)
        {
            using (FlaUIWrapper.Automation)
            {
                Keyboard.Type(operation);
            }
            
        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(string number)
        {
            using (FlaUIWrapper.Automation)
            {
                Keyboard.Type(number);
                Keyboard.Type(VirtualKeyShort.ENTER);
            }
        }

        [Then(@"the result (.*) should be shown on the screen")]
        public void ThenTheResultShouldBeShownOnTheScreen(string result)
        {
            using (FlaUIWrapper.Automation)
            {
                var element = FlaUIWrapper.MainWindow.FindFirstDescendant(x => x.ByAutomationId("CalculatorResults")).AsTextBox();
                using (new AssertionScope())
                {
                    element.Should().NotBeNull();
                    element.Name.Should().Contain(result);
                }
            }
        }

        [BeforeFeature]
        public static void LaunchApplication()
        {
            FlaUIWrapper.LaunchApplication(ApplicationName);
        }

        [AfterFeature]
        public static void CloseApplication()
        {
            FlaUIWrapper.App.Close();
        }

        [AfterScenario("Standard", "Scentific")]
        public void ClearOperations()
        {
            var element = FlaUIWrapper.MainWindow.FindFirstDescendant(x => x.ByAutomationId("clearEntryButton"))?.AsButton();
            element.Click();
        }
    }
}
