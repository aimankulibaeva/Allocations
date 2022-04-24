using System;
using System.Collections.Generic;
using System.Text;
using MoneyBox.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace MoneyBox
{
    public class BalancedTab : AppiumDriver

    {
        AppiumDriver appiumDriver = new AppiumDriver();
        public By balancedTab = By.Id("allocationtypeBalanced");
        public By balancedTabCashFundPercentage = By.Id("allocationPercentage1");
        public By balancedTabGlobalSharesFundPercentage = By.Id("allocationPercentage2");
        public By balancedTabPropertySharesFundPercentage = By.Id("allocationPercentage3");
        public void ClickBalancedTab()
        {
            Driver.FindElement(balancedTab).Click();
        }

    }
}
