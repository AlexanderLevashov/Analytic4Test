﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.PageObjects.PageObjectPlanner
{
    public class SignalStatePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _thermostatesColumn_1 = By.XPath("//app-signal/div/div/app-table/table/tbody/tr[2]/td[1]");
        private readonly By _obscureSignal = By.CssSelector(".signal");

        private readonly By _thermostatesColumnTemperature = By.XPath("//app-signal/div/div/app-table/table/tbody/tr[3]/td[1]");

        public SignalStatePageObject (IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public SignalStatePageObject ThermostatesColumn_1()
        {
            WaitUntil.WaitElement(_webDriver, _obscureSignal);
            _webDriver.FindElement(_thermostatesColumn_1).Click();

            return new SignalStatePageObject(_webDriver);
        }

        public SignalStatePageObject ThermostatesColumnTemperature()
        {
            WaitUntil.WaitElement(_webDriver, _obscureSignal);
            _webDriver.FindElement(_thermostatesColumnTemperature).Click();
            WaitUntil.WaitSomeInterval(3);

            return new SignalStatePageObject(_webDriver);
        }
    }
}