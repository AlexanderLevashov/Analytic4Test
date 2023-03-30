using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class DeleteLastAddDevicesTest : BaseTest
    {
        [Test]
        public void DeleteLastAddDevices()
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

            #region Полная настройка панели, добавление и удаление нового устройства
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
                .Address(Adress_127_0_0_1.Octet0, Adress_127_0_0_1.Octet1, Adress_127_0_0_1.Octet2, Adress_127_0_0_1.Octet3)
                .Port(Port.Port2010)

                //Новое устройство
                .AddNewDeviceManually()
                .ModuleLast(NameDevices.PM3)
                .ChannelLast(NameChannels.Start_1)
                .ConnectionLast(NameConnection.TCP)
                .AddressLast(Adress_127_0_0_1.Octet0, Adress_127_0_0_1.Octet1, Adress_127_0_0_1.Octet2, Adress_127_0_0_1.Octet3)
                .PortLast(Port.Port2010)

                .DeleteLastDevice()
                .Alert(Alert.Ok)
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
