using System;
using MoneyBox.Drivers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MoneyBox.Steps
{
    [Binding]
    public class AdventurousTabTestsSteps
    {
        AdventurousTab adventurousTab = new AdventurousTab();
        AppiumDriver appiumDriver = new AppiumDriver();

        [When(@"I Click Adventurous Tab")]
        public void WhenIClickAdventurousTab()
        {
            adventurousTab.ClickAdventurousTab();
        }

        [Then(@"I should see Cash Fund Allocation '(.*)' on the Adventurous Tab")]
        public void ThenIShouldSeeCashFundAllocationOnTheAdventurousTab(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(adventurousTab.adventurousTabCashFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

        [Then(@"I should see Shares Fund Allocation '(.*)' on the Adventurous Tab")]
        public void ThenIShouldSeeSharesFundAllocationOnTheAdventurousTab(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(adventurousTab.adventurousTabPropertySharesFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

        [Then(@"I should see Property Shares Fund Allocation '(.*)' on the Adventurous Tab")]
        public void ThenIShouldSeePropertySharesFundAllocationOnTheAdventurousTab(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(adventurousTab.adventurousTabPropertySharesFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

    }
}
