using OpenQA.Selenium;
using System;

namespace Framework.Pages.LTG
{
    public class LTGmain
    {
        public static void ArrivalDateButton1()
        {
            string locator = "//*[@id=\"turnit-search-container\"]/div[5]/button[1]";
            Common.ClickElement(locator);
        }

        public static void ArrivalDateButton2()
        {
            string locator = "/html/body/div[3]/div/div[2]/div/div/div/div[2]/div/div[2]/div[5]/div[5]";
            Common.ClickElement(locator);
        }

        public static void ArrivalLocation(string valueArrivalLocation)
        {
            string locator = "//*[@id=\"turnit-search-container\"]/div[3]/div/input";
            Common.SendKeys(locator, valueArrivalLocation);
        }

        public static void CookieButtonClick()
        {
            string locator = "/html/body/div[2]/div/div[2]/button[1]";
            Common.ClickElement(locator);
        }

        public static void DepartureDateButton1()
        {
            string locator = "//*[@id=\"turnit-search-container\"]/div[4]/button";
            Common.ClickElement(locator);
        }

        public static void DepartureDateButton2()
        {
            string locator = "/html/body/div[3]/div/div[2]/div/div/div/div[2]/div/div[2]/div[5]/div[1]";
            Common.ClickElement(locator);
        }

        public static void LeaveLocation(string valueLeaveLocation)
        {
            string locator = "//*[@id=\"turnit-search-container\"]/div[1]/div/input";
            Common.SendKeys(locator, valueLeaveLocation);
        }

        public static void PassengerButton()
        {
            string locator = "//*[@id=\"turnit-search-container\"]/div[6]/button";
            Common.ClickElement(locator);
        }

        public static void PassengerChooseButton()
        {
            string locator = "/html/body/div[3]/div/div[2]/div/div/div[1]/div[1]/ul/li[2]/div[2]/button[2]";
            Common.ClickElement(locator);
        }

        public static void PassengerSubmitButton()
        {
            string locator = "/html/body/div[3]/div/div[2]/button";
            Common.ClickElement(locator);
        }

        public static void SearchButton()
        {
            string locator = "//*[@id=\"turnit-search-container\"]/button";
            Common.ClickElement(locator);
        }
    }
}
