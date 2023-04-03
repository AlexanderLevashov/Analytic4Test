using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class SetUpAddRemoveAdditionalDevicesFullTest : BaseTest
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
        [Description("03. Полная настройка панели с подключением")]
        public void EnteringDataForNavigator() {
            var controlPanel = new ControlPanelPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            switchPages
                .SwitchPage();

            controlPanel
                .AddDevice().ChoosingLastElement().InputConnection()
                .KeepHistory().NumberChannelStart(NumberChannel.ChannelStart1)
                .AuthostartPlan().AddNewDeviceManually().Module(NameDevices.PM3)
                .Channel(NameChannels.Start_1).Connection(NameConnection.TCP)
                .Address(Adress_192_168_77_89.Octet0, Adress_192_168_77_89.Octet1, Adress_192_168_77_89.Octet2, Adress_192_168_77_89.Octet3)
                .Port(Port.Port2010).SaveConnection();
        }

        [Test, Order(4)]
        [Description("04. Перезагрузка страницы")]
        public void Refresh()
        {
            var switchPages = new SwitchPageSettings(_webDriver);
            switchPages
                .RefreshPage();
        }

        [Test, Order(5)]
        [Description("Удалить соединение")]
        public void DeleteDevices()
        {
            var controlPanel = new ControlPanelPageObject(_webDriver);
            controlPanel
                .DeleteDevice()
                .Alert(Alert.Ok);
        }
    }
}
