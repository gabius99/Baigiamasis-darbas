namespace Framework.Pages.LTG
{
    public class Feedback
    {
        public static void ClickCookieButton()
        {
            Common.ClickElement(Locators.Feedback.CookieButton);
            Common.WaitForElementToBeInvisible(Locators.Feedback.CookiesModal);
            // Need this for stability
            // For some reason we need to wait a bit after closing the cookies modal
            // Otherwise header menu does not properly open
            // There might be some script running after cookies are closed
            System.Threading.Thread.Sleep(500);
        }

        public static void ClickFeedbackFormOption()
        {
            Common.WaitForElementToBeClickable(Locators.Feedback.FeedbackFormMenuOption);
            Common.ClickElement(Locators.Feedback.FeedbackFormMenuOption);
        }

        public static void ClickInformationAndServices()
        {
            Common.WaitForElementToBeClickable(Locators.Feedback.ServicesAndInformationMenu);
            Common.ClickElement(Locators.Feedback.ServicesAndInformationMenu);
            // Wait for menu to fully expand
            Common.WaitForElementToBeVisisble("//*[@class='menu-popdown anim-enter-done']");
        }

        public static void ClickSendButton()
        {
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
    }
}
