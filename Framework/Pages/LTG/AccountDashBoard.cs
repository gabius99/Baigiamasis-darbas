using System;
using System.Threading;

namespace Framework.Pages.LTG
{
    public class AccountDashBoard
    {
        public static void ClickAccountDetails()
        {
            Common.WaitForElementToBeEnabled(Locators.AccountDashBoard.ButtonAccountDetails);
            Common.ClickElement(Locators.AccountDashBoard.ButtonAccountDetails);
        }

        public static void ClickEditDetails()
        {
            Thread.Sleep(2000);
            Common.ScrollUntilElementIsClickable(Locators.AccountDashBoard.ButtonEditDetails);
        }

        public static void ClickSaveButton()
        {
            Common.ScrollUntilElementIsClickable(Locators.AccountDashBoard.ButtonSave);
        }

        public static void InputValidPhoneNumber(string valueValidPhoneNumber)
        {
            Common.WaitForElementToBeEnabled(Locators.AccountDashBoard.PhoneNumber);
            Common.DoubleClickElement(Locators.AccountDashBoard.PhoneNumber);
            Common.SendKeys(Locators.AccountDashBoard.PhoneNumber, valueValidPhoneNumber);
        }

        public static object UnsuccessfulUpdate()
        {
            return Common.GetElementText(Locators.AccountDashBoard.UnsuccessNotification);
        }
    }
}
