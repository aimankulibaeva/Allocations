using System;
using MoneyBox.Drivers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MoneyBox.Steps
{
    [Binding]
    public class CautiousTabSteps
    {
        private readonly ScenarioContext _scenarioContext;
        CautiousTab cautiousTab = new CautiousTab();
        AppiumDriver appiumDriver = new AppiumDriver();
        public CautiousTabSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            //Login method
        }
        
        [Given(@"I am on the Allocations page")]
        public void GivenIAmOnTheAllocationsPage()
        {
            //NavigatingToAllocationsPage
        }
        
        [When(@"I Click Cautious Tab")]
        public void WhenIClickCautiousTab()
        {
            cautiousTab.ClickCautiousTab();
        }
        [Then(@"I can see Allocations '(.*)' in a Cash Fund")]
        public void ThenICanSeeAllocationsInACashFund(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(cautiousTab.cautiousTabCashFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

        [Then(@"I can see Allocations '(.*)' in a Shares Fund")]
        public void ThenICanSeeAllocationsInASharesFund(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(cautiousTab.cautiousTabGlobalSharesFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }

        [Then(@"I can see Allocations '(.*)' in a Property Shares Fund")]
        public void ThenICanSeeAllocationsInAPropertySharesFund(int value)
        {
            var percentage = appiumDriver.Driver.FindElement(cautiousTab.cautiousTabPropertySharesFundPercentage).Text;
            Assert.AreEqual(percentage, value);
        }


    }
}
