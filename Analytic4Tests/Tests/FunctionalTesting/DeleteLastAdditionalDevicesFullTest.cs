using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class DeleteLastAdditionalDevicesFullTest : BaseTest
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
                .AddDevice().ChoosingLastElement().InputConnection()
                .KeepHistory().NumberChannelStart(NumberChannel.ChannelStart1)
                .AuthostartPlan().AddNewDeviceManually().Module(NameDevices.PM3)
                .Channel(NameChannels.Start_1).Connection(NameConnection.TCP)
                .Address(Adress_127_0_0_1.Octet0, Adress_127_0_0_1.Octet1, Adress_127_0_0_1.Octet2, Adress_127_0_0_1.Octet3)
                .Port(Port.Port2010);
        }

        [Test, Order(4)]
        [Description("04. Ввод данных для доп. соединения")]
        public void EnteringDataForNavigatorAdditionalDeviceManually()
        {
            var controlPanel = new ControlPanelPageObject(_webDriver);
            controlPanel
                .AddNewDeviceManually().ModuleLast(NameDevices.PM3).ChannelLast(NameChannels.Start_1).ConnectionLast(NameConnection.TCP)
                .AddressLast(Adress_127_0_0_1.Octet0, Adress_127_0_0_1.Octet1, Adress_127_0_0_1.Octet2, Adress_127_0_0_1.Octet3)
                .PortLast(Port.Port2010).DeleteLastDevice().Alert(Alert.Ok).DeleteAdditionDevice()
                .Alert(Alert.Ok);
        }

        [Test, Order(5)]
        [Description("05. Удаление соединения")]
        public void DeleteAdditionDevice()
        {
            var controlPanel = new ControlPanelPageObject(_webDriver);
            controlPanel
                .DeleteDevice()
                .Alert(Alert.Ok);
        }
    }
}
