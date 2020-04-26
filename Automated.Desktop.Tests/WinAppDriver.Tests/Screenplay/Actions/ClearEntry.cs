
using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Actions
{
    public class ClearEntry : Performable
    {
        protected override void PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<ExecuteCalculator>();
            ability.GetApp().ClearEntry.Click();
        }
    }
}
