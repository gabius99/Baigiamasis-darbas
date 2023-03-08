using Framework;
using Framework.Pages.LTG;
using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.LTG
{
    internal class LTGmainTests : BaseTest
    {
        [Test]
        public void CheckForTicketSearch()
        {
            string expectedText = "Paieškos rezultatai";

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

            Assert.AreEqual(expectedText, LTGmain.SearchResultsOutput());
        }
    }
}
