using Framework;
using Framework.Pages.LTG;
using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.LTG
{
    internal class LTGaccountTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Driver.OpenUrl("https://ltglink.lt/");
        }

        [Test]
        public void SignInForm()
        {
            string valueUserName = "lahad98234@v2ssr.com";
            string valuePassword = "Tester.123";
            string expectedText = "Bilietai";

            LTGaccount.CookieButtonClick();
            LTGaccount.PressHamburegerButton();
            LTGaccount.PressSignInButton();
            LTGaccount.UserNameInput(valueUserName);
            LTGaccount.PasswordInput(valuePassword);
            LTGaccount.ClickConfirmButton();

            
            Assert.AreEqual(expectedText, LTGaccount.SignInResultOutput());
        }
    }
}
