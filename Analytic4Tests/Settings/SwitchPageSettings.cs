using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analytic4Tests.Settings
{
    public class SwitchPageSettings
    {
        private IWebDriver _webDriver;

        public SwitchPageSettings(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string GetCurrentWindow()
        {
            string windowTitle = _webDriver.Title;
            return windowTitle;
        }

        public string GetMainWinHandle(IWebDriver webDriver)
        {
            return _webDriver.CurrentWindowHandle;
        }

        public SwitchPageSettings SwitchPage()
        {
            _webDriver.SwitchTo().Window(_webDriver.WindowHandles[1]);
            return new SwitchPageSettings(_webDriver);
        }

        public SwitchPageSettings RefreshPage()
        {
            _webDriver.Navigate().Refresh();
            //_webDriver.SwitchTo().ParentFrame();

            return new SwitchPageSettings(_webDriver);
        }

    }
}
