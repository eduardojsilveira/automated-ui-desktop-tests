using System;
using System.Collections.Generic;
using System.Text;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA2;

namespace Automated.FlaUI.Tests
{
    public class FlaUIWrapper
    {

        public static string ApplicationName { get; private set; }
        public static Application App { get; private set; }

        public static AutomationBase Automation { get; private set; }
        

        public static void LaunchApplication(string applicationName)
        {
            Automation = new UIA2Automation();
            App = Application.LaunchStoreApp(applicationName);
            MainWindow = App.GetMainWindow(Automation);
        }

        public static Window MainWindow { get; private set; }

        public AutomationElement FindElementByAutomationId(string automationId)
        {
            return MainWindow.FindFirstDescendant(x => x.ByAutomationId(automationId));
        }

    }
}
