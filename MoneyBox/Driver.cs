using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;

namespace MoneyBox
{
    public class Driver
    {
        public AppiumDriver<AndroidElement> _driver;

        public void InitialiseDriver()
        {
            var appPath = @"moneyBox.apk";

            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 28");
            driverOption.AddAdditionalCapability(MobileCapabilityType.App, appPath);

            driverOption.AddAdditionalCapability("chromedriverExecutable", @"C:\driver\chromedriver.exe");
            _driver = new AndroidDriver<AndroidElement>(new Uri("https://moneybox.com"), driverOption);

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
