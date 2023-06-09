﻿using OpenQA.Selenium;
using System.Linq;

namespace Analytic4Tests.PageObjects
{
    public class MainNavigatorPageObject
    {
        private IWebDriver _webDriver;
        
        #region Переменные среды

        #region Смена пользователя/выход
        private readonly By _formLoginResponse = By.XPath("//div[@class='wrapper']/div[1]");
        private readonly By _buttonFormLogOut = By.XPath("//div[@class='ng-star-inserted']/a4-button/button");
        private readonly By _panelFormLogOut = By.CssSelector(".mat-menu-content");
        private readonly By _parametersForPanelLogOut = By.CssSelector(".mat-focus-indicator");
        private readonly By _buttonChangeLanguage = By.CssSelector("button[class*='mat-focus-indicator mat-menu-trigger']");
        private readonly By _buttonChangeLocalisation = By.XPath("//button[2]/a4-button/button");
        private readonly By _panelForChangeLanguage = By.CssSelector(".mat-menu-panel");
        private readonly By _panelForChangeLocalisation = By.CssSelector(".mat-menu-panel");
        private readonly By _parametersForPanelChangeLanguage = By.CssSelector(".mat-focus-indicator");
        private readonly By _parametersForPanelChangeLocalisation = By.CssSelector(".mat-focus-indicator");
        #endregion

        #region Настройка приборов
        private readonly By _panelAllDevices = By.CssSelector(".connections-wrapper-buttons");
        private readonly By _paremetersSortDevices = By.CssSelector(".connections-wrapper-buttons .mat-tooltip-trigger");
        #endregion

        #region Выбор эмулятора
        private readonly By _panelAllEmulators = By.CssSelector(".mat-menu-content");
        private readonly By _parametersVarietyEmulators = By.CssSelector(".mat-menu-content .mat-focus-indicator");
        #endregion

        #region
        private readonly By _connectionsWrapper = By.CssSelector(".connections-wrapper");
        private readonly By _filterConnections = By.CssSelector(".filter a4-text-box input");
        #endregion

        #region
        private readonly By _showAllConnections = By.CssSelector(".ng-star-inserted .check-box-container");
        #endregion

        #region
        private readonly By _connectionWidgetsWrapper = By.CssSelector(".connection-widget");
        private readonly By _widgetInfo = By.CssSelector(".widget-info");
        private readonly By _widgetInfoText = By.XPath("//h3");
        #endregion

        #region Оповещение состояния
        private readonly By _stateEmulator = By.CssSelector(".mat-typography app-root a4-popup-message div");
        #endregion

        #region
        private readonly By _deviceConnections = By.CssSelector(".device-connections");
        #endregion

        #region
        private readonly By _dialogContainer = By.CssSelector(".cdk-dialog-container .ng-star-inserted .details-wrapper");
        private readonly By _exitObscure = By.CssSelector(".cdk-dialog-container .ng-star-inserted .container div");
        #endregion

        #endregion

        public MainNavigatorPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        #region То, что должны получить
        public static string GetResponseAuthTest
        {
            get
            {
                string getResponse = "ГОСТЬ"; // ADMIN
                return getResponse;
            }
            set { }
        }
        #endregion

        #region  Вход пользователя
        public MainNavigatorPageObject LogOut(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _buttonFormLogOut);
            _webDriver.FindElement(_buttonFormLogOut).Click();

            WaitUntil.WaitElement(_webDriver, _panelFormLogOut);
            _webDriver.FindElements(_parametersForPanelLogOut).First(x => x.Text == nameParameters).Click();
            return this;
        }
        #endregion

        #region Выбор языка
        public MainNavigatorPageObject ChangeLanguage(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _panelFormLogOut);
            _webDriver.FindElement(_buttonChangeLanguage).Click();

            WaitUntil.WaitElement(_webDriver, _panelForChangeLanguage);
            _webDriver.FindElements(_parametersForPanelChangeLanguage).First(x => x.Text == nameParameters).Click();

