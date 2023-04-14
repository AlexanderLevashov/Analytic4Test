using Allure.Commons;
using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Analytic4Tests
{
    [TestFixture]
    [Binding]
    public class AuthorisationUserSteps : BaseTest
    {
        public static new AllureLifecycle allure = AllureLifecycle.Instance;
        [Test, Order(1)]
        [Description("01. Выполнить вход пользователя")]
        [Given(@"The authorisation page is given")]
        public void GivenTheAuthorisationPageIsGiven()
        {
           //
        }

        [Test, Order(2)]
        [Description("02. Выполнить выход")]
        [When(@"Enter the data for user authorisation, logIn and logOut of account")]
        public void WhenEnterTheDataForUserAuthorisationLogInAndLogOutOfAccount()
        {
            //
        }

        [Test, Order(3)]
        [Description("03. Выполнить вход от гостя")]
        [Then(@"LogIn from as guest")]
        public void ThenLogInFromAsGuest()
        {
            //
        }
    }
}
