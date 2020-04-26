using Automated.WinAppDriver.UI.Tests;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace WinAppDriver.Tests.Calculator
{
    public class Scientific
    {
        private static WindowsDriver<WindowsElement> Session;

        public Scientific(WindowsDriver<WindowsElement> session)
        {
            Session = session ?? throw new ArgumentNullException(nameof(session));
        }

        public WindowsElement XSquaredButton => WinAppWrapper.GetElement(Session,"xpower2Button");

        public WindowsElement XCubeButton => WinAppWrapper.GetElement(Session, "xpower3Button");

        public WindowsElement FactorialButton => WinAppWrapper.GetElement(Session, "factorialButton");
    }
}
