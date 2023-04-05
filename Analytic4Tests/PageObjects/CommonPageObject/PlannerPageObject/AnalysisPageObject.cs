using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analytic4Tests.PageObjects.CommonPageObject.PlannerPageObject
{
    public class AnalysisPageObject
    {
        private IWebDriver _webDriver;

        #region Без переферии
        private readonly By _withoutPeripheral = By.CssSelector(".refs");
        #endregion

        #region Обертка анализа
        #region Analysis-Position
        private readonly By _analysisPositionPanel = By.CssSelector(".analysis-position");
        private readonly By _arrowDown = By.XPath("//app-analysis-series/div/div[1]/div/div[1]/button[1]");
        private readonly By _arrowUp = By.XPath("//app-analysis-series/div/div[1]/div/div[1]/button[2]");
        private readonly By _cyclеFor = By.XPath("//app-analysis-series/div/div[1]/div/div[1]/button[3]");
        private readonly By _deleteAnalysis = By.XPath("//app-analysis-series/div/div[1]/div/div[1]/button[4]");
        private readonly By _matAnalysisPanel = By.XPath("//app-analysis-series/div/div[1]/div/div[1]/app-select");
        private readonly By _matSelectPanel = By.CssSelector(".mat-select-panel.mat-select-panel");
        #endregion

        #region Profiles
        private readonly By _profilePanel = By.CssSelector(".profiles");
        private readonly By _matProfilePanel = By.CssSelector(".ng-valid .ng-star-inserted .mat-select-trigger");
        private readonly By _commonMatSelectPanel = By.CssSelector(".mat-select-panel");
        private readonly By _commonMatOptionText = By.CssSelector(".mat-option-text");
        #endregion

        #region Groups
        private readonly By _groups = By.CssSelector(".groups");
        private readonly By _analysis = By.XPath("//app-analysis-series/div/div[1]/div/div[3]/button[1]");
        private readonly By _instrument = By.XPath("//app-analysis-series/div/div[1]/div/div[3]/button[2]");
        private readonly By _executor = By.XPath("//app-analysis-series/div/div[1]/div/div[3]/button[3]");
        #endregion

        #region
        private readonly By _close = By.CssSelector(".close");
        #endregion

        #region Name
        private readonly By _panelName = By.CssSelector(".name");
        private readonly By _name = By.CssSelector(".name input");
        private readonly By _checkBox = By.XPath("//div[5]/p4-checkbox/div/a4-check-box");
        private readonly By _rollUp = By.XPath("//app-analysis-series/div/div[1]/div/div[5]/button");
        #endregion
        #endregion

        #region Анализ
        private readonly By _btnAnalysis = By.XPath("//table/thead/tr[1]/th[2]/div/button");
        private readonly By _matMenuContentAnalysis = By.CssSelector(".mat-menu-content");
        private readonly By _checkBoxContentAnalysis = By.CssSelector(".p4-checkbox");
        #endregion

        #region Инструмент
        private readonly By _btnInstrument = By.XPath("//table/thead/tr[1]/th[3]/div/button");
        #endregion

        #region Ввод пробы
        private readonly By _enterSample = By.XPath("//table/thead/tr[1]/th[4]/div/button");
        #endregion

        #region Оверлей
        private readonly By _appTable = By.CssSelector(".bordered");
        private readonly By _obscure = By.CssSelector(".cdk-overlay-backdrop");
        #endregion

        #region 1-ый анализ
        #region Чекбокс 
        private readonly By _checkBoxFirst = By.XPath("//tr[1]/td[1]/div/p4-checkbox/div/a4-check-box");
        #endregion

        #region Активность
        private readonly By _slideTogleLabel = By.CssSelector(".mat-slide-toggle-label");
        #endregion

        #region Проект
        private readonly By _commonProject = By.XPath("//td[6]/div/div/div/app-action-selector/div/button");
        private readonly By _projectPannelContainer = By.CssSelector(".cdk-dialog-container");
        private readonly By _treeProjectsSelect = By.CssSelector(".header");
        private readonly By _btnProject = By.CssSelector(".buttons button");
        #endregion

        #region Метод
        private readonly By _commonMethod = By.XPath("//td[7]/div/div/div/app-action-selector/div/button");
        private readonly By _methodPannelContainer = By.CssSelector(".method-menu");
        private readonly By _treeMethodsSelect = By.CssSelector(".mat-focus-indicator div");
        private readonly By _dialogContainer = By.CssSelector(".mat-dialog-container");
        private readonly By _inputNameMethod = By.CssSelector(".g-name");
        private readonly By _gOk = By.CssSelector(".g-ok");
        private readonly By _gCancel = By.CssSelector("g-cancel");
        private readonly By _methods = By.CssSelector(".method");
        #endregion

        #region Виала
        private readonly By _vial = By.XPath("//td[8]/div/div/app-input-number/input");
        #endregion

        #region Проба
        private readonly By _sample = By.XPath("//td[9]/div/div/div/input");
        #endregion

        #region Паспорт
        private readonly By _commonSample = By.XPath("//td[9]/div/div/div/app-action-selector/div/button");
        private readonly By _samplePannelContainer = By.CssSelector(".grid-body");
        private readonly By _nameSample = By.CssSelector(".mat-select input");
        private readonly By _purpose = By.CssSelector(".mat-form-field div div div mat-select div div span span");
        private readonly By _purposePanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _purposeParameters = By.CssSelector(".mat-option-text");
        private readonly By _volume = By.CssSelector(".mat-tab-group div mat-tab-body div div div a4-deltavalue-box input");
        private readonly By _dilution = By.CssSelector(".mat-tab-group div mat-tab-body div div div a4-double-box input");
        private readonly By _column = By.CssSelector(".mat-tab-group div mat-tab-body div div div a4-text-box input");
        private readonly By _comments = By.CssSelector(".mat-tab-group div mat-tab-body div div div a4-text-area div textarea");
        private readonly By _graduationLevel = By.XPath("//div[22]/a4-combobox/mat-form-field/div/div[1]/div/mat-select");
        private readonly By _graduationPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _graduationParameters = By.CssSelector(".mat-select-panel mat-option");
        private readonly By _btnClose = By.CssSelector(".close-button");
        #endregion

        #region Объём
        private readonly By _volumeFirst = By.XPath("//td[10]/div/div/app-input-number/input");
        #endregion

        #region Назначение
        private readonly By _purposeFirst = By.XPath("//td[11]/div/div/app-select/mat-select/div/div[1]");
        private readonly By _purposeWrapPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _purposeFirstParameters = By.CssSelector(".mat-option-text");
        #endregion

        #region Разведение
        //private readonly By _breeding = By.XPath("//td[12]/div/div/app-input-number/input");
        #endregion

        #region Старт
        private readonly By _startFirst = By.XPath("//td[13]/div/div/app-select/mat-select/div/div[1]");
        private readonly By _startWrapPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _startParameters = By.CssSelector(".mat-option-text");
        #endregion

        #region Инструментальный метод
        private readonly By _instumentalMethod = By.XPath("//td[15]/div/div/div/app-action-selector/div/button[1]");
        private readonly By _panelInstrumentalMethod = By.CssSelector(".mat-menu-content");
        private readonly By _parametersInstrumentalMethod = By.CssSelector(".method");
        private readonly By _removeInstrumentalMethod = By.XPath("//td[15]/div/div/div/app-action-selector/div/button[2]");
        #endregion

        #region Каналы
        private readonly By _channel = By.XPath("//td[16]/div/div/div/app-action-selector/div/button");
        private readonly By _panelChannel = By.CssSelector(".mat-menu-content");
        private readonly By _paremetersChannel = By.XPath("/html/body/div[3]/div[1]");
        #endregion

        #region Время анализа
        private readonly By _timeAnalysis = By.XPath("//td[17]/div/div/app-input-number/input");
        #endregion

        #region Устройство ввода
        private readonly By _inputDevice = By.XPath("//td[18]/div/div/app-select/mat-select");
        private readonly By _panelInputDevice = By.CssSelector(".mat-select-panel");
        private readonly By _parametersInputDevice = By.CssSelector(".mat-option");
        #endregion

        #region Режим
        private readonly By _mode = By.XPath("//td[19]/div/div/app-select/mat-select");
        private readonly By _panelMode = By.CssSelector(".mat-select-panel ");
        private readonly By _parametersMode = By.CssSelector(".mat-option-text");
        #endregion

        #endregion

        public AnalysisPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AnalysisPageObject WithoutPeripheral()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_withoutPeripheral).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject ArrowDown()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_arrowDown).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject ArrowUp()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_arrowUp).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject CyclеFor()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_cyclеFor).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject DeleteAnalysis()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_deleteAnalysis).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject AppSelect(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_matAnalysisPanel).Click();

            WaitUntil.WaitElement(_webDriver, _commonMatSelectPanel);
            _webDriver.FindElements(_commonMatOptionText).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject Profile(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_matProfilePanel).Click();

            WaitUntil.WaitElement(_webDriver, _commonMatSelectPanel);
            _webDriver.FindElements(_commonMatOptionText).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject Analysis()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_analysis).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject Instrument()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_instrument).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject Executor()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_executor).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject Name()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_name).SendKeys("Test");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject CheckBox()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_checkBox).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject RollUp()
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_rollUp).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject AnalysisPanel(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_btnAnalysis).Click();

            WaitUntil.WaitElement(_webDriver, _matMenuContentAnalysis);
            _webDriver.FindElements(_checkBoxContentAnalysis).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject InstrumentPanel(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_btnInstrument).Click();

            WaitUntil.WaitElement(_webDriver, _matMenuContentAnalysis);
            _webDriver.FindElements(_checkBoxContentAnalysis).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject ExecutorPanel(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_enterSample).Click();

            WaitUntil.WaitElement(_webDriver, _matMenuContentAnalysis);
            _webDriver.FindElements(_checkBoxContentAnalysis).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject CheckBoxFirst()
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            _webDriver.FindElement(_checkBoxFirst).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject ActivityFirst()
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            _webDriver.FindElement(_slideTogleLabel).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject ProjectFirst(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            _webDriver.FindElement(_commonProject).Click();

            WaitUntil.WaitElement(_webDriver, _projectPannelContainer);
            _webDriver.FindElements(_treeProjectsSelect).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject OpenCancel(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _projectPannelContainer);
            _webDriver.FindElements(_btnProject).First(x => x.Text == nameParameters).Click();

            return this;
        }

        // Если создается новый проект, то поменять значение "_method" на "_treeMethodsSelect" и раскоменнтировать строки ниже
        public AnalysisPageObject MethodFirst(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            _webDriver.FindElement(_commonMethod).Click();

            
            WaitUntil.WaitElement(_webDriver, _methods);
            _webDriver.FindElements(_methods).First(x => x.Text == nameParameters).Click();
            //WaitUntil.WaitElement(_webDriver, _dialogContainer);
            //_webDriver.FindElement(_inputNameMethod).SendKeys("test");
            //_webDriver.FindElement(_gOk).Click();
            WaitUntil.WaitSomeInterval(3);
            _webDriver.FindElement(_obscure).Click();

            return this;
        }

        public AnalysisPageObject VialFirst()
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            var vial = _webDriver.FindElement(_vial);
            vial.Click();
            vial.Clear();
            //vial.SendKeys("1");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SampleFirst()
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            var sample = _webDriver.FindElement(_sample);
            sample.Click();
            sample.SendKeys("1");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SamplePannel()
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            _webDriver.FindElement(_commonSample).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SampleName()
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            var nameSample = _webDriver.FindElement(_nameSample);
            nameSample.Click();
            nameSample.SendKeys("Test");

            return new AnalysisPageObject(_webDriver);
        }


        public AnalysisPageObject SamplePurpose(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            _webDriver.FindElement(_purpose).Click();

            WaitUntil.WaitElement(_webDriver, _purposePanel);
            _webDriver.FindElements(_purposeParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject SampleVolume()
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            var volume = _webDriver.FindElement(_volume);
            volume.Click();
            volume.Clear();
            volume.SendKeys("1");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SampleDilution()
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            var dilution = _webDriver.FindElement(_dilution);
            dilution.Click();
            dilution.Clear();
            dilution.SendKeys("1");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SampleColumn()
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            var column = _webDriver.FindElement(_column);
            column.Click();
            column.Clear();
            column.SendKeys("Test");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SampleComments()
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            var comments = _webDriver.FindElement(_comments);
            comments.Click();
            comments.Clear();
            comments.SendKeys("Test");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject SampleGraduationLevel(string namePareameters)
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            _webDriver.FindElement(_graduationLevel).Click();

            WaitUntil.WaitElement(_webDriver, _graduationPanel);
            _webDriver.FindElements(_graduationParameters).First(x => x.Text == namePareameters).Click();

            return this;
        }

        public AnalysisPageObject SampleClose()
        {
            WaitUntil.WaitElement(_webDriver, _samplePannelContainer);
            _webDriver.FindElement(_btnClose).Click();

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject VolumeFirst()
        {
            WaitUntil.WaitElement(_webDriver, _appTable);
            var volumeFirst = _webDriver.FindElement(_volumeFirst);
            volumeFirst.Click();
            volumeFirst.Clear();
            volumeFirst.SendKeys("1");

            return new AnalysisPageObject(_webDriver);
        }

        public AnalysisPageObject PurposeFirst(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_purposeFirst).Click();

            WaitUntil.WaitElement(_webDriver, _purposeWrapPanel);
            _webDriver.FindElements(_purposeFirstParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public AnalysisPageObject StartFirst(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _analysisPositionPanel);
            _webDriver.FindElement(_startFirst).Click();

            WaitUntil.WaitElement(_webDriver, _startWrapPanel);
            _webDriver.FindElements(_startParameters).First(x => x.Text == nameParameters).Click();

            return this;
        }
    }
}
