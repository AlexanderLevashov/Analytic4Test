using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analytic4Tests.PageObjects.PageObjectPlanner
{
    public class CommonParametersPageObject
    {
        private IWebDriver _webDriver;

        #region
        private readonly By _overlay = By.CssSelector(".ng-star-inserted .ng-star-inserted .indicated-table-parameter .ng-star-inserted");
        private readonly By _commonPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _commonSubPannel = By.CssSelector(".mat-menu-content");
        private readonly By _commonParameters = By.CssSelector(".mat-option-text");
        private readonly By _commonSubParameters = By.XPath("//app-select/mat-select");
        private readonly By _obscure = By.CssSelector(".cdk-overlay-backdrop-showing");
        #endregion

        #region Хроматограф-1
        private readonly By _Chromatograph_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[2]/td[2]");
        private readonly By _IpAddress = By.XPath("//table[@class='mat-sort']/tbody/tr[3]/td[2]");
        private readonly By _gateway = By.XPath("//table[@class='mat-sort']/tbody/tr[4]/td[2]");
        private readonly By _ambientPressure = By.XPath("//table[@class='mat-sort']/tbody/tr[5]/td[2]/div/app-editable-parameter/app-control/input");
        private readonly By _ambientTemperature = By.XPath("//table[@class='mat-sort']/tbody/tr[6]/td[2]/div/app-editable-parameter/app-control/input");
        private readonly By _blowingMethod = By.XPath("//table[@class='mat-sort']/tbody/tr[7]/td[2]");
        private readonly By _defaultMethod = By.XPath("//table[@class='mat-sort']/tbody/tr[8]/td[2]");
        private readonly By _soundKeyPressing = By.XPath("//table[@class='mat-sort']/tbody/tr[9]/td[2]/div/app-editable-parameter/input");
        private readonly By _soundWhenReady = By.XPath("//table[@class='mat-sort']/tbody/tr[10]/td[2]/div/app-editable-parameter/input");
        private readonly By _soundAfterInitial = By.XPath("//table[@class='mat-sort']/tbody/tr[11]/td[2]/div/app-editable-parameter/input");
        private readonly By _soundAfterAnalysis = By.XPath("//table[@class='mat-sort']/tbody/tr[12]/td[2]/div/app-editable-parameter/input");
        #endregion

        #region Термостат колонок-1
        private readonly By _oven_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[13]/td[2]");
        private readonly By _prepRun = By.XPath("//table[@class='mat-sort']/tbody/tr[14]/td[2]/div/app-editable-parameter/input");
        private readonly By _maxTemperatureOven = By.XPath("//table[@class='mat-sort']/tbody/tr[15]/td[2]");
        private readonly By _tOvenTDetectors = By.XPath("//table[@class='mat-sort']/tbody/tr[16]/td[2]/div/app-editable-parameter/input");
        private readonly By _tOvenTInlets = By.XPath("//table[@class='mat-sort']/tbody/tr[17]/td[2]/div/app-editable-parameter/input");
        #endregion

        #region ДТП-2
        private readonly By _TCD_2 = By.XPath("//table[@class='mat-sort']/tbody/tr[18]/td[2]");
        private readonly By _activityTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[19]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _typeDetectorTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[20]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _acquisitionRateTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[21]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _thermostatTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[22]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _powerTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[23]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _shiftTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[24]/td[2]");
        private readonly By _spiralOnTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[25]/td[2]/div/app-editable-parameter/input");
        private readonly By _signalInversionTCD2 = By.XPath("//table[@class='mat-sort']/tbody/tr[26]/td[2]/div/app-editable-parameter/input");
        #endregion

        #region ДТП-1
        private readonly By _TCD_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[27]/td[2]");
        private readonly By _activityTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[28]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _typeDetectorTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[29]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _acquisitionRateTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[30]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _thermostatTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[31]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _powerTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[32]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _shiftTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[33]/td[2]");
        private readonly By _spiralOnTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[34]/td[2]/div/app-editable-parameter/input");
        private readonly By _signalInversionTCD1 = By.XPath("//table[@class='mat-sort']/tbody/tr[35]/td[2]/div/app-editable-parameter/input");
        #endregion

        #region ПИД-1
        private readonly By _FID_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[18]/td[2]");
        private readonly By _activityFID = By.XPath("//table[@class='mat-sort']/tbody/tr[19]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _acquisitionRateFID = By.XPath("//table[@class='mat-sort']/tbody/tr[20]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _thermostatFID = By.XPath("//table[@class='mat-sort']/tbody/tr[21]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _maxTemperatureFID = By.XPath("//table[@class='mat-sort']/tbody/tr[22]/td[2]");
        private readonly By _heaterControlOffFID = By.XPath("//table[@class='mat-sort']/tbody/tr[23]/td[2]/div/app-editable-parameter/input");
        private readonly By _useUniversalDFPC = By.XPath("//table[@class='mat-sort']/tbody/tr[24]/td[2]/div/app-editable-parameter/input");
        private readonly By _DFPCmultichannel = By.XPath("//table[@class='mat-sort']/tbody/tr[25]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _DFPCHydrogenFID = By.XPath("//table[@class='mat-sort']/tbody/tr[26]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _DFPCAirFID = By.XPath("//table[@class='mat-sort']/tbody/tr[27]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _DFPCMakeup = By.XPath("//table[@class='mat-sort']/tbody/tr[28]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _makeUpGasType = By.XPath("//table[@class='mat-sort']/tbody/tr[29]/td[2]/div/app-editable-parameter/a4-combobox");
        #endregion

        #region ПФД-1
        private readonly By _FPD_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[30]/td[2]");
        private readonly By _activityFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[31]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _acquisitionRateFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[32]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _thermostatFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[33]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _maxTemperatureFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[34]/td[2]");
        private readonly By _heaterControlOffFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[35]/td[2]/div/app-editable-parameter/input");
        private readonly By _DFPCHydrogenFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[36]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _DFPCAirFPD = By.XPath("//table[@class='mat-sort']/tbody/tr[37]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _PMTVoltage = By.XPath("//table[@class='mat-sort']/tbody/tr[38]/td[2]/div/app-editable-parameter/input");
        private readonly By _PMTSignalInAbsence = By.XPath("//table[@class='mat-sort']/tbody/tr[39]/td[2]");
        #endregion

        #region Порт ввода-1
        private readonly By _inlet_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[40]/td[2]");
        private readonly By _typeInlet = By.XPath("//table[@class='mat-sort']/tbody/tr[41]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _label = By.XPath("//table[@class='mat-sort']/tbody/tr[42]/td[2]");
        private readonly By _inletThermostat = By.XPath("//table[@class='mat-sort']/tbody/tr[43]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _heaterControlOff = By.XPath("//table[@class='mat-sort']/tbody/tr[44]/td[2]/div/app-editable-parameter/input");
        private readonly By _splitlessSolenoidValve = By.XPath("//table[@class='mat-sort']/tbody/tr[45]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _onColumnInjection = By.XPath("//table[@class='mat-sort']/tbody/tr[46]/td[2]/div/app-editable-parameter/input");
        private readonly By _carrierGasType = By.XPath("//table[@class='mat-sort']/tbody/tr[47]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _wasteGasType = By.XPath("//table[@class='mat-sort']/tbody/tr[48]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _DFPCSeptumpurgeFlow = By.XPath("//table[@class='mat-sort']/tbody/tr[49]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _typeCarrierGasType = By.XPath("//table[@class='mat-sort']/tbody/tr[50]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _leakControl = By.XPath("//table[@class='mat-sort']/tbody/tr[51]/td[2]/div/app-editable-parameter/input");
        private readonly By _lermittedLeak = By.XPath("//table[@class='mat-sort']/tbody/tr[52]/td[2]");
        private readonly By _maxTemperature = By.XPath("//table[@class='mat-sort']/tbody/tr[53]/td[2]");
        #endregion

        #region Колонка-1
        private readonly By _column_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[54]/td[2]");
        private readonly By _channel = By.XPath("//table[@class='mat-sort']/tbody/tr[55]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _inlet = By.XPath("//table[@class='mat-sort']/tbody/tr[56]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _typeColumn = By.XPath("//table[@class='mat-sort']/tbody/tr[57]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _length = By.XPath("//table[@class='mat-sort']/tbody/tr[58]/td[2]");
        private readonly By _diameter = By.XPath("//table[@class='mat-sort']/tbody/tr[59]/td[2]");
        private readonly By _outletPressure = By.XPath("//table[@class='mat-sort']/tbody/tr[60]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _outletPressureValue = By.XPath("//table[@class='mat-sort']/tbody/tr[61]/td[2]");
        #endregion

        #region Канал
        private readonly By _value_1 = By.XPath("//table[@class='mat-sort']/tbody/tr[62]/td[2]");
        private readonly By _channelValue = By.XPath("//table[@class='mat-sort']/tbody/tr[63]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _starPosition = By.XPath("//table[@class='mat-sort']/tbody/tr[64]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _DFPC = By.XPath("//table[@class='mat-sort']/tbody/tr[65]/td[2]/div/app-editable-parameter/a4-combobox");
        private readonly By _typeGas = By.XPath("//table[@class='mat-sort']/tbody/tr[66]/td[2]/div/app-editable-parameter/a4-combobox");
        #endregion


        public CommonParametersPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        #region Хроматограф-1
        public CommonParametersPageObject Chromatograph()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            WaitUntil.WaitSomeInterval(2);
            _webDriver.FindElement(_Chromatograph_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject IpAddress(string ip)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_IpAddress).SendKeys(ip);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject Gateway(string gateway)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            var gateway_ = _webDriver.FindElement(_gateway);
            gateway_.Click();
            gateway_.Clear();
            gateway_.SendKeys(gateway);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject AmbientPressure(string pressure)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            var _pressure = _webDriver.FindElement(_ambientPressure);
            _pressure.Click();
            _pressure.Clear();
            _pressure.SendKeys(pressure);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject AmbientTemperature(string temperature)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            var _temperature = _webDriver.FindElement(_ambientTemperature);
            _temperature.Click();
            _temperature.Clear();
            _temperature.SendKeys(temperature);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject BlowingMethod(string nameParameters, string nameSubParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_blowingMethod).Click();

            WaitUntil.WaitElement(_webDriver, _commonSubPannel);
            _webDriver.FindElements(_commonSubParameters).First(x => x.Text == nameSubParameters).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();
            _webDriver.FindElement(_obscure).Click();

            return this;
        }

        public CommonParametersPageObject DefaultMethod(string nameParameters, string nameSubParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_defaultMethod).Click();

            WaitUntil.WaitElement(_webDriver, _commonSubPannel);
            _webDriver.FindElements(_commonSubParameters).First(x => x.Text == nameSubParameters).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();
            _webDriver.FindElement(_obscure).Click();

            return this;
        }

        public CommonParametersPageObject SoundKeyPressing()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_soundKeyPressing).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SoundWhenReady()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_soundWhenReady).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SoundAfterInitial()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_soundAfterInitial).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SoundAfterAnalysis()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_soundAfterAnalysis).Click();

            return new CommonParametersPageObject(_webDriver);
        }
        #endregion 

        #region Термостат колонок-1
        public CommonParametersPageObject Oven()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_oven_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject PrepRun()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_prepRun).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject MaxTemperatureOven(string temperature)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            var _temperature = _webDriver.FindElement(_maxTemperatureOven);
            _temperature.Click();
            _temperature.Clear();
            _temperature.SendKeys(temperature);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject TOvenTDetectors()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_tOvenTDetectors).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject TOvenTInlets()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_tOvenTInlets).Click();

            return new CommonParametersPageObject(_webDriver);
        }
        #endregion

        #region ДТП-2
        public CommonParametersPageObject TCD2()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_TCD_2).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject TypeDetectorTCD2(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_typeDetectorTCD2).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ActivityTCD2(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_activityTCD2).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject AcquisitionRateTCD2(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_acquisitionRateTCD2).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ThermostatTCD2(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_thermostatTCD2).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject PowerTCD2(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_powerTCD2).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ShiftTCD2(string shift)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            var _shift = _webDriver.FindElement(_shiftTCD2);
            _shift.Click();
            _shift.Clear();
            _shift.SendKeys(shift);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SpiralOnTCD2()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_spiralOnTCD2).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SignalInversionTCD2()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_signalInversionTCD2).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        #endregion

        #region ДТП-1
        public CommonParametersPageObject TCD1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_TCD_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject TypeDetectorTCD1(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_typeDetectorTCD1).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ActivityTCD1(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_activityTCD1).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject AcquisitionRateTCD1(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_acquisitionRateTCD1).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ThermostatTCD1(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_thermostatTCD1).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject PowerTCD1(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_powerTCD1).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ShiftTCD1(string shift)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_shiftTCD1).SendKeys(shift);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SpiralOnTCD1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_spiralOnTCD1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SignalInversionTCD1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_signalInversionTCD1).Click();

            return new CommonParametersPageObject(_webDriver);
        }
        #endregion

        #region ПИД-1
        public CommonParametersPageObject FID1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_FID_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject ActivityFID(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_activityFID).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject AcquisitionRateFID(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_acquisitionRateFID).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ThermostatFID(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_thermostatFID).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject MaxTemperatureFID(string temperature)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_maxTemperatureFID).SendKeys(temperature);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject HeaterControlOffFID()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_heaterControlOffFID).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject UseUniversalDFPC()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_useUniversalDFPC).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject DFPCmultichannel(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCmultichannel).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject DFPCHydrogenFID(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCHydrogenFID).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject DFPCAirFID(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCAirFID).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject DFPCMakeupl(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCMakeup).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject MakeUpGasType(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_makeUpGasType).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }
        #endregion

        #region ПФД-1
        public CommonParametersPageObject FPD1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_FPD_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject ActivityFPD(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_activityFPD).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject AcquisitionRateFPD(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_acquisitionRateFPD).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject ThermostatFPD(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_thermostatFPD).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject MaxTemperatureFPD(string temperature)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_maxTemperatureFPD).SendKeys(temperature);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject HeaterControlOffFPD()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_heaterControlOffFPD).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject DFPCHydrogenFPD(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCHydrogenFPD).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject DFPCAirFPD(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCAirFPD).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject PMTVoltage()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_PMTVoltage).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject PMTSignalInAbsence(string signal)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_PMTSignalInAbsence).SendKeys(signal);

            return new CommonParametersPageObject(_webDriver);
        }
        #endregion

        #region Порт ввода-1
        public CommonParametersPageObject Inlet1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_inlet_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject TypeInlet(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_typeInlet).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject Label(string lebel)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_label).SendKeys(lebel);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject InletThermostat(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_inletThermostat).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }
        public CommonParametersPageObject HeaterControlOff()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_heaterControlOff).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject SplitlessSolenoidValve(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_splitlessSolenoidValve).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject OnColumnInjection()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_onColumnInjection).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject CarrierGasType(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_carrierGasType).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject WasteGasType(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_wasteGasType).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject DFPCSeptumpurgeFlow(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPCSeptumpurgeFlow).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject TypeCarrierGasTyp(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_typeCarrierGasType).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject LeakControl()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_leakControl).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject LermittedLeak(string leak)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_lermittedLeak).SendKeys(leak);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject MaxTemperature(string temperature)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_maxTemperature).SendKeys(temperature);

            return new CommonParametersPageObject(_webDriver);
        }
        #endregion

        #region Колонка-1
        public CommonParametersPageObject Column1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_column_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject Channel(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_channel).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject Inlet(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_inlet).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject TypeColumn(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_typeColumn).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject Length(string length)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_length).SendKeys(length);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject Diameter(string diameter)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_diameter).SendKeys(diameter);

            return new CommonParametersPageObject(_webDriver);
        }

        public CommonParametersPageObject OutletPressure(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_outletPressure).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject OutletPressureValue(string pressure)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_outletPressureValue).SendKeys(pressure);

            return new CommonParametersPageObject(_webDriver);
        }

        #endregion

        #region Канал
        public CommonParametersPageObject Value1()
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_value_1).Click();

            return new CommonParametersPageObject(_webDriver);
        }
     
        public CommonParametersPageObject ChannelValue(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_channelValue).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject StarPosition(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_starPosition).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject DFPC(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_DFPC).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public CommonParametersPageObject TypeGas(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _overlay);
            _webDriver.FindElement(_typeGas).Click();

            WaitUntil.WaitElement(_webDriver, _commonPanel);
            _webDriver.FindElements(_commonParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        #endregion
    }
}