            return this;
        }
        #endregion

        #region Выбор локализации
        public MainNavigatorPageObject ChangeLocalisation(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _panelFormLogOut);
            _webDriver.FindElement(_buttonChangeLocalisation).Click();

            WaitUntil.WaitElement(_webDriver, _panelForChangeLocalisation);
            _webDriver.FindElements(_parametersForPanelChangeLocalisation).First(x => x.Text == nameParameters).Click();

            return this;
        }

        #endregion

        #region Настройка приборов
        public MainNavigatorPageObject SelectionDevices(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _panelAllDevices);
            _webDriver.FindElements(_paremetersSortDevices).First(x => x.Text == nameParameters).Click();

            return this;
        }
        #endregion

        #region Выбор эмулятора
        public MainNavigatorPageObject SelectEmulator(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _panelAllEmulators);
            _webDriver.FindElements(_parametersVarietyEmulators).First(x => x.Text == nameParameters).Click();

            return this;
        }
        #endregion

        #region Всплывающие окна
        public MainNavigatorPageObject ElementsWarning()
        {
            WaitUntil.WaitWarningElements(_webDriver, _stateEmulator);
            return this;
        }

        public MainNavigatorPageObject Obscure()
        {
            WaitUntil.WaitHideElement(_webDriver, _dialogContainer);
            _webDriver.FindElement(_exitObscure).Click();

            return new MainNavigatorPageObject(_webDriver);
        }
        #endregion

        #region Способы поиска элементов на странице

        public bool SearchObscureElemetn()
        {
            try
            {
                _webDriver.FindElement(_deviceConnections);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        // Пока не надо
        //public bool AreThereElementsPage()
        //{
        //    try
        //    {
        //        _webDriver.FindElement(_btnVkGroup);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //    finally
        //    {

        //    }
        //}

        // Пока не надо
        //public bool AreThereElementsNextPage()
        //{
        //    try
        //    {
        //        _webDriver.PageSource.Contains(_vkGroup);
        //        return true;
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return false;
        //    }
        //}

        // Пока не надо
        //public bool AreThereElementsPage3 =>
        //    _webDriver.PageSource.Contains(_vkGroup);

        // Пока не надо
        //public MainNavigatorPageObject AreThereElementsPage3()
        //{
        //    _webDriver.FindElement(_btnVkGroup).Click();

        //    return this;
        //}

        // Пока не надо
        //public List<string> AllBtns =>
        //    _webDriver.FindElements(_btnSortDevices).Select(x => x.Text).ToList();

        #endregion

        public MainNavigatorPageObject FilterConnections()
        {
            WaitUntil.WaitElement(_webDriver, _connectionsWrapper);
            var filterConnections = _webDriver.FindElement(_filterConnections);

            string [] list_filter = new string[] { "test", "test connection", "something" };

            for (int i = 0; i < list_filter.Length; i++)
            {
                filterConnections.Click();             
                filterConnections.SendKeys(list_filter[i]);
                filterConnections.SendKeys(Keys.Enter);
                filterConnections.Clear();
                WaitUntil.WaitSomeInterval(2);
            }
            return new MainNavigatorPageObject(_webDriver);
        }

        public MainNavigatorPageObject ShowAllConnections()
        {
            WaitUntil.WaitElement(_webDriver, _connectionsWrapper);
            _webDriver.FindElement(_showAllConnections).Click();

            return new MainNavigatorPageObject(_webDriver);
        }

        public MainNavigatorPageObject ConnectionWidgestWrapper(string nameParameters)
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.WaitElement(_webDriver, _connectionsWrapper);
            _webDriver.FindElement(_connectionWidgetsWrapper);

            WaitUntil.WaitElement(_webDriver, _widgetInfo);
            _webDriver.FindElements(_widgetInfoText).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public string GetResponseUser()
        {
            WaitUntil.WaitElement(_webDriver, _formLoginResponse);
            WaitUntil.WaitSomeInterval(1);
            string user = _webDriver.FindElement(_formLoginResponse).Text;
            return user;
        }
    }
}
