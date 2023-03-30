using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects
{
    public class MatProgressBarPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _channelStatus = By.CssSelector(".channel-status");
        private readonly By _scheduler = By.Id("main-scheduler");
        private readonly By _mainConfiguration = By.Id("main-configuration");
        private readonly By _mainMode = By.Id("main-mode");
        private readonly By _mainState = By.Id("main-state");
        private readonly By _mainConnection = By.Id("main-connection");
        private readonly By _mainHelp = By.Id("main-help");

        public MatProgressBarPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MatProgressBarPageObject Scheduler()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_scheduler).Click();

            return new MatProgressBarPageObject(_webDriver);
        }

        public MatProgressBarPageObject MainConfiguration()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_mainConfiguration).Click();

            return new MatProgressBarPageObject(_webDriver);
        }

        public MatProgressBarPageObject MainMode()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_mainMode).Click();

            return new MatProgressBarPageObject(_webDriver);
        }

        public MatProgressBarPageObject MainState()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_mainState).Click();

            return new MatProgressBarPageObject(_webDriver);
        }

        public MatProgressBarPageObject MainConnection()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_mainConnection).Click();

            return new MatProgressBarPageObject(_webDriver);
        }

        public MatProgressBarPageObject MainHelp()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_mainHelp).Click();

            return new MatProgressBarPageObject(_webDriver);
        }
    }
}
