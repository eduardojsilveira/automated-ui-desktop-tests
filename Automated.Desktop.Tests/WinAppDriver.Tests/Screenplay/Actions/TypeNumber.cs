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
    public class TypeNumber : Performable
    {
        public double Number { get;  }

        public TypeNumber(double number)
        {
            Number = number;
        }
        protected override void PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<ExecuteCalculator>();
            var text = Number.ToString().Replace(".", ",");
            ability.GetApp().Session.Keyboard.SendKeys(text);

            if (Number < default(double))
                actor.Perform<NegateButton>();
        }
    }
}
