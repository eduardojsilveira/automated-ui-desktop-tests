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

        public static WindowsDriver<WindowsElement> OpenSession(string applicationName)
        {
            WindowsDriver<WindowsElement> session;
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("app", applicationName);
            desiredCapabilities.SetCapability("deviceName", "WindowsPC");
            session = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl),desiredCapabilities);
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);
            return session;
        }

        public static void CloseSession(WindowsDriver<WindowsElement> session)
        {
            if(session != null)
            {
                session.Quit();
            }
        }
    }
}
