using System;
using System.Collections.Generic;
using System.Text;
using MoneyBox.Drivers;
using TechTalk.SpecFlow;

namespace MoneyBox.Hooks
{
    [Binding]
    class InitialiseHook
    {

        private readonly ScenarioContext _scenarioContext;

        public InitialiseHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialise()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            appiumDriver.InitialiseAppiumDriver();
        }
    }
}
