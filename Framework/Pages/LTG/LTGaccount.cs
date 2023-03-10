using System;
using System.Threading;

namespace Framework.Pages.LTG
{
    public class LTGaccount
    {
        public static void ClickConfirmButton()
        {
            Common.ClickElement(Locators.LTGaccount.ConfirmClick);
        }

        public static void CookieButtonClick()
        {
            Common.ClickElement(Locators.LTGaccount.cookieButton);
        }

        public static void PasswordInput(string valuePassword)
        {
            Common.SendKeys(Locators.LTGaccount.PasswordBox, valuePassword);
        }

        public static void PressHamburegerButton()
        {
            Common.ClickElement(Locators.LTGaccount.BurgerButton);
        }

        public static void PressSignInButton()
        {
            Thread.Sleep(2000);
            Common.ClickElement(Locators.LTGaccount.SignInButton);
        }

        public static string SignInResultOutput()
        {
            Common.WaitForElementToBeEnabled(Locators.LTGaccount.signInMessage);
            return Common.GetElementText(Locators.LTGaccount.signInMessage);
        }

        public static void UserNameInput(string valueUserName)
        {
            Common.WaitForElementToBeEnabled(Locators.LTGaccount.UserNameBox);
            Common.SendKeys(Locators.LTGaccount.UserNameBox, valueUserName);
        }
    }
}
