using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Execution;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://ltglink.lt/");
        }
        [TearDown]
        public void Teardown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string fileName = Driver.TakeScreenShot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(fileName);
            }

            Driver.QuitDriver();
        }
    }
}
