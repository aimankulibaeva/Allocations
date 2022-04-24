using System;
using System.Collections.Generic;
using System.Text;
using MoneyBox.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace MoneyBox
{
    public class CautiousTab : AppiumDriver

    {
        AppiumDriver appiumDriver = new AppiumDriver();
        public By cautiousTab = By.Id("allocationtypeCaution");
        public By cautiousTabCashFundPercentage = By.Id("allocationPercentage4");
        public By cautiousTabGlobalSharesFundPercentage = By.Id("allocationPercentage4");
        public By cautiousTabPropertySharesFundPercentage = By.Id("allocationPercentage4");
        public void ClickCautiousTab()
        {
            Driver.FindElement(cautiousTab).Click();
        }

    }
}
