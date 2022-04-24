using System;
using System.Collections.Generic;
using System.Text;
using MoneyBox.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace MoneyBox
{
    public class AdventurousTab : AppiumDriver

    {
        AppiumDriver appiumDriver = new AppiumDriver();
        public By adventurousTab = By.Id("allocationtypeAdventurous");
        public By adventurousTabCashFundPercentage = By.Id("");
        public By adventurousTabGlobalSharesFundPercentage = By.Id("allocationPercentage7");
        public By adventurousTabPropertySharesFundPercentage = By.Id("allocationPercentage8");
        public void ClickAdventurousTab()
        {
            Driver.FindElement(adventurousTab).Click();
        }

    }
}
