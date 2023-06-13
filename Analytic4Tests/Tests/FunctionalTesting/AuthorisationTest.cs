using Allure.Commons;
using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    [AllureNUnit]
    public class AuthorisationTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Выполнить вход пользователя")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Feature1")]
        [AllureStory("Story1")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue1")]
        [AllureTms("Tms1")]
        public void LogIn()
        { 
            var authorisation = new AuthorisationPageObject(_webDriver);
            var dashboardIsDisplayed = new VerifyDashboardIsDisplayed(_webDriver);
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);

            dashboardIsDisplayed
                .verifyDashboardIsDisplayed();

            //var isLoggedIn = authorisation.IsLoggedIn();
            //Assert.IsTrue(isLoggedIn, "Ошибка: Авторизация не выполнена");
            //AllureLifecycle.Instance.WrapInStep(
            //    () => Assert.IsTrue(isLoggedIn, "Авторизация выполнена успешно"),
            //    "Проверка успешной авторизации"
            //);
        }

        [Test, Order(2)]
        [Description("02. Выполнить выход")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature2")]
        [AllureStory("Story2")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue2")]
        [AllureTms("Tms2")]
        public void LogOut()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .Obscure()
                .LogOut(LogOutForNavigatorTests.Exit);
        }

        [Test, Order(3)]
        [Description("03. Выполнить вход от гостя")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Feature3")]
        [AllureStory("Story3")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue3")]
        [AllureTms("Tms3")]
        public void LoginLikeGuest()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            authorisation
                .GuestEntrance();

            string actualResponse = mainNavigator.GetResponseUser();
            Assert.AreEqual(MainNavigatorPageObject.GetResponseAuthTest, actualResponse, "Login or password are wrong, or unknown person");
        }

        //public void VerifyDashboardIsDisplayed()
        //{
        //    Assert.AreEqual("http://192.168.0.243/n4/dashboard", _webDriver.Url);
        //    Assert.IsTrue(_webDriver.FindElement(By.CssSelector(".wrapper")).Displayed);
        //}
    }
}