using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranquire;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Actions
{
    public class TypeLetter : ActionUnit<CalculatorApp>
    {
        public override string Name => "Keyboard";

        public string Expression { get; }
        public TypeLetter(string expression)
        {
            Expression = expression;
        }

        protected override void ExecuteWhen(IActor actor, CalculatorApp ability)
        {
            ability.Session.Keyboard.SendKeys(Expression);
        }
    }
}
