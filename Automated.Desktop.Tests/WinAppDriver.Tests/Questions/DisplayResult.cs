using Automated.WinAppDriver.UI.Tests;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranquire;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Questions
{
    public class DisplayResult : Question<string, CalculatorApp>
    {
        public override string Name => "Calculator Results";

        protected override string Answer(IActor actor, CalculatorApp ability)
        {
            return ability.Result?.Text.Replace("Display is", string.Empty).Trim();
        }
    }
}
