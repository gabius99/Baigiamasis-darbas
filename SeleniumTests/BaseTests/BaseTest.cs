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
        }
        [TearDown]
        public void Teardown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenShot(TestContext.CurrentContext.Test.MethodName);
            }

            Driver.QuitDriver();
        }
    }
}
