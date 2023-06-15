using Allure.Commons;
using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.Settings;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    [AllureNUnit]
    public class DeleteLastAdditionalDevicesFullTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Авторизация и ввод данных для неё")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature1")]
        [AllureStory("Story1")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue1")]
        [AllureTms("Tms1")]
        public void LogIn()
        {
            var authorisation = new AuthorisationPageObject(_webDriver);
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
        }

        [Test, Order(2)]
        [Description("02. Создание соединения")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature2")]
        [AllureStory("Story2")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue2")]
        [AllureTms("Tms2")]
        public void CreateConnection()
        {
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            mainNavigator
                .Obscure()
                .SelectionDevices(DevicesForNavigatorTests.SetUpConnection);
        }

        [Test, Order(3)]
        [Description("03. Ввод данных для соединения")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature3")]
        [AllureStory("Story3")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue3")]
        [AllureTms("Tms3")]
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
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature4")]
        [AllureStory("Story4")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue4")]
        [AllureTms("Tms4")]
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
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature5")]
        [AllureStory("Story5")]
        [AllureOwner("Owner5")]
        [AllureIssue("Issue5")]
        [AllureTms("Tms5")]
        public void DeleteAdditionDevice()
        {
            var controlPanel = new ControlPanelPageObject(_webDriver);
            controlPanel
                .DeleteDevice()
                .Alert(Alert.Ok);
        }
    }
}
