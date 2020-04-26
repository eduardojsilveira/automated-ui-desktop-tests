using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranquire;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Actions
{
    public class MenuItem : ActionUnit<CalculatorApp>
    {
        public override string Name => "Switch to Menu";

        public string Option { get; set; }

        public MenuItem(string option)
        {
            Option = option;
        }

        protected override void ExecuteWhen(IActor actor, CalculatorApp ability)
        {
            ability.SwitchToMenu(Option)?.Click();
        }
    }
}
