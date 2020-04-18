using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automated.WinAppDriver.UI.Tests
{
    public class WinAppWrapper
    {
        private const string WinAppDriverUrl = "http://127.0.0.1:4723";
        public static WindowsDriver<WindowsElement> Session { get; private set; }

        public static void OpenSession(string applicationName)
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("app", applicationName);
            desiredCapabilities.SetCapability("deviceName", "WindowsPC");
            Session = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl),desiredCapabilities);
            Session.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
        }

        public static void CloseSession()
        {
            if(Session != null)
            {
                Session.Quit();
                Session = null;
            }
        }
    }
}
