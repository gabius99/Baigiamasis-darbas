﻿namespace Framework.Pages.LTG
{
    public class LTGaccount
    {
        public static void ClickConfirmButton()
        {
            Common.ClickElement(Locators.LTGaccount.ConfirmClick);
        }

        public static void PasswordInput(string valuePassword)
        {
            Common.SendKeys(Locators.LTGaccount.PasswordBox, valuePassword);
        }

        public static void ClickMyAccount()
        {
            Common.ClickElement(Locators.LTGaccount.MyAccountButton);
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
