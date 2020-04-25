using Automated.WinAppDriver.UI.Tests;
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

        public WindowsElement XSquaredButton => WinAppWrapper.GetElement(Calculator,"xpower2Button");

        public WindowsElement XCubeButton => WinAppWrapper.GetElement(Calculator, "xpower3Button");

        public WindowsElement FactorialButton => WinAppWrapper.GetElement(Calculator, "factorialButton");
    }
}
