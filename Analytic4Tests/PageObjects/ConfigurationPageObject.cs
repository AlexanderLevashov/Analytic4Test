using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analytic4Tests.PageObjects
{
    public class ConfigurationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _channelStatus = By.CssSelector(".channel-status");

        private readonly By _btnApplyConfiguration = By.Id("configuration-apply");
        private readonly By _btnAddDevice = By.Id("device-add");
        private readonly By _matMenuContent = By.CssSelector(".mat-menu-content");
        private readonly By _matMenuParameters = By.CssSelector(".vertical-list span");
        private readonly By _btnDeleteDevice = By.Id("device-delete");
        private readonly By _btnSaveConf = By.Id("configuration-save");

        public ConfigurationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public ConfigurationPageObject ApplyConfiguration()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_btnApplyConfiguration).Click();

            return new ConfigurationPageObject(_webDriver);
        }

        public ConfigurationPageObject AddDevice(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_btnAddDevice).Click();

            WaitUntil.WaitElement(_webDriver, _matMenuContent);
            _webDriver.FindElements(_matMenuParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ConfigurationPageObject DeleteDevice()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_btnDeleteDevice).Click();

            return new ConfigurationPageObject(_webDriver);
        }

        public ConfigurationPageObject SaveConf()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_btnSaveConf).Click();

            return new ConfigurationPageObject(_webDriver);
        }

    }
}
