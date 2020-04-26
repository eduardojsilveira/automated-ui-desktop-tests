using CSF.Screenplay.Integration;
using WinAppDriver.Tests.Screenplay.Abilities;

[assembly: CSF.Screenplay.SpecFlow.ScreenplayAssembly(typeof(WinAppDriver.Tests.ScreenplayIntegrationConfig))]
namespace WinAppDriver.Tests
{

    public class ScreenplayIntegrationConfig : IIntegrationConfig
    {
        public void Configure(IIntegrationConfigBuilder builder)
        {
            builder.ServiceRegistrations.PerTestRun.Add(b =>
            {
                b.RegisterType<ExecuteCalculator>();
            });
        }
    }
}
