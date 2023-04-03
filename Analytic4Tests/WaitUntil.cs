using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Analytic4Tests
{
    public static class WaitUntil
    {
        public static void ShouldLocate(IWebDriver webDriver, string location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(location));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out: {location}", ex);
            }
        }

        public static void WaitSomeInterval(int seconds = 10)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void WaitElement(IWebDriver webDriver, By locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void WaitHideElement(IWebDriver webDriver, By iClassName, int second = 10)
        {
            WebDriverWait iWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(second));
            iWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(iClassName));
        }

        public static void WaitWarningElements(IWebDriver webDriver, By locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
        }
    }
}
