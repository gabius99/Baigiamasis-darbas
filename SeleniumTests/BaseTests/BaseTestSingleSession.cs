using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace SeleniumTests.BaseTests
{
    internal class BaseTestSingleSession
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://ltglink.lt/");
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string fileName = Driver.TakeScreenShot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(fileName);
            }

            //Driver.QuitDriver();
        }
    }
}
