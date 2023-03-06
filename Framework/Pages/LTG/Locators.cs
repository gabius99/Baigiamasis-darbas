using Microsoft.SqlServer.Server;

namespace Framework.Pages.LTG
{
    internal class Locators
    {
        internal static class LTGmain
        {
            internal static string cookieButton = "/html/body/div[2]/div/div[2]/button[1]";
            internal static string leaveLocation1 = "//*[@id=\"turnit-search-container\"]/div[1]/div/input";
            internal static string arrivalLocation1 = "//*[@id=\"turnit-search-container\"]/div[3]/div/input";
            internal static string departureButton1 = "//*[@id=\"turnit-search-container\"]/div[4]/div/button";
            internal static string departureButton2 = "//*[@id=\"tooltip-depart-date\"]//*[@class='DayPicker-Day' and text()='31']";
            internal static string arrivalButton1 = "//*[@id=\"turnit-search-container\"]/div[5]/div/button";
            internal static string arrivalButton2 = "//*[@id=\"tooltip-return-date\"]//*[@class='DayPicker-Day' and text()='31']";
            internal static string passengerButton = "//*[@id=\"turnit-search-container\"]/div[6]/div/button";
            internal static string choosePassengerTypeButton = "//*[@id=\"tooltip-fare-classes\"]/div/div[1]/div[1]/ul/li[2]/div[2]/button[2]";
            internal static string submitPassenger = "//*[@id=\"turnit-search\"]/div[1]/button[1]";
            internal static string clickSearch = "//*[@id=\"turnit-search-container\"]/button";
            internal static string leaveLocation2 = "//*[@id=\"stop-search-select-option-ticket-origin-3\"]/div";
            internal static string arrivalLocation2 = "//*[@id=\"stop-search-select-option-ticket-destination-0\"]/div";
            internal static string searchResultMessage = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[1]/div[1]/h1";
        }

        internal static class LTGaccount
        {
            internal static string cookieButton = "/html/body/div[2]/div/div[2]/button[1]";
            internal static string SignInButton = "/html/body/div[3]/div/div/div[2]/div/nav/a/button/span";
            internal static string UserNameBox = "//*[@id=\"username-input\"]";
            internal static string PasswordBox = "//*[@id=\"password-input\"]";
            internal static string ConfirmClick = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div/form/button";
            internal static string BurgerButton = "//*[@id=\"react-app\"]/div[1]/header/div/button";
            internal static string signInMessage = "//*[@id=\"react-app\"]//*[@class=\"title\" and text()='Bilietai']";
        }

        internal static class Journeys
        {
            internal static string CookieButton = "//*[@id=\"cookie_notice\"]/div[2]/button[1]/span";
            internal static string LeaveClass = "//*[@class='results']/li[1]/div[3]/button[1]";
            internal static string AddButton = "//*[@id=\"react-app\"]/div[2]/div/div[2]/div/button";
            internal static string ArrivalClass = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[2]/ul/li[4]/button[1]";
            internal static string ContinueSeats = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[2]/div/div[2]/div[2]/div[2]/button";
            internal static string ContinueTransport = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[2]/div/div[3]/button/span";
            internal static string ContinueCheckout = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[2]/div/div[2]/button";
            internal static string EmailBox = "//*[@id=\"Email-input\"]";
            internal static string NumberBox = "//*[@id=\"PhoneNumber\"]";
            internal static string CheckBoxButton = "//*[@id=\"terms\"]";
            internal static string ReserveSeatButton = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[2]/div[2]/div/section/div/div/div/button/span";
        }
    }
}
