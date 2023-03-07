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
            Driver.OpenUrl("https://bilietas.ltglink.lt/journeys?oStop=17&dStop=16&oDate=2023-03-31&fareClasses=BONUS_SCHEME_GROUP.ADULT,1&dDate=2023-03-31");
        }

        [Test]
        public void ReservingSeatsDemo()
        {
            string valueEmail = "lahad98234@v2ssr.com";
            string valueNumber = "68462879";

            Journeys.ClickCookieButton();
            Journeys.LeavingRouteAndClass();
            Journeys.ClickAddToBooking();
            Journeys.ArrivalRouteAndClass();
            Journeys.ClickAddToBooking();
            Journeys.ClickContinueForSeatSelection();
            //Journeys.ClickContinueForPublicTransport(); // ties čia fail'ina. OpenQA.Selenium.StaleElementReferenceException : stale element reference: element is not attached to the page document
            //Journeys.ClickContinueToCheckout();
            //Journeys.InputEmail(valueEmail);
            //Journeys.InputPhoneNumber(valueNumber);
            //Journeys.ClickOnCheckBox();
            //Journeys.ClickReserveYourSeat();
        }
    }
}
