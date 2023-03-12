namespace Framework.Pages.LTG
{
    public class LTGmain
    {
        public static void CloseCookies()
        {
            Common.ClickElement(Locators.LTGmain.cookiesAccept);
            Common.WaitForElementToBeInvisible(Locators.LTGmain.cookiesModal);
            // Need this for stability
            // For some reason we need to wait a bit after closing the cookies modal
            // Otherwise header menu does not properly open
            // There might be some script running after cookies are closed
            System.Threading.Thread.Sleep(500);
        }

        public static void ArrivalDateButton1()
        {
            Common.ClickElement(Locators.LTGmain.arrivalButton1);
        }

        public static void ArrivalDateButton2()
        {
            Common.ClickElement(Locators.LTGmain.arrivalButton2);
        }

        public static void ArrivalLocation1()
        {
            Common.ClickElement(Locators.LTGmain.arrivalLocation1);
        }

        public static void ArrivalLocation2()
        {
            Common.ClickElement(Locators.LTGmain.arrivalLocation2);
        }

        public static void DepartureDateButton1()
        {
            Common.ClickElement(Locators.LTGmain.departureButton1);
        }

        public static void DepartureDateButton2()
        {
            Common.ClickElement(Locators.LTGmain.departureButton2);
        }

        public static void LeaveLocation1()
        {
            Common.ClickElement(Locators.LTGmain.leaveLocation1);
        }

        public static void LeaveLocation2()
        {
            Common.ClickElement(Locators.LTGmain.leaveLocation2);
        }

        public static void PassengerButton()
        {
            Common.ClickElement(Locators.LTGmain.passengerButton);
        }

        public static void PassengerChooseButton()
        {
            Common.ClickElement(Locators.LTGmain.choosePassengerTypeButton);
        }

        public static void PassengerSubmitButton()
        {
            Common.ClickElement(Locators.LTGmain.submitPassenger);
        }

        public static void SearchButton()
        {
            Common.ClickElement(Locators.LTGmain.clickSearch);
        }

        public static string SearchResultsOutput()
        {
            return Common.GetElementText(Locators.LTGmain.searchResultMessage);
        }
    }
}
