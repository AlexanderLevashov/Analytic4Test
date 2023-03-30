using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Analytic4Tests
{
    [TestFixture]
    public class AuthorisationTest : BaseTest
    {

        #region Константы для перебора
        //string[] listOfLogins = new string[] { "test0", "test1", "test2", "admin" };
        //string[] listOfPasswords = new string[] { "test0", "test1", "test2", "admin" };
        #endregion
 
        [Test]
        public void LoginIn()
        {
            
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            #region Вход пользователя
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);

            #endregion

            #region Выход пользователя
            mainNavigator
                .LogOut(LogOutForNavigatorTests.Exit);
            #endregion

            #region Вход, как гость
            authorisation
                .GuestEntrance();
            #endregion

            string actualResponse = mainNavigator.GetResponseUser();
            Assert.AreEqual(MainNavigatorPageObject.GetResponseAuthTest, actualResponse, "Login or password are wrong, or unknown person");
        }
    }
}