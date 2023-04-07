using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class FilterConnectionsTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Авторизация и ввод данных для неё")]
        public void Authorisation()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
        }

        [Test, Order(2)]
        [Description("02. Фильтр соединений")]
        public void Filter()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .Obscure().ShowAllConnections().FilterConnections();
        }

        [Test, Order(3)]
        [Description("03. Все соединения")]
        public void Search()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            switchPages
                .RefreshPage();
            mainNavigator
                .ConnectionWidgestWrapper(ConnectionWidgestWrapper.TestConnection);
        }
    }
}
