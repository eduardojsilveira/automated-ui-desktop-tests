using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
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
            session = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl), desiredCapabilities);
            return session;
        }

        public static WindowsElement GetElement(WindowsDriver<WindowsElement> session, string automationId, int timeout = 5000)
        {
            if (session == null) throw new ArgumentNullException(nameof(session));

            WindowsElement element = null;

            var wait = new DefaultWait<WindowsDriver<WindowsElement>>(session)
            {
                Timeout = TimeSpan.FromMilliseconds(timeout),
                Message = $"Component {automationId} not found",
            };

            wait.IgnoreExceptionTypes(typeof(WebDriverException));

            try
            {
                wait.Until(s =>
                {
                    element = session.FindElementByAccessibilityId(automationId);

                    return element != null;
                });
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return element;
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
