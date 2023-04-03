using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class AuthorisationTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Выполнить вход пользователя")]
        public void LogIn()
        { 
            var authorisation = new AuthorisationPageObject(_webDriver);       
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);

        }

        [Test, Order(2)]
        [Description("02. Выполнить выход")]
        public void LogOut()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .Obscure()
                .LogOut(LogOutForNavigatorTests.Exit);
        }

        [Test, Order(3)]
        [Description("03. Выполнить вход от гостя")]
        public void LoginLikeGuest()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            authorisation
                .GuestEntrance();

            string actualResponse = mainNavigator.GetResponseUser();
            Assert.AreEqual(MainNavigatorPageObject.GetResponseAuthTest, actualResponse, "Login or password are wrong, or unknown person");
        }
    }
}