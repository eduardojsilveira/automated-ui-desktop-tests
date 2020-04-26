using OpenQA.Selenium;
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
    public class TypeOperation : ActionUnit<CalculatorApp>
    {
        public override string Name => "Keyboard";

        public string Operation { get; }
        public TypeOperation(string operation)
        {
            Operation = operation;
        }

        protected override void ExecuteWhen(IActor actor, CalculatorApp ability)
        {
            string value = null;
            switch (Operation)
            {
                case "+":
                    value = Keys.Add;
                    break;
                case "-":
                    value = Keys.Subtract;
                    break;
                case "*":
                    value = Keys.Multiply;
                    break;
                case @"/":
                    value = Keys.Divide;
                    break;
                default:
                    value = null;
                    break;
            }

            ability.Session.Keyboard.SendKeys(value);
        }
    }
}
