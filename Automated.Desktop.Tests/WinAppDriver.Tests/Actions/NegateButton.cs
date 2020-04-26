using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranquire;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Actions
{
    public class NegateButton : ActionUnit<CalculatorApp>
    {
        public override string Name => "Click on the Negate Button";

        protected override void ExecuteWhen(IActor actor, CalculatorApp ability)
        {
            ability.Standard.NegateButton.Click();
        }
    }
}
