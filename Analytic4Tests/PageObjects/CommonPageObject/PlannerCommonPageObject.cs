using OpenQA.Selenium;
using System.Linq;

namespace Analytic4Tests.PageObjects.CommonPageObject
{
    public class PlannerCommonPageObject
    {
        private IWebDriver _webDriver;

        #region Overlay
        private readonly By _channelStatus = By.CssSelector(".channel-status");
        private readonly By _analysisSeries = By.CssSelector(".analysis-series");
        private readonly By _obscure = By.CssSelector(".cdk-overlay-backdrop");
        #endregion

        #region Левая панель
        private readonly By _startAnalysis = By.Id("analysis-start");
        private readonly By _stopAnalysis = By.Id("analysis-stop");
        private readonly By _repeatAnalysis = By.Id("analysis-repeat");
        private readonly By _addAnalysis = By.Id("analysis-add");
        private readonly By _sheschedulerSettings = By.Id("scheduler-settings");
        private readonly By _panelAddAnalysis = By.CssSelector(".mat-menu-panel");
        private readonly By _panelMatAnalysis = By.CssSelector(".mat-menu-item");
        private readonly By _deleteAnalysis = By.Id("analysis-delete");
        #endregion

        private readonly By _settingsFirstPanel = By.XPath("//div[3]/div[2]/div");
        private readonly By _commonFirtsPanelParameters = By.CssSelector(".mat-menu-item-submenu-trigger");

        private readonly By _settingsSecondPanel = By.XPath("//div[3]/div[3]/div");
        private readonly By _commonSecondPanelParameters = By.CssSelector(".mat-menu-item");

        private readonly By _settingsThirdPanel = By.XPath("//div[3]/div[4]/div");
        private readonly By _commonThirdPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _commonThirdPanelParameters = By.CssSelector(".mat-selected");

        private readonly By _plagin = By.CssSelector(".mat-form-field-infix mat-select-trigger span");
        private readonly By _connection = By.CssSelector(".mat-select-placeholder");

        public PlannerCommonPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PlannerCommonPageObject StartAnalysis()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_startAnalysis).Click();

            return new PlannerCommonPageObject(_webDriver);
        }

        public PlannerCommonPageObject StopAnalysis()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_stopAnalysis).Click();

            return new PlannerCommonPageObject(_webDriver);
        }

        public PlannerCommonPageObject RepeatAnalysis()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_repeatAnalysis).Click();

            return new PlannerCommonPageObject(_webDriver);
        }

        public PlannerCommonPageObject AddAnalysis(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisSeries);
            var addAnalysis = _webDriver.FindElement(_addAnalysis);
            addAnalysis.Click();

            WaitUntil.WaitElement(_webDriver, _panelAddAnalysis);
            //WaitUntil.WaitSomeInterval(1);
            var panelMatAnalysis = _webDriver.FindElements(_panelMatAnalysis).First(x => x.Text == nameParameters);
            panelMatAnalysis.Click();

            return this;
        }

        public PlannerCommonPageObject DeleteAnalysis()
        {
            WaitUntil.WaitElement(_webDriver, _channelStatus);
            _webDriver.FindElement(_deleteAnalysis).Click();

            return new PlannerCommonPageObject(_webDriver);
        }

        public PlannerCommonPageObject SheschedulerSettings(string settingsFirstParameters, string settingsSecondParameters, string settingsTrirdParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisSeries);
            _webDriver.FindElement(_sheschedulerSettings).Click();

            WaitUntil.WaitElement(_webDriver, _settingsFirstPanel);
            _webDriver.FindElements(_commonFirtsPanelParameters).First(x => x.Text == settingsFirstParameters).Click();

            WaitUntil.WaitElement(_webDriver, _settingsSecondPanel);
            _webDriver.FindElements(_commonSecondPanelParameters).First(x => x.Text == settingsSecondParameters).Click();

            WaitUntil.WaitElement(_webDriver, _settingsThirdPanel);
            _webDriver.FindElement(_plagin).Click();

            WaitUntil.WaitElement(_webDriver, _commonThirdPanel);
            _webDriver.FindElements(_commonThirdPanelParameters).First(x => x.Text == settingsTrirdParameters).Click();

            _webDriver.FindElement(_obscure).Click();

            return this;
        }
    }
}
