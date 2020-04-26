using FluentAssertions;
using TechTalk.SpecFlow;
using WinAppDriver.Tests.Calculator;
using Tranquire;
using OpenQA.Selenium.Appium.Windows;
using WinAppDriver.Tests.Actions;

namespace WinAppDriver.Tests
{
    [Binding]
    public class CommonHooks : StepsBase
    {
        private static CalculatorApp Calculator;
        public CommonHooks(ScenarioContext context) : base(context)
        {

        }
        [BeforeTestRun]
        public static void LaunchApplication()
        {
            //driver = Calculator.Calculator.Driver();
            Calculator = CalculatorApp.Instance;
        }

        [Before("Scientific", Order = 2)]
        public void GoToScentificCalculator()
        {
            Context.User().Given(SwitchTo.Scientific);
        }

        [Before("Standard", Order = 2)]
        public void GoToStandardCalculator()
        {
            Context.User().Given(SwitchTo.Standard);
        }

        [AfterTestRun]
        public static void CloseApplication()
        {
            //CalculatorApp.CloseCalculator();
            Calculator.Close();
        }

        [Before(Order = 1)]
        public void BeforeScenario()
        {
            Actor newUser = new Actor("User");
            IActorFacade user = newUser;
            user = newUser.CanUse(Calculator);
            Context.Set(user);
        }

        [AfterScenario("Standard", "Scientific")]
        public void ClearOperations()
        {
            //var element = CalculatorApp.ClearEntry;
            //element.Should().NotBeNull();
            //element.Click();
            Context.User().When(Click.ClearEntryButton);
        }

    }
}
