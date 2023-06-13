using OpenQA.Selenium;
using System.Linq;

namespace Analytic4Tests.PageObjects
{
    public class AuthorisationPageObject
    {
        private IWebDriver _webDriver;

        #region Переменные среды
        private readonly By _inputLogin = By.Id("login");
        private readonly By _inputPassword = By.Id("password");
        private readonly By _signButton = By.CssSelector(".user-login form button");
        private readonly By _singAsGuest = By.CssSelector(".guest-button");
        private readonly By _btnChangeLanguage = By.CssSelector(".user-login div div button");
        private readonly By _panelChangeLanguage = By.CssSelector(".mat-menu-content");
        private readonly By _parametersChangeLanguage = By.CssSelector(".mat-focus-indicator");
        private readonly By _dashboardWrapper = By.CssSelector(".dashboard-wrapper");

        #region Алерты
        private readonly By _stateLoginPass = By.XPath("/html/body/app-root/a4-popup-message/div");
        #endregion

        #endregion

        public AuthorisationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AuthorisationPageObject ChangeLanguage(string nameParameters)
        {
            _webDriver.FindElement(_btnChangeLanguage).Click();
            WaitUntil.WaitElement(_webDriver, _panelChangeLanguage);
            _webDriver.FindElements(_parametersChangeLanguage).First(x => x.Text == nameParameters).Click();

            return new AuthorisationPageObject(_webDriver);
        }

        public AuthorisationPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_inputLogin).SendKeys(login);
            _webDriver.FindElement(_inputPassword).SendKeys(password);
            _webDriver.FindElement(_signButton).Click();

            return new AuthorisationPageObject(_webDriver);
        }

        public AuthorisationPageObject LoginBruteForce(string login, string password)
        {
            _webDriver.FindElement(_inputLogin).SendKeys(login);
            _webDriver.FindElement(_inputPassword).SendKeys(password);
            _webDriver.FindElement(_signButton).Click();

            return new AuthorisationPageObject(_webDriver);
        }

        public AuthorisationPageObject ElementsWarningLoginPass()
        {
            WaitUntil.WaitWarningElements(_webDriver, _stateLoginPass);
            return this;
        }

        public AuthorisationPageObject DoNotSearchWarningElementLoginPass()
        {
            _webDriver.FindElement(_stateLoginPass);
            return this;
        }

        public bool SearchWarningElementLoginPass()
        {
            try
            {
                _webDriver.FindElement(_stateLoginPass);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public AuthorisationPageObject GuestEntrance()
        {
            _webDriver.FindElement(_singAsGuest).Click();

            return new AuthorisationPageObject(_webDriver);
        }

        public bool IsLoggedIn()
        {
            try
            {
                WaitUntil.WaitElement(_webDriver, _dashboardWrapper);
                var loggedInElement = _webDriver.FindElement(By.CssSelector(".dashboard-wrapper"));
                return loggedInElement != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
