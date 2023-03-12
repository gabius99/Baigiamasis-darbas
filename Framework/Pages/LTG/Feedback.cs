using System.Threading;

namespace Framework.Pages.LTG
{
    public class Feedback
    {
        public static void ClickCookieButton()
        {
            Common.ClickElement(Locators.Feedback.CookieButton);
        }

        public static void ClickFeedbackButton()
        {
            Common.ClickElement(Locators.Feedback.FeedbackButton);
        }

        public static void ClickFeedbackFormButton()
        {
            Common.ClickElement(Locators.Feedback.FeedbackFormButton);
        }

        public static void ClickInformationAndServices()
        {
            Common.ClickElement(Locators.Feedback.InfoButton);
        }

        public static void ClickSendButton()
        {
            Thread.Sleep(1000);
            Common.ScrollUntilElementIsClickable(Locators.Feedback.SendButton);
            Common.ClickElement(Locators.Feedback.SendButton);
        }

        public static void InputEmail(string valueEmail)
        {
            Common.SendKeys(Locators.Feedback.EmailBox, valueEmail);
        }

        public static void InputFeedback(string valueFeedback)
        {
            Common.SendKeys(Locators.Feedback.FeedbackBox, valueFeedback);
        }

        public static void InputFirstName(string valueFirstName)
        {
            Common.SendKeys(Locators.Feedback.FirstNameBox, valueFirstName);
        }

        public static void InputLastName(string valueLastName)
        {
            Common.SendKeys(Locators.Feedback.LastNameBox, valueLastName);
        }

        public static void InputPhoneNumber(string valuePhoneNumber)
        {
            Common.SendKeys(Locators.Feedback.PhoneNumberBox, valuePhoneNumber);
        }

        public static object OutputMessage()
        {
            Common.WaitForElementToBeEnabled(Locators.Feedback.OutPutMessageText);
            return Common.GetElementText(Locators.Feedback.OutPutMessageText);
        }

        public static void PressHamburegerButton()
        {
            Common.ClickElement(Locators.Feedback.BurgerButton);
        }
    }
}
