using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Screenplay.Actions
{
    public class NegateButton : Performable
    {
        protected override void PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<ExecuteCalculator>();
            ability.GetApp().Standard.NegateButton.Click();
        }
    }
}
