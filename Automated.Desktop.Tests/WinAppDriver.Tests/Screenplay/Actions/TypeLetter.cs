

using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using WinAppDriver.Tests.Screenplay.Abilities;

namespace WinAppDriver.Tests.Screenplay.Actions
{
    public class TypeLetter : Performable
    {
        public string Expression { get; }
        public TypeLetter(string expression)
        {
            Expression = expression;
        }

        protected override void PerformAs(IPerformer actor)
        {
            var ability = actor.GetAbility<ExecuteCalculator>();
            ability.GetApp().Session.Keyboard.SendKeys(Expression);
        }
    }
}
