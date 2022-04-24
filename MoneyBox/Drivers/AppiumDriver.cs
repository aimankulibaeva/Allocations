using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;

namespace MoneyBox.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set;  }

        public AndroidDriver<AppiumWebElement> InitialiseAppiumDriver()
        {
            var appPath = @"moneyBox.apk";

            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 28");
            driverOption.AddAdditionalCapability(MobileCapabilityType.App, appPath);

            driverOption.AddAdditionalCapability("chromedriverExecutable", @"C:\driver\chromedriver.exe");

            var _driver = new AndroidDriver<AppiumWebElement>(new Uri("https://moneybox.com"), driverOption);
            return _driver;

            var contexts = ((IContextAware)_driver).Contexts;
            string webviewContext = null;
            for (int i = 0; i < contexts.Count; i++)
            {
                Console.WriteLine(contexts[i]);
                if (contexts[i].Contains("WEBVIEW"))
                {
                    webviewContext = contexts[i];
                    break;
                }
            }

            ((IContextAware)_driver).Context = webviewContext;
        }
    }
}
