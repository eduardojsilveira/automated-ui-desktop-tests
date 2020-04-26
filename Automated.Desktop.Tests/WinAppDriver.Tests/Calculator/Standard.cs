using Automated.WinAppDriver.UI.Tests;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver.Tests.Calculator
{
    public class Standard
    {
        private static WindowsDriver<WindowsElement> Session;

        public Standard(WindowsDriver<WindowsElement> calculator)
        {
            Session = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        public WindowsElement SquareRootButton => WinAppWrapper.GetElement(Session, "squareRootButton");

        public WindowsElement XSquaredButton => WinAppWrapper.GetElement(Session, "xpower2Button");

        public WindowsElement NegateButton => WinAppWrapper.GetElement(Session, "negateButton");
    }
}
