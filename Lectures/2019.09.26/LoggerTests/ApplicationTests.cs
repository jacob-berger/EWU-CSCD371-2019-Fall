using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cscd371.UnitTestingStuff.Tests
{
    [TestClass]
    public class ApplicationTests
    {
        [TestMethod]
        public void Login_GivenValidUserNameAndPassword_Success()
        {
            Application application = new Application();

            bool isSuccess = application.Login("inigo", "montoya");

            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Login_GivenDifferentValidUserNameAndPassword_Success()
        {
            Application application = new Application();

            bool isSuccess = application.Login("princess", "muttercup");

            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Login_GivenInvalidCredentials_ReturnsFalse()
        {
            Application application = new Application();

            bool isSuccess = application.Login("inigo", "badPassword");

            Assert.IsFalse(isSuccess);
        }

        [TestMethod]
        public void Login_GivenNullPassword_ReturnsFalse()
        {
            Application application = new Application();
#nullable disable
            bool isSuccess = application.Login("inigo", null);
#nullable restore
            Assert.IsFalse(isSuccess);
        }
    }
}
