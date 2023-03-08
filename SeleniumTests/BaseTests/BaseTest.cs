using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

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
            Driver.TakeScreenShot();
            }

            Driver.QuitDriver();
        }
    }
}
