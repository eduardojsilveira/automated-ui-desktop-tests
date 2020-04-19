using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver.Tests.Calculator
{
    public class StandardCalculator
    {
        private static WindowsDriver<WindowsElement> Calculator;

        public StandardCalculator(WindowsDriver<WindowsElement> calculator)
        {
            Calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        public WindowsElement SquareRootButton => Calculator?.FindElementByAccessibilityId("squareRootButton");

        public WindowsElement XSquaredButton => Calculator?.FindElementByAccessibilityId("xpower2Button");

        public WindowsElement NegateButton => Calculator?.FindElementByAccessibilityId("negateButton");
    }
}
