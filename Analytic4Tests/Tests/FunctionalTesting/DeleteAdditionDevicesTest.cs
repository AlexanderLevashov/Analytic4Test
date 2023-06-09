﻿using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class DeleteAdditionDevicesTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Авторизация и ввод данных для неё")]
        public void LogIn()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
        }

        [Test, Order(2)]
        [Description("02. Создание соединения")]
        public void CreateConnection()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .Obscure()
                .SelectionDevices(DevicesForNavigatorTests.SetUpConnection);
        }

        [Test, Order(3)]
        [Description("03. Ввод данных для соединения")]
        public void EnteringDataForNavigator()
        {
            var switchPages = new SwitchPageSettings(_webDriver);
            var controlPanel = new ControlPanelPageObject(_webDriver);
            switchPages
               .SwitchPage();

            controlPanel
                .AddDevice()
                .AddNewDeviceManually()
                .DeleteAdditionDevice()
                .Alert(Alert.Ok);
        }

        [Test, Order(4)]
        [Description("04. Удаление соединения")]
        public void DeleteAdditionDevice()
        {
            var controlPanel = new ControlPanelPageObject(_webDriver);
            controlPanel
                .DeleteDevice()
                .Alert(Alert.Ok);
        }
    }
}
