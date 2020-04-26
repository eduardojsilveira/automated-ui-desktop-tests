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

        private static Lazy<CalculatorApp> lazy = new Lazy<CalculatorApp>(() => new CalculatorApp());

        public static CalculatorApp Instance => lazy.Value;

        private const string ApplicationName = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        public WindowsDriver<WindowsElement> Session { get;}

        public Standard Standard { get; set; }

        public Scientific Scientific { get; set; }

        public WindowsElement ClearEntry => WinAppWrapper.GetElement(Instance.Session,"clearEntryButton");

        public WindowsElement Result => WinAppWrapper.GetElement(Instance.Session,"CalculatorResults");

        public WindowsElement Header => WinAppWrapper.GetElement(Instance.Session,"Header");

        public WindowsElement ToggleMenuButton => WinAppWrapper.GetElement(Instance.Session,"TogglePaneButton");

        private CalculatorApp()
        {
            Session = WinAppWrapper.OpenSession(ApplicationName);
            Standard = new Standard(Session);
            Scientific = new Scientific(Session);
        }

        public void Close()
        {
            WinAppWrapper.CloseSession(Instance.Session);
        }

        public WindowsElement SwitchToMenu(string option)
        {
            Instance.ToggleMenuButton.Click();
            var menuItems = WinAppWrapper.GetElement(Instance.Session,"MenuItemsHost");
            return (WindowsElement)menuItems?.FindElementByAccessibilityId(option);       
        }
    }
}
