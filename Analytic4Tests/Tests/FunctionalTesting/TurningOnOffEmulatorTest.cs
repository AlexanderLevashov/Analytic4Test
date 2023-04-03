using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class TurningOnOffEmulatorTest : BaseTest
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
        [Description("02. Включение эмулятора")]
        public void TurningOnEmulator()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .Obscure()
                .SelectionDevices(DevicesForNavigatorTests.EmulatorGCH)
                .SelectEmulator(EmulatorsForNavigatorTests.NaturalGas)
                // Остановка драйвера до тех пор, пока не прогрузится уведомление (На усмотрение)
                .ElementsWarning();
        }

        [Test, Order(3)]
        [Description("03. Выключение эмулятора")]
        public void TurningOffEmulator()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .SelectionDevices(DevicesForNavigatorTests.EmulatorGCHIsActive)
                .SelectEmulator(EmulatorsForNavigatorTests.NaturalGas);
            //Assert.IsTrue(mainNavigator.AreThereElementsPage());
        }

    }
}
