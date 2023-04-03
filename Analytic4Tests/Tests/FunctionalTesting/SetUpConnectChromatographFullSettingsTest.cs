using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.PageObjects.PageObjectPlanner;
using Analytic4Tests.Settings;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class SetUpConnectChromatographFullSettingsTest : BaseTest
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
            switchPages
                .SwitchPage();
            var controlPanel = new ControlPanelPageObject(_webDriver);
            controlPanel
                .AddDevice().ChoosingLastElement().InputConnection()
                .KeepHistory().NumberChannelStart(NumberChannel.ChannelStart1)
                .AuthostartPlan().AddNewDeviceManually().Module(NameDevices.PM3)
                .Channel(NameChannels.Start_1).Connection(NameConnection.TCP)
                .Address(Adress_192_168_77_89.Octet0, Adress_192_168_77_89.Octet1, Adress_192_168_77_89.Octet2, Adress_192_168_77_89.Octet3)
                .Port(Port.Port2010).ConnectDevice();
        }

        [Test, Order(4)]
        [Description("04. Добавление n-количества анализов")]
        public void AddNumberAnalysis()
        {
            var switchPages = new SwitchPageSettings(_webDriver);
            switchPages
                .SwitchPage();
            var planner = new PlannerCommonPageObject(_webDriver);
            planner
                .AddAnalysis(SettingsAddAnalysis.Add_1_Analysis);
        }

        [Test, Order(5)]
        [Description("05. Заполнения данных в анализе")]
        public void EnteringDataForPlanner()
        {
            var analysis = new AnalysisPageObject(_webDriver);
            analysis
               .AppSelect(ParametersForAnalysisTests.MatPanel_1).Profile(ParametersForProfile.MatProfile_1)
               .InstrumentPanel(ParametersForCheckBoxInstrument.Channel).CheckBoxFirst()
               .ProjectFirst(ParametersForProject.Project).OpenCancel(ParametersForPanelProject.Ok)
               .MethodFirst(ParametersForMethod.Test).VialFirst().SampleFirst()
               .SamplePannel().SampleName().SamplePurpose(ParametersForPurpose.Analysis)
               .SampleVolume().SampleDilution().SampleColumn().SampleComments()
               .SampleGraduationLevel(ParametersForGraduationLevel.Not)
               .SampleClose().PurposeFirst(ParametersForState.Analysis);
        }

        [Test, Order(6)]
        [Description("06. Переключение на 'Конфигурацию'")]
        public void Switching()
        {
            var matProgressBar = new MatProgressBarPageObject(_webDriver);
            matProgressBar
                .MainConfiguration();
        }

        [Test, Order(7)]
        [Description("07. Заполнение общих параметров 'Конфигурации' для хроматографа")]
        public void EnteringCommonParametersForChromatograph()
        {
            var switchPages = new SwitchPageSettings(_webDriver);
            switchPages
                .SwitchPage();
            var commonParameters = new CommonParametersPageObject(_webDriver);
            commonParameters
                .Chromatograph().AmbientPressure(Chromatograph.Pressure)
                .AmbientTemperature(Chromatograph.Temperature)
                .BlowingMethod(Chromatograph.CommonSubParameters, Chromatograph.CommonParameters_1)
                .DefaultMethod(Chromatograph.CommonSubParameters, Chromatograph.CommonParameters_1)
                .SoundKeyPressing().SoundWhenReady().SoundAfterInitial().SoundAfterAnalysis();
        }

        [Test, Order(8)]
        [Description("08. Заполнение общих параметров 'Конфигурации' для термостата колонок")]
        public void EneteringCommonParametersForOven()
        {
            var commonParameters = new CommonParametersPageObject(_webDriver);
            commonParameters
                .Oven().PrepRun().MaxTemperatureOven(Oven.TemperatureOven)
                .TOvenTDetectors().TOvenTInlets();
        }

        [Test, Order(9)]
        [Description("09. Заполнение общих параметров 'Конфигурации' для ДТП-2 ")]
        public void EneteringCommonParametersForTCD2()
        {
            var commonParameters = new CommonParametersPageObject(_webDriver);
            commonParameters
                .TCD2().TypeDetectorTCD2(TCD2.TCD2TypeDetector_1).ActivityTCD2(TCD2.TCD2Channel_2)
                .AcquisitionRateTCD2(TCD2.TCDAcquisitionRate_2).ThermostatTCD2(TCD2.TCDThermostat_1)
                .PowerTCD2(TCD2.TCDPower_1).ShiftTCD2(TCD2.TCDShift);
        }

        [Test, Order(10)]
        [Description("10. Заполнение общих параметров 'Конфигурации' для ДТП-1 ")]
        public void EneteringCommonParametersForTCD1()
        {
            var commonParameters = new CommonParametersPageObject(_webDriver);
            commonParameters
                .TCD1().TypeDetectorTCD1(TCD2.TCD2TypeDetector_1).ActivityTCD1(TCD2.TCD2Channel_2)
                .AcquisitionRateTCD1(TCD2.TCDAcquisitionRate_2).ThermostatTCD1(TCD2.TCDThermostat_1)
                .PowerTCD1(TCD2.TCDPower_1).ShiftTCD1(TCD2.TCDShift);
        }
    }
}
