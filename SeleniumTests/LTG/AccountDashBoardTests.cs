using Framework.Pages.LTG;
using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.LTG
{
    internal class AccountDashBoardTests : BaseTestSingleSession
    {
        [Test, Order(1)]
        public void SignInForm()
        {
            string valueUserName = "lahad98234@v2ssr.com";
            string valuePassword = "Tester.123";
            string expectedText = "Bilietai";

            LTGaccount.PressHamburegerButton();
            LTGaccount.PressSignInButton();
            LTGaccount.UserNameInput(valueUserName);
            LTGaccount.PasswordInput(valuePassword);
            LTGaccount.ClickConfirmButton();

            Assert.AreEqual(expectedText, LTGaccount.SignInResultOutput());
        }

        [Test, Order(2)]
        public void EditingPhoneNumberToValidAndInvalidForm()
        {
            string valueValidPhoneNumber = "68416087";
            string valueInvalidPhoneNumber = "Invalid";
            string expectedText = "Telefono numeryje galimi tik skaičiai, tarpai ir - arba + simboliai.";

            AccountDashBoard.ClickAccountDetails();
            AccountDashBoard.ClickEditDetails();
            AccountDashBoard.InputValidPhoneNumber(valueValidPhoneNumber);
            AccountDashBoard.ClickSaveButton();;

            AccountDashBoard.ClickEditDetails();
            AccountDashBoard.InputValidPhoneNumber(valueInvalidPhoneNumber);
            AccountDashBoard.ClickSaveButton();

            Assert.AreEqual(expectedText, AccountDashBoard.UnsuccessfulUpdate());
        }
    }
}
