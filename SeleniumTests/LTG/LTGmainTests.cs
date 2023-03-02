using Framework;
using Framework.Pages.LTG;
using NUnit.Framework;

namespace SeleniumTests.LTG
{
    internal class LTGmainTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://ltglink.lt/");
        }
        [Test]
        public void CheckForTicketSearch()
        {

            string valueLeaveLocation = "Vilnius";
            string valueArrivalLocation = "Kaunas";

            LTGmain.CookieButtonClick();
            LTGmain.LeaveLocation(valueLeaveLocation);
            LTGmain.ArrivalLocation(valueArrivalLocation);
            LTGmain.DepartureDateButton1();
            LTGmain.DepartureDateButton2();
            LTGmain.ArrivalDateButton1();
            LTGmain.ArrivalDateButton2();
            LTGmain.PassengerButton();
            LTGmain.PassengerChooseButton();
            LTGmain.PassengerSubmitButton();
            LTGmain.SearchButton();
        }

        [TearDown]
        public void Teardown()
        {
            Driver.QuitDriver();
        }
    }

}
