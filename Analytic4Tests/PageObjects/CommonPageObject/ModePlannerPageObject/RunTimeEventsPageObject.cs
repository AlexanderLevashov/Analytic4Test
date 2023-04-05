using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects.PageObjectPlanner
{
    public class RunTimeEventsPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _overlay = By.CssSelector(".events");
        private readonly By _timeAnalysisChannelStart_1 = By.XPath("//tr[3]/td[3]/div/app-editable-parameter/app-control/input");
        private readonly By _timeBlowingChannelStart_1 = By.XPath("//tr[4]/td[3]/div/app-editable-parameter/app-control/input");
        private readonly By _stabilisationTimeChannelStart_1 = By.XPath("//tr[5]/td[3]/div/app-editable-parameter/app-control/input");

        private readonly By _hideParameters = By.XPath("//div[2]/div[3]/p4-checkbox/div/a4-check-box/div");

        public RunTimeEventsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public RunTimeEventsPageObject TimeAnalysisChannelStart_1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_timeAnalysisChannelStart_1).Click();

            return new RunTimeEventsPageObject(_webDriver);
        }

        public RunTimeEventsPageObject TimeBlowingChannelStart_1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_timeBlowingChannelStart_1).Click();

            return new RunTimeEventsPageObject(_webDriver);
        }

        public RunTimeEventsPageObject StabilisationTimeChannelStart_1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_stabilisationTimeChannelStart_1).Click();

            return new RunTimeEventsPageObject(_webDriver);
        }

    }
}
