using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests
{
    [TestFixture]
    public class SetUpConnectionsFullTest : BaseTest
    {

        [Test]
        public void SetUpConnectionFull()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var controlPanel = new ControlPanelPageObject(_webDriver);

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

            #region Полная настройка панели с подключением
            controlPanel
                .AddDevice()
                .ChoosingLastElement()
                .InputConnection()
                .KeepHistory()
                .NumberChannelStart(NumberChannel.ChannelStart1)
                .AuthostartPlan()
                .AddNewDeviceManually()
                .Module(NameDevices.PM3)
                .Channel(NameChannels.Start_1)
                .Connection(NameConnection.TCP)
                .Address(Adress_192_168_77_89.Octet0, Adress_192_168_77_89.Octet1, Adress_192_168_77_89.Octet2, Adress_192_168_77_89.Octet3)
                .Port(Port.Port2010)
                .SaveConnection();
            #endregion

            #region Перезагрузка страницы
            switchPages
               .RefreshPage();
            #endregion

            #region Удаление соединения, чтобы не захламляло
            controlPanel
                .DeleteDevice()
                .Alert(Alert.Ok);
            #endregion

        }

    }
}
