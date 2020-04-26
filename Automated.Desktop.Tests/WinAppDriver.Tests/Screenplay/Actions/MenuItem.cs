using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriver.Tests.Calculator;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Actions
{
    public class MenuItem : Performable
    {
        public string Option { get;}

        public MenuItem(string option)
        {
            Option = option;
        }

        protected override void PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<ExecuteCalculator>();
            ability.GetApp().SwitchToMenu(Option)?.Click();
        }
    }
}
