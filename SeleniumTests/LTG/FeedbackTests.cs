using Framework.Pages.LTG;
using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.LTG
{
    internal class FeedbackTests : BaseTest
    {
        [Test]
        public void WriteAFeedback()
        {
            string valueFirstName = "Test";
            string valueLastName = "Tester";
            string valueEmail = "Test@email.com";
            string valuePhoneNumber = "847009528";
            string valueFeedback = "Test feedback";
            string expectedText = "Jūsų atsiliepimas išsiųstas!";

            Feedback.ClickCookieButton();
            Feedback.ClickInformationAndServices();
            Feedback.ClickFeedbackFormOption();
            Feedback.InputFirstName(valueFirstName);
            Feedback.InputLastName(valueLastName);
            Feedback.InputEmail(valueEmail);
            Feedback.InputPhoneNumber(valuePhoneNumber);
            Feedback.InputFeedback(valueFeedback);
            Feedback.ClickSendButton();

            Assert.AreEqual(expectedText, Feedback.OutputMessage());
        }
    }
}
