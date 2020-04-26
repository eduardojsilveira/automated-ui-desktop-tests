using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranquire;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Actions
{
    public class ClearEntry : ActionUnit<CalculatorApp>
    {
        public override string Name => "Cleaning the results";

        protected override void ExecuteWhen(IActor actor, CalculatorApp ability)
        {
            ability.ClearEntry.Click();
        }
    }
}
