using CSF.Screenplay.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriver.Tests.Calculator;

namespace WinAppDriver.Tests.Screenplay.Abilities
{
    public class ExecuteCalculator : Ability
    {
        public CalculatorApp GetApp()
        {
            return CalculatorApp.Instance;
        }
    }
}
