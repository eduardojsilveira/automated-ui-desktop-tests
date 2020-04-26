using CSF.Screenplay;
using CSF.Screenplay.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WinAppDriver.Tests.Screenplay.Actors;

namespace WinAppDriver.Tests
{
    public abstract class StepsBase
    {
        readonly IStage _stage;

        public IActor User => _stage.GetTheActorInTheSpotlight();

        public StepsBase(IStage stage)
        {
            _stage = stage ?? throw new ArgumentNullException(nameof(stage));           
        }
    }
}
