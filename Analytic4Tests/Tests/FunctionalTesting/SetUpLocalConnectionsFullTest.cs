using Analytic4Tests.BaseObjects;
using Analytic4Tests.PageObjects;
using Analytic4Tests.PageObjects.PageObjectPlanner;
using Analytic4Tests.Settings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Tests.FunctionalTesting
{
    [TestFixture]
    public class SetUpLocalConnectionsFullTest : BaseTest
    {
        [Test]
        public void SetUpLocalConnectionFull()
        {

            #region Переменные среды
            var authorisation = new AuthorisationPageObject(_webDriver);
            var mainNavigator = new MainNavigatorPageObject(_webDriver);
            var switchPages = new SwitchPageSettings(_webDriver);
            var controlPanel = new ControlPanelPageObject(_webDriver);
            var planner = new PlannerCommonPageObject(_webDriver);
            var analysis = new AnalysisPageObject(_webDriver);
            var matProgressBar = new MatProgressBarPageObject(_webDriver);
            var commonParameters = new CommonParametersPageObject(_webDriver);
            #endregion

            #region Авторизация
            authorisation
                .Login(UsersForTests.StartLogin, UsersForTests.StartPass);
            #endregion

            #region Включение эмулятора
            //mainNavigator
             //  .BtnDevices(DevicesForNavigatorTests.EmulatorGCH)
              // .MatMenuContent(DevicesForNavigatorTests.NaturalGas)
              // .ElementsWarning();
            #endregion

            #region Создать соединение
            mainNavigator
                .SelectionDevices(DevicesForNavigatorTests.SetUpConnection);
            #endregion

            #region Переключение на нужную страницу
            switchPages
                .SwitchPage();
            #endregion

            #region Полная настройка панели
            controlPanel
                .ShowAllConnections()
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
                //.Address(Adress_127_0_0_1.Octet0, Adress_127_0_0_1.Octet1, Adress_127_0_0_1.Octet2, Adress_127_0_0_1.Octet3)
                .Address(Adress_192_168_77_89.Octet0, Adress_192_168_77_89.Octet1, Adress_192_168_77_89.Octet2, Adress_192_168_77_89.Octet3)
                .Port(Port.Port2010)
                //.DeleteDevice()
                //.Alert(Alert.Ok);
                .ConnectDevice();
            //Если эмулятор не работает
                //.DisconectDevice();
            #endregion

            planner
                //.SheschedulerSettings(ParametersForPlannerTests.Settings, SettingsParameters.DefaultDevice, SettingsDefaultDevice.Plagin)
                .AddAnalysis(SettingsAddAnalysis.Add_1_Analysis);

            analysis
                .AppSelect(ParametersForAnalysisTests.MatPanel_1)
                .Profile(ParametersForProfile.MatProfile_1)
                //.AnalysisPanel(ParametersForCheckBoxAnalysis.Sample)
                .InstrumentPanel(ParametersForCheckBoxInstrument.Channel)
                .CheckBoxFirst()
                //.ActivityFirst()
                .ProjectFirst(ParametersForProject.Project)
                .OpenCancel(ParametersForPanelProject.Ok)
                .MethodFirst(ParametersForMethod.Test)
                .VialFirst()
                .SampleFirst()
                .SamplePannel()
                .SampleName()
                .SamplePurpose(ParametersForPurpose.Analysis)
                .SampleVolume()
                .SampleDilution()
                .SampleColumn()
                .SampleComments()
                .SampleGraduationLevel(ParametersForGraduationLevel.Not)
                .SampleClose()
                .PurposeFirst(ParametersForState.Analysis);

            matProgressBar
                .MainConfiguration();

            #region Переключение на нужную страницу
            switchPages
                .SwitchPage();
            #endregion

            commonParameters
                .Chromatograph()
                .AmbientPressure(Chromatograph.Pressure)
                .AmbientTemperature(Chromatograph.Temperature)
                .BlowingMethod(Chromatograph.CommonSubParameters, Chromatograph.CommonParameters_1)
                .DefaultMethod(Chromatograph.CommonSubParameters, Chromatograph.CommonParameters_1)
                .SoundKeyPressing()
                .SoundWhenReady()
                .SoundAfterInitial()
                .SoundAfterAnalysis();
        }
    }
}
