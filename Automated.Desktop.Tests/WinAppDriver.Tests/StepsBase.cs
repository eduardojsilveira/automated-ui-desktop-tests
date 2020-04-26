using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WinAppDriver.Tests
{
    public abstract class StepsBase
    {
        public ScenarioContext Context { get; }

        public StepsBase(ScenarioContext context)
        {
            Context = context;
        }
    }
}
