using System;
using TechTalk.SpecFlow;
using Tranquire;

namespace WinAppDriver.Tests
{
    public static class BaseContext
    {
        public static IActorFacade User(this ScenarioContext context)
        {
            return context.Get<IActorFacade>();
        }
    }
}
