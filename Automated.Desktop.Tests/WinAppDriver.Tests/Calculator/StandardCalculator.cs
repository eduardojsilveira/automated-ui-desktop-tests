using Automated.WinAppDriver.UI.Tests;
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

        public WindowsElement SquareRootButton => WinAppWrapper.GetElement(Calculator, "squareRootButton");

        public WindowsElement XSquaredButton => WinAppWrapper.GetElement(Calculator, "xpower2Button");

        public WindowsElement NegateButton => WinAppWrapper.GetElement(Calculator, "negateButton");
    }
}
