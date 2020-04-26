using FluentAssertions;
using TechTalk.SpecFlow;
using WinAppDriver.Tests.Calculator;
using OpenQA.Selenium.Appium.Windows;
using WinAppDriver.Tests.Actions;
using CSF.Screenplay;

namespace WinAppDriver.Tests
{
    [Binding]
    public class CommonHooks : StepsBase
    {
        private static CalculatorApp Calculator;

        public CommonHooks(IStage stage) : base(stage)
        {
        }
        [BeforeTestRun]
        public static void LaunchApplication()
        {
            Calculator = CalculatorApp.Instance;
        }

        [Before("Scientific", Order = 2)]
        public void GoToScentificCalculator()
        {
            User.AttemptsTo(SwitchToMenu.Scientific);         
        }

        [Before("Standard", Order = 2)]
        public void GoToStandardCalculator()
        {
            User.AttemptsTo(SwitchToMenu.Standard);
        }

        [AfterTestRun]
        public static void CloseApplication()
        {
            Calculator.Close();
        }

        [Before(Order = 1)]
        public void BeforeScenario()
        {
            //Actor newUser = new Actor("User");
            //IActorFacade user = newUser;
            //user = newUser.CanUse(Calculator);
            //Context.Set(user);
        }

        [AfterScenario("Standard", "Scientific")]
        public void ClearOperations()
        {
            User.AttemptsTo<ClearEntry>();
        }

    }
}
