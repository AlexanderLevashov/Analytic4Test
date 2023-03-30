using Analytic4Tests.JsonHandler;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.BaseObjects
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;
        protected AuthorisationPageObject _auth;
        protected MainNavigatorPageObject _mainNavigator;
        protected ControlPanelPageObject _controlPanel;
        protected EnvironmentConstants _environmentConstants;

        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            //FirefoxOptions fireFoxOptions = new FirefoxOptions();
            //fireFoxOptions.AddArgument("start-fullscreen");
            _webDriver = new FirefoxDriver(); //fireFoxOptions
            //_mainNavigator = new MainNavigatorPageObject(_webDriver);

            InitialiseData();
        }

        private void InitialiseData()
        {
            new EnvironmentConstantsProvider().Provide(out EnvironmentConstants environmentConstantsObject);
            _environmentConstants = environmentConstantsObject;
        }

        [OneTimeTearDown]
        protected void DoAfterAllTests()
        {

        }

        [SetUp]
        protected void DoBeforeEach()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestSettings.LocalHost);
            _webDriver.Manage().Window.Maximize();
            WaitUntil.ShouldLocate(_webDriver, TestSettings.LocationHost);
        }

        [TearDown]
        protected void DoAfterEach()
        {
            //_webDriver.Quit();
        }
    }
}
