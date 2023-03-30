using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests
{
    [TestFixture]
    public class NavigatorDevicesTest : BaseTest
    {

        [Test]
        public void NavigatorDevice()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            #region Вход
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
            #endregion

            #region Включение
            mainNavigator
                .SelectionDevices(DevicesForNavigatorTests.EmulatorGCH)
                .SelectEmulator(EmulatorsForNavigatorTests.NaturalGas)
                // Остановка драйвера до тех пор, пока не прогрузится уведомление (На усмотрение)
                .ElementsWarning();
            #endregion

            #region Выключение эмулятора
            mainNavigator
                .SelectionDevices(DevicesForNavigatorTests.EmulatorGCHIsActive)
                .SelectEmulator(EmulatorsForNavigatorTests.NaturalGas);
            #endregion

            //Assert.IsTrue(mainNavigator.AreThereElementsPage());
        }
    }
}
