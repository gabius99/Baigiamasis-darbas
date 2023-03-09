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
            internal static string LeaveClass = "//*[@class='results']/li[1]/button[1]";
            internal static string AddButton = "//*[@class='result-footer']//button";
            internal static string ArrivalClass = "//*[@class='results']/li[8]/button[2]";
            internal static string ContinueSeats = "//*[@class='continue-to-checkout']/button";
            internal static string ContinueTransport = "//*[@class='view view--public-transport-ticket']//button[1]";
            internal static string ContinueCheckout = "//*[@class='continue-to-checkout']/button[1]";
            internal static string EmailBox = "//*[@id=\"Email-input\"]";
            internal static string NumberBox = "//*[@id=\"PhoneNumber\"]";
            internal static string CheckBoxButton = "//*[@id=\"terms\"]";
            internal static string ReserveSeatButton = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div[2]/div[2]/div/section/div/div/div/button/span";
            internal static string TitleText = "/html/body/div/main/div[2]/div/div[2]/div/header/div[1]/div[1]/div[1]/div[1]";
        }

        internal static class Feedback
        {
            internal static string CookieButton = "/html/body/div[2]/div/div[2]/button[1]";
            internal static string BurgerButton = "//*[@id=\"react-app\"]/div[1]/header/div/button";
            internal static string InfoButton = "//*[@class='_content']//button[2]";
            internal static string FeedbackButton = "//*[@class='menu-mobile-popup-content']/li[8]/div[1]";
            internal static string FeedbackFormButton = "/html/body/div[12]/div/div/div[2]/ul/li[1]/a";
            internal static string FirstNameBox = "//*[@class='inputs-wrapper']/div[1]//input";
            internal static string LastNameBox = "//*[@class='inputs-wrapper']/div[2]//input";
            internal static string EmailBox = "//*[@class='inputs-wrapper']/div[3]//input";
            internal static string PhoneNumberBox = "//*[@class='inputs-wrapper']/div[4]//input";
            internal static string FeedbackBox = "//textarea";
            internal static string SendButton = "//button[text()='Siųsti']";
            internal static string OutPutMessageText = "//*[@class='max-width ']//*[@class='title']";
        }

        internal static class AccountDashBoard
        {
            internal static string ButtonAccountDetails = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div/div[1]/nav/ul/li[5]";
            internal static string ButtonEditDetails = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div/div[2]/div/div[2]/ul/li[1]"; 
            internal static string PhoneNumber = "//*[@id=\"PhoneNumber-0\"]";
            internal static string ButtonSave = "//*[@class='button-container']/button";
            internal static string Loader = "//*[@class='loader-container overlay-loader-container']";
            internal static string UnsuccessNotification = "//*[@id=\"react-app\"]/div[2]/div/main/div[2]/div/div[2]/div/div[2]/div[2]/form/div[1]/div[4]/div[2]/div";
        }
    }
}
