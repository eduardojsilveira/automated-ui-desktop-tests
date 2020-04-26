using CSF.FlexDi;
using CSF.Screenplay;
using CSF.Screenplay.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Screenplay.Actors
{
    public class User : Persona
    {
        public override string Name => "Calculator's user";

        public override void GrantAbilities(ICanReceiveAbilities actor, IResolvesServices resolver)
        {
            actor.IsAbleTo<ExecuteCalculator>();
        }
    }
}
