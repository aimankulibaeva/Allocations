using System;
using MoneyBox.Drivers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MoneyBox.Steps
{
    [Binding]
    public class BalancedTabTestsSteps
    {
        BalancedTab balancedTab = new BalancedTab();
        AppiumDriver appiumDriver = new AppiumDriver();

        [When(@"I Click Balanced Tab")]
        public void WhenIClickBalancedTab()
        {
            balancedTab.ClickBalancedTab();
        }

        [Then(@"I should see Cash Fund Allocation '(.*)' on the Balanced Tab")]
        public void ThenIShouldSeeCashFundAllocationOnTheBalancedTab(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(balancedTab.balancedTabCashFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

        [Then(@"I should see Shares Fund Allocation '(.*)' on the Balanced Tab")]
        public void ThenIShouldSeeSharesFundAllocationOnTheBalancedTab(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(balancedTab.balancedTabGlobalSharesFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

        [Then(@"I should see Property Shares Fund Allocation '(.*)' on the Balanced Tab")]
        public void ThenIShouldSeePropertySharesFundAllocationOnTheBalancedTab(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(balancedTab.balancedTabPropertySharesFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

    }
}
