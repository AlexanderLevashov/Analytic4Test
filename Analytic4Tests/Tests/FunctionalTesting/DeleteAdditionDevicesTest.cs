using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class DeleteAdditionDevicesTest : BaseTest
    {
        [Test]
        public void DeleteAdditionDevice()
        {
            #region Переменные среды
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var controlPanel = new ControlPanelPageObject(_webDriver);
            #endregion

            #region Авторизация
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
            #endregion

            #region Создать соединение
            mainNavigator
                .SelectionDevices(DevicesForNavigatorTests.SetUpConnection);
            #endregion

            #region Переключение на нужную страницу
            switchPages
                .SwitchPage();
            #endregion

            #region Добавление и удаление нового устройства
            controlPanel
                .AddDevice()
                .AddNewDeviceManually()
                .DeleteAdditionDevice()
                .Alert(Alert.Ok);
            #endregion

            #region Удаление соединения, чтобы не захламляло
            controlPanel
                .DeleteDevice()
                .Alert(Alert.Ok);
            #endregion

        }
    }
}
