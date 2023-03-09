using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class Common
    {
        private static IWebElement GetElement (string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement (locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ExecuteJavaScript(string script)
        {
            Driver.GetDriver().ExecuteJavaScript(script);
        }

        internal static void ScrollByPixels(int pixelsRight, int pixelsDown)
        {
            ExecuteJavaScript($"window.scrollBy({pixelsRight}, {pixelsDown})");
        }

        internal static void ScrollUntilElementIsClickable(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 10;
            int currentTry = 0;

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch (Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        ExecuteJavaScript("window.scrollBy(0, 50)");
                        currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

        internal static void WaitForElementToBeEnabled(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).Enabled);

        }

        internal static void LeftClickElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.Click(element);
            actions.Perform();
        }

        internal static void DoubleClickElement(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }
    }
}
