using Allure.Commons;
using Analytic4Tests.JsonHandler;
using Analytic4Tests.PageObjects;
using Analytic4Tests.PageObjects.CommonPageObject;
using Analytic4Tests.PageObjects.CommonPageObject.ConfigurationPlannerPageObject;
using Analytic4Tests.PageObjects.CommonPageObject.PlannerPageObject;
using Analytic4Tests.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Analytic4Tests.BaseObjects
{
    [Binding]
    public class BaseTest
    {
        protected IWebDriver _webDriver;
        protected AuthorisationPageObject _auth;
        protected MainNavigatorPageObject _mainNavigator;
        protected ControlPanelPageObject _controlPanel;
        protected PlannerCommonPageObject _plannerCommon;
        protected AnalysisPageObject _analysis;
        protected CommonParametersPageObject _commonParameters;
        protected EnvironmentConstants _environmentConstants;
        public static AllureLifecycle allure = AllureLifecycle.Instance;

        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            //FirefoxOptions fireFoxOptions = new FirefoxOptions();
            //fireFoxOptions.AddArgument("start-fullscreen");
            _webDriver = new FirefoxDriver(); //fireFoxOptions
            //_mainNavigator = new MainNavigatorPageObject(_webDriver);

            // Если создаются большие методы, закомментировать 2 строки ниже
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestSettings.LocalHost);
            InitialiseData();
            allure.CleanupResultDirectory();
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
            //Если создается один большой метод, то раскомментировать 
            _webDriver.Manage().Cookies.DeleteAllCookies();
            //_webDriver.Navigate().GoToUrl(TestSettings.LocalHost);
            _webDriver.Manage().Window.Maximize();
            //WaitUntil.ShouldLocate(_webDriver, TestSettings.LocalHost); // LocalHost || LocationHost
        }

        [TearDown]
        protected void DoAfterEach()
        {
            //_webDriver.Quit();
        }
    }
}
