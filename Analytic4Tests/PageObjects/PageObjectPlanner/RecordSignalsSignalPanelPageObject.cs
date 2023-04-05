using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects.PageObjectPlanner
{
    public class RecordSignalsSignalPanelPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _showOnlySignalsDetectors = By.XPath("//div/div[1]/p4-checkbox/div/a4-check-box/div");
        private readonly By _signalsContainer = By.CssSelector(".signals-container");

        private readonly By _thermostatesColumns_1 = By.XPath("//div/div[2]/app-table/table/tbody/tr[2]/td[1]");
        private readonly By _temperatureThermoColumn_1 = By.XPath("//table/tbody/tr[3]/td[2]/div/p4-checkbox/div/a4-check-box/div/a4-img/div/div");
        private readonly By _setTemperatureThermoColumn_1 = By.XPath("//table/tbody/tr[4]/td[2]/div/p4-checkbox/div/a4-check-box/div");

        private readonly By _TCD2 = By.XPath("//div/div[2]/app-table/table/tbody/tr[5]/td[1]");
        private readonly By _signalTCD2 = By.XPath("//table/tbody/tr[6]/td[2]/div/p4-checkbox/div/a4-check-box/div");
        private readonly By _stateSpiralTCD2 = By.XPath("//table/tbody/tr[7]/td[2]/div/p4-checkbox/div/a4-check-box/div");
        private readonly By _stateBaseLineTCD2 = By.XPath("//table/tbody/tr[8]/td[2]/div/p4-checkbox/div/a4-check-box/div");

        private readonly By _TCD1 = By.XPath("//div/div[2]/app-table/table/tbody/tr[9]/td[1]");
        private readonly By _signalTCD1 = By.XPath("//table/tbody/tr[10]/td[2]/div/p4-checkbox/div/a4-check-box/div");
        private readonly By _stateSpiralTCD1 = By.XPath("//table/tbody/tr[11]/td[2]/div/p4-checkbox/div/a4-check-box/div");
        private readonly By _stateBaseLineTCD1 = By.XPath("//table/tbody/tr[12]/td[2]/div/p4-checkbox/div/a4-check-box/div");

        private readonly By _сolumnThermostatDampers_1 = By.XPath("//div/div[2]/app-table/table/tbody/tr[13]/td[1]");
        private readonly By _currentPosition = By.XPath("//table/tbody/tr[14]/td[2]/div/p4-checkbox/div/a4-check-box/div");

        public RecordSignalsSignalPanelPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public RecordSignalsSignalPanelPageObject ShowOnlySignalsDetectors()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_showOnlySignalsDetectors).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject ThermostatesColumns_1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            //WaitUntil.WaitSomeInterval(2);
            _webDriver.FindElement(_thermostatesColumns_1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject TemperatureThermoColumn_1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_temperatureThermoColumn_1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject SetTemperatureThermoColumn_1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_setTemperatureThermoColumn_1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject TCD2()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            WaitUntil.WaitSomeInterval(2);
            _webDriver.FindElement(_TCD2).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject SignalTCD2()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_signalTCD2).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject StateSpiralTCD2()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_stateSpiralTCD2).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject StateBaseLineTCD2()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_stateBaseLineTCD2).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject TCD1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            WaitUntil.WaitSomeInterval(2);
            _webDriver.FindElement(_TCD1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject SignalTCD1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_signalTCD1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject StateSpiralTCD1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_stateSpiralTCD1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject StateBaseLineTCD1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_stateBaseLineTCD1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject ColumnThermostatDampers_1()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            WaitUntil.WaitSomeInterval(2);
            _webDriver.FindElement(_сolumnThermostatDampers_1).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }

        public RecordSignalsSignalPanelPageObject CurrentPosition()
        {
            WaitUntil.WaitElement(_webDriver, _signalsContainer);
            _webDriver.FindElement(_currentPosition).Click();

            return new RecordSignalsSignalPanelPageObject(_webDriver);
        }


    }
}
