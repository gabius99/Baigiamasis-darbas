using System;

namespace Framework.Pages.LTG
{
    public class Journeys
    {
        public static void ArrivalRouteAndClass()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.ArrivalClass);
            Common.ScrollUntilElementIsClickable(Locators.Journeys.ArrivalClass);
            Common.ClickElement(Locators.Journeys.ArrivalClass);
        }

        public static void ClickAddToBooking()
        {
            Common.ClickElement(Locators.Journeys.AddButton);
        }

        public static void ClickContinueForPublicTransport()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.ContinueTransport);
            Common.ScrollUntilElementIsClickable(Locators.Journeys.ContinueTransport);

        }

        public static void ClickContinueForSeatSelection()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.ContinueSeats);
            Common.ClickElement(Locators.Journeys.ContinueSeats);
        }

        public static void ClickContinueToCheckout()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.ContinueCheckout);
            Common.ScrollUntilElementIsClickable(Locators.Journeys.ContinueCheckout);
        }

        public static void ClickCookieButton()
        {
            Common.ClickElement(Locators.Journeys.CookieButton);
        }

        public static void ClickOnCheckBox()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.CheckBoxButton);
            Common.LeftClickElement(Locators.Journeys.CheckBoxButton);
        }

        public static void ClickReserveYourSeat()
        {
            Common.ClickElement(Locators.Journeys.ReserveSeatButton);
        }

        public static void InputEmail(string valueEmail)
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.EmailBox);
            Common.ScrollUntilElementIsClickable(Locators.Journeys.EmailBox);
            Common.SendKeys(Locators.Journeys.EmailBox, valueEmail);
        }

        public static void InputPhoneNumber(string valueNumber)
        {
            Common.SendKeys(Locators.Journeys.NumberBox, valueNumber);
        }

        public static void LeavingRouteAndClass()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.LeaveClass);
            Common.ClickElement(Locators.Journeys.LeaveClass);
        }

        public static object PaymentPageTitle()
        {
            Common.WaitForElementToBeEnabled(Locators.Journeys.TitleText);
            return Common.GetElementText(Locators.Journeys.TitleText);
        }
    }
}
