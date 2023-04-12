using OpenQA.Selenium;
using System.Linq;

namespace Analytic4Tests.PageObjects.CommonPageObject
{
    public class StatePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _obscure = By.CssSelector(".channel-status");

        private readonly By _alertContainer = By.CssSelector(".mat-dialog-container");
        private readonly By _closeAlert = By.XPath("//ac-dialog-header/button");

        private readonly By _btnStopWorking = By.Id("stop-working");
        private readonly By _btnIgnition = By.Id("ignition");
        private readonly By _btnAnalysisStart0 = By.Id("analysis-start0");
        private readonly By _btnCurrentAnalysisTime = By.Id("current-analysis-time");

        private readonly By _state = By.XPath("//div[@class='mat-tab-link-container']/div/div/a[1]");
        private readonly By _obscureState = By.CssSelector(".state");
        private readonly By _diagnostics = By.XPath("//div[@class='mat-tab-link-container']/div/div/a[2]");
        private readonly By _obscureDiagnostics = By.CssSelector(".diagnostics");
        private readonly By _journal = By.XPath("//div[@class='mat-tab-link-container']/div/div/a[3]");
        private readonly By _obscureJournal = By.CssSelector(".journal");
        private readonly By _signal = By.XPath("//div[@class='mat-tab-link-container']/div/div/a[4]");
        private readonly By _obscureSignal = By.CssSelector(".signal");
        private readonly By _service = By.XPath("//div[@class='mat-tab-link-container']/div/div/a[5]");
        private readonly By _obscureService = By.CssSelector(".service");

        private readonly By _chooseMethod = By.XPath("//mat-form-field/div/div[1]/div/mat-select");
        private readonly By _methodPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _methodParameters = By.CssSelector(".mat-option div");

        public StatePageObject (IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public StatePageObject Close()
        {
            WaitUntil.WaitElement(_webDriver, _alertContainer);
            _webDriver.FindElement(_closeAlert).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject StopWorking()
        {
            WaitUntil.WaitElement(_webDriver, _obscure);
            _webDriver.FindElement(_btnStopWorking).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject Ignition()
        {
            WaitUntil.WaitElement(_webDriver, _obscure);
            _webDriver.FindElement(_btnIgnition).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject AnalysisStart()
        {
            WaitUntil.WaitElement(_webDriver, _obscure);
            _webDriver.FindElement(_btnAnalysisStart0).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject CurrentAnalysisTime()
        {
            WaitUntil.WaitElement(_webDriver, _obscure);
            _webDriver.FindElement(_btnCurrentAnalysisTime).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject State()
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.WaitElement(_webDriver, _obscureState);
            _webDriver.FindElement(_state).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject Diagnostics()
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.WaitElement(_webDriver, _obscureDiagnostics);
            _webDriver.FindElement(_diagnostics).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject Journal()
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.WaitElement(_webDriver, _obscureJournal);
            _webDriver.FindElement(_journal).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject Signal()
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.WaitElement(_webDriver, _obscureSignal);
            _webDriver.FindElement(_signal).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject Service()
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.WaitElement(_webDriver, _obscureService);
            _webDriver.FindElement(_service).Click();

            return new StatePageObject(_webDriver);
        }

        public StatePageObject ChoosingMethod(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _obscure);
            _webDriver.FindElement(_chooseMethod).Click();

            WaitUntil.WaitElement(_webDriver, _methodPanel);
            _webDriver.FindElements(_methodParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

    }
}
