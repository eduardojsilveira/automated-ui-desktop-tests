using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver.Tests.Actions
{
    public static class Click
    {
        public static ClearEntry ClearEntryButton => new ClearEntry();

        public static NegateButton NegateNumberButton => new NegateButton();
    }
}
