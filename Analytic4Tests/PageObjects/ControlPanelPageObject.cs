using OpenQA.Selenium;
using System.Linq;

namespace Analytic4Tests.PageObjects
{
    public class ControlPanelPageObject
    {
        private IWebDriver _webDriver;

        #region Левая панель меню
        private readonly By _panelControlMenu = By.CssSelector(".control-menu");
        private readonly By _btnConnectDevice = By.Id("connect-to-device");
        private readonly By _btnDisconnectDevice = By.Id("disconnect-from-device");
        private readonly By _btnAddDevice = By.Id("add-connection");
        private readonly By _btnDeleteDevice = By.Id("remove-connection");
        private readonly By _btnSaveConnection = By.Id("save-connection");
        private readonly By _btnSetUpConnections = By.Id("setup-profile");

        #region Настройка соединений
        private readonly By _commonPanelLoadSave = By.CssSelector(".mat-menu-content");
        private readonly By _btnLoadProfile = By.CssSelector(".upload-button");
        private readonly By _btnSaveProfile = By.CssSelector(".ng-star-inserted p4-link-downloader");
        #endregion
        #endregion

        #region Показать соединения
        private readonly By _showAllConnections = By.XPath("//div[@class='settings ng-star-inserted']/p4-checkbox");
        #endregion

        #region Последний элемент
        private readonly By _panelConnection = By.CssSelector(".mat-tab-labels");
        private readonly By _lastElement = By.XPath("//div[@class='mat-tab-labels']/div[last()]"); 
        #endregion     

        #region Поля в настройках
        private readonly By _deviceConnectionSettings = By.XPath("//div[@class='connection-table-wrapper']");
        private readonly By _inputConnection = By.XPath("//div[2][@class='value ng-star-inserted']/universal-model-parameter-control/input"); 
        private readonly By _keepHistory = By.XPath("//div[4][@class='value ng-star-inserted']/universal-model-parameter-control/input");
        private readonly By _numberChannelStart = By.XPath("//div[6][@class='value ng-star-inserted']/universal-model-parameter-control");
        private readonly By _authostartPlane = By.XPath("//div[8][@class='value ng-star-inserted']/universal-model-parameter-control/p4-checkbox/div/a4-check-box");
        private readonly By _findDevice = By.XPath("//div[9][@class='find-devs ng-star-inserted']/button");
        private readonly By _addNewDeviceManually = By.XPath("//div[10][@class='find-devs ng-star-inserted']/button");
        #endregion

        #region Устройcтво-1
        private readonly By _numberDevice = By.XPath("//div[@class='value main']");
        private readonly By _deleteDevice = By.XPath("//app-instrument[@class='ng-star-inserted']/div[2]/button");
        private readonly By _module = By.XPath("//div[4][@class='value']");
        private readonly By _channel = By.XPath("//div[6][@class='value']");
        private readonly By _connection = By.XPath("//div[8][@class='value']");
        private readonly By _ip = By.XPath("//div[10][@class='value ng-star-inserted']/app-ip-address/div/app-input-number/input");
        private readonly By _port = By.XPath("//div[12][@class='value']/app-input-number/input");
        #endregion

        #region Устройство 2, 3, и тд.
        private readonly By _moduleLast = By.XPath("//app-instrument[last()]/div[4]");
        private readonly By _channelLast = By.XPath("//app-instrument[last()]/div[6]");
        private readonly By _connectionLast = By.XPath("//app-instrument[last()]/div[8]");
        private readonly By _ipLast = By.XPath("//app-instrument[last()]/div[10]/app-ip-address/div/app-input-number[1]/input");
        private readonly By _portLast = By.XPath("//app-instrument[last()]/div[12]//app-input-number/input");
        private readonly By _deleteDeviceLast = By.XPath("//app-instrument[@class='ng-star-inserted']/div/button[last()]");
        #endregion

        #region Соединение
        private readonly By _selectConnectionPanel = By.CssSelector(".mat-select-panel-wrap");
        private readonly By _parametersForConnectionPanel = By.CssSelector(".mat-select-panel mat-option");
        #endregion

        #region Алерт на удаление
        private readonly By _attentionPanel = By.CssSelector(".cdk-overlay-pane");
        private readonly By _selectChangeDeleteDevice = By.CssSelector(".mat-dialog-container .mat-menu-trigger");
        #endregion

