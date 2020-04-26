

using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Questions
{
    public class DisplayResult : Question<string>
    {
        protected override string PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<ExecuteCalculator>();
            return ability.GetApp().Result.Text.Replace("Display is", string.Empty).Trim();
        }
    }
}
