using OpenQA.Selenium;

namespace Analytic4Tests.PageObjects.CommonPageObject.ModePlannerPageObject
{
    public class BlowingModePageObject
    {
        private IWebDriver _webDriver;

        private readonly By _thermostatesColums = By.XPath("//tr[3]/td[3]/div/app-editable-parameter/app-control/input");
        private readonly By _obscure = By.XPath("//app-device/div/div[2]/app-table/table/tbody");

        public BlowingModePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public BlowingModePageObject ThermostatesColums()
        {
            WaitUntil.WaitElement(_webDriver, _obscure);
            var thermostatesColums = _webDriver.FindElement(_thermostatesColums);
            thermostatesColums.Click();
            thermostatesColums.Clear();
            thermostatesColums.SendKeys("0");

            return new BlowingModePageObject(_webDriver);
        }

    }
}