        public ControlPanelPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public ControlPanelPageObject ConnectDevice()
        {
            WaitUntil.WaitElement(_webDriver, _panelControlMenu);
             _webDriver.FindElement(_btnConnectDevice).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject DisconectDevice()
        {
            WaitUntil.WaitElement(_webDriver, _panelControlMenu);
            WaitUntil.WaitSomeInterval(4);
            _webDriver.FindElement(_btnDisconnectDevice).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject ShowAllConnections()
        {
            WaitUntil.WaitElement(_webDriver, _panelConnection);
            _webDriver.FindElement(_showAllConnections);

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject AddDevice()
        {
            WaitUntil.WaitElement(_webDriver, _panelControlMenu);
            _webDriver.FindElement(_btnAddDevice).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject DeleteDevice()
        {
            WaitUntil.WaitElement(_webDriver, _panelControlMenu);
            WaitUntil.WaitSomeInterval(1);
            _webDriver.FindElement(_btnDeleteDevice).Click();
            
            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject SaveConnection()
        {
            WaitUntil.WaitElement(_webDriver, _panelControlMenu);
            _webDriver.FindElement(_btnSaveConnection).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject SetUpConnections()
        {
            WaitUntil.WaitElement(_webDriver, _panelControlMenu);
            _webDriver.FindElement(_btnSetUpConnections).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject LoadProfile()
        {
            WaitUntil.WaitElement(_webDriver, _commonPanelLoadSave);
            _webDriver.FindElement(_btnLoadProfile).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject SaveProfile()
        {
            WaitUntil.WaitElement(_webDriver, _commonPanelLoadSave);
            _webDriver.FindElement(_btnSaveProfile).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject ChoosingLastElement()
        {
            WaitUntil.WaitElement(_webDriver, _panelConnection);
            WaitUntil.WaitElement(_webDriver, _lastElement);
            _webDriver.FindElement(_lastElement).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject InputConnection()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            var inputConnection = _webDriver.FindElement(_inputConnection);
            inputConnection.SendKeys(Keys.Control + "A" + Keys.Delete);
            inputConnection.SendKeys("Test Connection");
           
            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject KeepHistory()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            var keepHistory = _webDriver.FindElement(_keepHistory);
            keepHistory.Clear();
            keepHistory.SendKeys("10");

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject NumberChannelStart(string nameParameters)
        {
            _webDriver.FindElement(_numberChannelStart).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject AuthostartPlan()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_authostartPlane).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject FindDevice()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_findDevice).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject AddNewDeviceManually()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_addNewDeviceManually).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject Module(string nameParameters)
        {
            _webDriver.FindElement(_module).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject Channel(string nameParameters)
        {
            _webDriver.FindElement(_channel).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject Connection(string nameParameters)
        {
            _webDriver.FindElement(_connection).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject Address(string octet0, string octet1, string octet2, string octet3)
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_ip).SendKeys(octet0 + Keys.Tab + octet1 + Keys.Tab + octet2 + Keys.Tab + octet3);
           
            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject Port(string port)
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_port).SendKeys(port);   
            
            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject DeleteAdditionDevice()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_deleteDevice).Click();

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject Alert(string nameParameters)
        {
            WaitUntil.WaitElement(_webDriver, _attentionPanel);
            _webDriver.FindElements(_selectChangeDeleteDevice).First(x => x.Text == nameParameters).Click();

            return this;
        }

        #region Последнее подключенное
        public ControlPanelPageObject ModuleLast(string nameParameters)
        {
            _webDriver.FindElement(_moduleLast).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject ChannelLast(string nameParameters)
        {
            _webDriver.FindElement(_channelLast).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject ConnectionLast(string nameParameters)
        {
            _webDriver.FindElement(_connectionLast).Click();
            WaitUntil.WaitElement(_webDriver, _selectConnectionPanel);
            _webDriver.FindElements(_parametersForConnectionPanel).First(x => x.Text == nameParameters).Click();

            return this;
        }

        public ControlPanelPageObject AddressLast(string octet0, string octet1, string octet2, string octet3)
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_ipLast).SendKeys(octet0 + Keys.Tab + octet1 + Keys.Tab + octet2 + Keys.Tab + octet3);

            return new ControlPanelPageObject(_webDriver);
        }

        public ControlPanelPageObject PortLast(string port)
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_portLast).SendKeys(port);

            return new ControlPanelPageObject(_webDriver);
        }
        public ControlPanelPageObject DeleteLastDevice()
        {
            WaitUntil.WaitElement(_webDriver, _deviceConnectionSettings);
            _webDriver.FindElement(_deleteDeviceLast).Click();

            return new ControlPanelPageObject(_webDriver);
        }
        #endregion

        public static string GetResponsPlannerParameters
        {
            get
            {
                string getResponse = "Test Connection"; // ADMIN
                return getResponse;
            }
        }

        public string GetResponseConnection()
        {
            WaitUntil.WaitElement(_webDriver, _inputConnection);
            string connection = _webDriver.FindElement(_inputConnection).Text;
            return connection;
        }

    }
}
