using OpenQA.Selenium.Appium.Windows;
using System;

namespace WinAppDriver.Tests.Calculator
{
    public class ScientificCalculator
    {
        private static WindowsDriver<WindowsElement> Calculator;

        public ScientificCalculator(WindowsDriver<WindowsElement> calculator)
        {
            Calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        public WindowsElement XSquaredButton => Calculator?.FindElementByAccessibilityId("xpower2Button");

        public WindowsElement XCubeButton => Calculator?.FindElementByAccessibilityId("xpower3Button");

        public WindowsElement FactorialButton => Calculator?.FindElementByAccessibilityId("factorialButton");
    }
}
