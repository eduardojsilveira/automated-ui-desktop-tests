using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranquire;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Actions
{
    public class TypeNumber : ActionUnit<CalculatorApp>
    {
        public override string Name => "Type Number";

        public double Number { get; }


        public TypeNumber(double number)
        {
            Number = number;
        }


        protected override void ExecuteWhen(IActor actor, CalculatorApp ability)
        {
            ability.Session.Keyboard.SendKeys(Number.ToString().Replace(".", ","));
            if (Number < default(double))
                actor.Execute(Click.NegateNumberButton);
        }
    }
}
