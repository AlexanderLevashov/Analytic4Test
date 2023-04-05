using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects
{
    public class ModePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _plannerControlMenu = By.CssSelector(".control-menu");
        private readonly By _modeLoad = By.XPath("//app-mode/div[1]/div[1]/button");
        private readonly By _appMethodDiaglog = By.CssSelector(".mat-dialog-container app-method-dialog");

        private readonly By _thermostates = By.XPath("//app-mode/div[1]/div[2]/button");
        private readonly By _signals = By.XPath("//app-mode/div[1]/div[3]/button");
        private readonly By _events = By.XPath("//app-mode/div[1]/div[4]/button");
        private readonly By _modeSave = By.XPath("//app-mode/div[1]/div[5]/button");
        private readonly By _modeApply = By.XPath("//app-mode/div[1]/div[6]/button");

        private readonly By _analysisThermostates = By.XPath("//mat-tab-header/div/div/div[1]/div[1]");
        private readonly By _blowingThermostates = By.XPath("//mat-tab-header/div/div/div[1]/div[2]");

        public ModePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public ModePageObject ModeLoad()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_modeLoad).Click();

            WaitUntil.WaitElement(_webDriver, _appMethodDiaglog);

            return this;
        }

        public ModePageObject Thermostates()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_thermostates).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject Signals()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_signals).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject Events()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_events).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject ModeSave()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_modeSave).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject ModeApply()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_modeApply).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject AnalysisThermostates()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_analysisThermostates).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject BlowingThermostates()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_blowingThermostates).Click();

            return new ModePageObject(_webDriver);
        }
    }
}
