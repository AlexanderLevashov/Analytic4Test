using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects.CommonPageObject
{
    public class ModePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _plannerControlMenu = By.CssSelector(".control-menu");
        private readonly By _modeLoad = By.Id("mode-load");
        private readonly By _appMethodDiaglog = By.CssSelector(".mat-dialog-container app-method-dialog");

        #region Эмулятор краны
        private readonly By _valves = By.Id("valves");
        private readonly By _ports = By.Id("ports");
        private readonly By _columns = By.Id("columns");
        private readonly By _detectors = By.Id("detectors");
        #endregion

        private readonly By _thermostates = By.Id("thermostates");
        private readonly By _signals = By.Id("signals");
        private readonly By _events = By.Id("events");
        private readonly By _modeSave = By.Id("mode-save");
        private readonly By _modeApply = By.Id("mode-apply");

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

        public ModePageObject Valves()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_valves).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject Ports()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_ports).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject Columns()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_columns).Click();

            return new ModePageObject(_webDriver);
        }

        public ModePageObject Detectors()
        {
            WaitUntil.WaitElement(_webDriver, _plannerControlMenu);
            _webDriver.FindElement(_detectors).Click();

            return new ModePageObject(_webDriver);
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
