using Allure.Commons;
using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.PageObjects.CommonPageObject;
using Analytic4Tests.PageObjects.CommonPageObject.ConfigurationPlannerPageObject;
using Analytic4Tests.PageObjects.CommonPageObject.ModePlannerPageObject;
using Analytic4Tests.PageObjects.CommonPageObject.PlannerPageObject;
using Analytic4Tests.PageObjects.CommonPageObject.StatePlannerPageObject;
using Analytic4Tests.Settings;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    [AllureNUnit]
    public class SetUpConnectChromatographFullSettingsTest : BaseTest
    {
        [Test, Order(1)]
        [Description("01. Авторизация и ввод данных для неё")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureFeature("Feature1")]
        [AllureStory("Story1")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue1")]
        [AllureTms("Tms1")]
        public void Authorisation()
        {        
            var authorisation = new AuthorisationPageObject(_webDriver);
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
        }

        [Test, Order(2)]
        [Description("02. Создание соединения")]
        [AllureSeverity(SeverityLevel.minor)]
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
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature3")]
        [AllureStory("Story3")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue3")]
        [AllureTms("Tms3")]
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
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature4")]
        [AllureStory("Story4")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue4")]
        [AllureTms("Tms4")]
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
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature5")]
        [AllureStory("Story5")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue5")]
        [AllureTms("Tms5")]
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
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature6")]
        [AllureStory("Story6")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue6")]
        [AllureTms("Tms6")]
        public void SwitchingConfiguration()
        {
            var matProgressBar = new MatProgressBarPageObject(_webDriver);
            matProgressBar
                .MainConfiguration();
        }

        [Test, Order(7)]
        [Description("07. Заполнение общих параметров 'Конфигурации' для хроматографа")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature7")]
        [AllureStory("Story7")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue7")]
        [AllureTms("Tms7")]
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
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature8")]
        [AllureStory("Story8")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue8")]
        [AllureTms("Tms8")]
        public void EneteringCommonParametersForOven()
        {
            var commonParameters = new CommonParametersPageObject(_webDriver);
            commonParameters
                .Oven().PrepRun().MaxTemperatureOven(Oven.TemperatureOven)
                .TOvenTDetectors().TOvenTInlets();
        }

        [Test, Order(9)]
        [Description("09. Заполнение общих параметров 'Конфигурации' для ДТП-2 ")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature9")]
        [AllureStory("Story9")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue9")]
        [AllureTms("Tms9")]
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
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature10")]
        [AllureStory("Story10")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue10")]
        [AllureTms("Tms10")]
        public void EneteringCommonParametersForTCD1()
        {
            var commonParameters = new CommonParametersPageObject(_webDriver);
            commonParameters
                .TCD1().TypeDetectorTCD1(TCD2.TCD2TypeDetector_1).ActivityTCD1(TCD2.TCD2Channel_2)
                .AcquisitionRateTCD1(TCD2.TCDAcquisitionRate_2).ThermostatTCD1(TCD2.TCDThermostat_1)
                .PowerTCD1(TCD2.TCDPower_1).ShiftTCD1(TCD2.TCDShift);
        }

        [Test, Order(11)]
        [Description("Переключение на вкладку 'Охлаждение и поджиг'")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature11")]
        [AllureStory("Story11")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue11")]
        [AllureTms("Tms11")]
        public void Cooling()
        {
            var configurationParameters = new ConfigurationPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            configurationParameters
                .CoolingParameters();
            switchPages
                .SwitchPage();
            configurationParameters
                .IgnitionParameters();
            switchPages
                .SwitchPage();
        }

        [Test, Order(12)]
        [Description("12. Переключение на 'Режим'")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature12")]
        [AllureStory("Story12")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue12")]
        [AllureTms("Tms12")]
        public void SwitchingMode()
        {
            var matProgressBar = new MatProgressBarPageObject(_webDriver);
            matProgressBar
                .MainMode();
        }

        [Test, Order(13)]
        [Description("13. Параметры термостата")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature13")]
        [AllureStory("Story13")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue13")]
        [AllureTms("Tms13")]
        public void MainMode()
        {
            var modePage = new ModePageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var analysisThermo = new AnalysisModePageObject(_webDriver);
            switchPages
                .SwitchPage();
            modePage
                .Thermostates();    
            analysisThermo
                .ThermostatesColums()
                .TemperatureColumn1Row0().TimeColumn2Row0().SpeedColumn0Row1()
                .TemperatureColumn1Row1().TimeColumn2Row1().SpeedColumn0Row2()
                .TemperatureColumn1Row2().TimeColumn2Row2().SpeedColumn0Row3()
                .TemperatureColumn1Row3().TimeColumn2Row3().Overlay();
            modePage
                .BlowingThermostates();
        }

        [Test, Order(14)]
        [Description("14. Запись сигнала")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature14")]
        [AllureStory("Story14")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue14")]
        [AllureTms("Tms14")]
        public void RecordSignal()
        {     
            var modePage = new ModePageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var recordSignal = new RecordSignalsSignalPanelPageObject(_webDriver);
            modePage
                .Signals();
            switchPages
                .SwitchPage();     
            recordSignal
                .ShowOnlySignalsDetectors()
                .ThermostatesColumns_1().TCD2().TCD1()
                .ColumnThermostatDampers_1();
        }
       
        [Test, Order(15)]
        [Description("15. События времени")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature15")]
        [AllureStory("Story15")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue15")]
        [AllureTms("Tms15")]
        public void RunTimeEvent()
        {
            var modePage = new ModePageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            //var runTimeEvent = new RunTimeEventsPageObject(_webDriver);
            modePage
                .Events();
            switchPages
                .SwitchPage();            
        }

        [Test, Order(16)]
        [Description("16. Переключение на 'Состояние'")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature16")]
        [AllureStory("Story16")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue16")]
        [AllureTms("Tms16")]
        public void State()
        {
            var matProgressBar = new MatProgressBarPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var statePage = new StatePageObject(_webDriver);
            //var signalState = new SignalStatePageObject(_webDriver);
            matProgressBar
                .MainState();
            switchPages
                .SwitchPage();
            statePage
                .Close();
            statePage
                .Signal();
            switchPages
                .SwitchPage();       
        }

        [Test, Order(17)]
        [Description("17. Переключение на 'Подключения'")]
        [AllureSeverity(SeverityLevel.trivial)]
        [AllureFeature("Feature17")]
        [AllureStory("Story17")]
        [AllureOwner("Owner1")]
        [AllureIssue("Issue17")]
        [AllureTms("Tms17")]
        public void Connections()
        {
            var matProgressBar = new MatProgressBarPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var controlPanel = new ControlPanelPageObject(_webDriver);
            matProgressBar
                .MainConnection();
            switchPages
                .SwitchPage();
            controlPanel
                .DisconectDevice().DeleteAdditionDevice().Alert(Alert.Ok);
        }
    }
}
