using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects.PageObjectPlanner
{
    public class AnalysisModePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _overlay = By.CssSelector(".cdk-overlay-backdrop");

        private readonly By _thermostatesColums = By.XPath("//tr[3]/td[3]/div/app-editable-parameter");
        private readonly By _thermostatesContainer = By.XPath("//app-table/table/tbody/tr[3]");
        private readonly By _programmableContainer = By.CssSelector(".programmable-container");
        private readonly By _plusButton = By.XPath("//app-prog-parameter-base/div/div[1]/button[1]");
        private readonly By _minusButton = By.XPath("//app-prog-parameter-base/div/div[1]/button[2]");
        private readonly By _applyButton = By.XPath("//app-prog-parameter-base/div/div[1]/button[3]");
        private readonly By _prepRun = By.XPath("//a4-check-box/div/a4-img/div/div");

        private readonly By _temperatureColumn1Row0 = By.XPath("//app-table/table/tbody/tr[1]/td[2]/app-control/input");
        private readonly By _timeColumn2Row0 = By.XPath("//app-table/table/tbody/tr[1]/td[3]/app-control/input");

        private readonly By _speedColumn0Row1 = By.XPath("//app-table/table/tbody/tr[2]/td[1]/app-control/input");
        private readonly By _temperatureColumn1Row1 = By.XPath("//app-table/table/tbody/tr[2]/td[2]/app-control/input");
        private readonly By _timeColumn2Row1 = By.XPath("//app-table/table/tbody/tr[2]/td[3]/app-control/input");

        private readonly By _speedColumn0Row2 = By.XPath("//app-table/table/tbody/tr[3]/td[1]/app-control/input");
        private readonly By _temperatureColumn1Row2 = By.XPath("//app-table/table/tbody/tr[3]/td[2]/app-control/input");
        private readonly By _timeColumn2Row2 = By.XPath("//app-table/table/tbody/tr[3]/td[3]/app-control/input");

        private readonly By _speedColumn0Row3 = By.XPath("//app-table/table/tbody/tr[4]/td[1]/app-control/input");
        private readonly By _temperatureColumn1Row3 = By.XPath("//app-table/table/tbody/tr[4]/td[2]/app-control/input");
        private readonly By _timeColumn2Row3 = By.XPath("//app-table/table/tbody/tr[4]/td[3]/app-control/input");

        public AnalysisModePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AnalysisModePageObject ThermostatesColums()
        {
            WaitUntil.WaitElement(_webDriver, _thermostatesContainer);
            _webDriver.FindElement(_thermostatesColums).Click();

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject ThermostatesPlusButton()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            _webDriver.FindElement(_plusButton).Click();

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject ThermostatesMinusButton()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            _webDriver.FindElement(_minusButton).Click();

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject ThermostatesApplyButton()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            _webDriver.FindElement(_applyButton).Click();

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject ThermostatesPrepRunButton()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            _webDriver.FindElement(_prepRun).Click();

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TemperatureColumn1Row0()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_temperatureColumn1Row0);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("40");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TimeColumn2Row0()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_timeColumn2Row0);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("0");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject SpeedColumn0Row1()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_speedColumn0Row1);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("5");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TemperatureColumn1Row1()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_temperatureColumn1Row1);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("100");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TimeColumn2Row1()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_timeColumn2Row1);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("30");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject SpeedColumn0Row2()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_speedColumn0Row2);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("5");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TemperatureColumn1Row2()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_temperatureColumn1Row2);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("100");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TimeColumn2Row2()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_timeColumn2Row2);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("30");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject SpeedColumn0Row3()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_speedColumn0Row3);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("5");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TemperatureColumn1Row3()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_temperatureColumn1Row3);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("100");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject TimeColumn2Row3()
        {
            WaitUntil.WaitElement(_webDriver, _programmableContainer);
            var temperatureColumn1Row0 = _webDriver.FindElement(_timeColumn2Row3);
            temperatureColumn1Row0.Click();
            temperatureColumn1Row0.Clear();
            temperatureColumn1Row0.SendKeys("500");

            return new AnalysisModePageObject(_webDriver);
        }

        public AnalysisModePageObject Overlay()
        {
            _webDriver.FindElement(_overlay).Click();

            return new AnalysisModePageObject(_webDriver);
        }

    }
}
