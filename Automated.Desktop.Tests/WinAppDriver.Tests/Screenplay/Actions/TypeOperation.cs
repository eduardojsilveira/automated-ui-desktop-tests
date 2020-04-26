using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriver.Tests.Calculator;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Screenplay.Actions
{
    public class TypeOperation : Performable
    {

        public string Operation { get; }
        public TypeOperation(string operation)
        {
            Operation = operation;
        }

        protected override void PerformAs(IPerformer actor)
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

            var ability = actor.GetAbility<ExecuteCalculator>();
            ability.GetApp().Session.Keyboard.SendKeys(value);
        }
    }
}
