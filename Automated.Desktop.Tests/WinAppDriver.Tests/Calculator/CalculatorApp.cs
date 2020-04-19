using Automated.WinAppDriver.UI.Tests;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver.Tests.Calculator
{
    public class CalculatorApp
    {
        private const string ApplicationName = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        public static WindowsDriver<WindowsElement> Session { get; private set; }

        public static StandardCalculator Standard { get; private set; }

        public static ScientificCalculator Scientific { get; private set; }

        public static WindowsElement ClearEntry => Session?.FindElementByAccessibilityId("clearEntryButton");

        public static WindowsElement CalculatorResults => Session?.FindElementByAccessibilityId("CalculatorResults");

        public static WindowsElement Header => Session?.FindElementByAccessibilityId("Header");

        private static WindowsElement ToggleMenuButton => Session?.FindElementByAccessibilityId("TogglePaneButton");

        public static void StartCalculator()
        {
            Session = WinAppWrapper.OpenSession(ApplicationName);
            Standard = new StandardCalculator(Session);
            Scientific = new ScientificCalculator(Session);
        }

        public static void CloseCalculator()
        {
            WinAppWrapper.CloseSession(Session);
        }

        public static void SwitchToMenu(string option)
        {
            ToggleMenuButton.Click();
            var menuItems = Session?.FindElementByAccessibilityId("MenuItemsHost");
            var menuOption = menuItems?.FindElementByAccessibilityId(option);
            menuOption?.Click();
        }
    }
}
