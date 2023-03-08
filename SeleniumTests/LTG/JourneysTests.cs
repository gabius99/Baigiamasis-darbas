using Framework;
using Framework.Pages.LTG;
using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.LTG
{
    internal class JourneysTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://ltglink.lt/");
        }

        [Test]
        public void ReservingSeatsDemo()
        {
            string valueEmail = "lahad98234@v2ssr.com";
            string valueNumber = "68462879";
            string expectedResults = "MOKĖTI IŠ BANKO SĄSKAITOS";

            LTGmain.CookieButtonClick();
            LTGmain.LeaveLocation1();
            LTGmain.LeaveLocation2();
            LTGmain.ArrivalLocation1();
            LTGmain.ArrivalLocation2();
            LTGmain.DepartureDateButton1();
            LTGmain.DepartureDateButton2();
            LTGmain.ArrivalDateButton1();
            LTGmain.ArrivalDateButton2();
            LTGmain.PassengerButton();
            LTGmain.PassengerChooseButton();
            LTGmain.PassengerSubmitButton();
            LTGmain.SearchButton();

            Journeys.LeavingRouteAndClass();
            Journeys.ClickAddToBooking();
            Journeys.ArrivalRouteAndClass();
            Journeys.ClickAddToBooking();
            Journeys.ClickContinueForSeatSelection();
            Journeys.ClickContinueForPublicTransport();
            Journeys.ClickContinueToCheckout();
            Journeys.InputEmail(valueEmail);
            Journeys.InputPhoneNumber(valueNumber);
            Journeys.ClickOnCheckBox();
            Journeys.ClickReserveYourSeat();

            Assert.AreEqual(expectedResults, Journeys.PaymentPageTitle());
        }
    }
}
