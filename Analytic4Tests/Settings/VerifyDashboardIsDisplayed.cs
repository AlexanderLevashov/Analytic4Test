using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Settings
{
    public class VerifyDashboardIsDisplayed
    {
        private IWebDriver _webDriver;

        public VerifyDashboardIsDisplayed(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void verifyDashboardIsDisplayed()
        {
            Assert.AreEqual("http://192.168.0.243/n4/dashboard", _webDriver.Url);
            Assert.IsTrue(_webDriver.FindElement(By.CssSelector(".wrapper")).Displayed);
        }

    }
}
