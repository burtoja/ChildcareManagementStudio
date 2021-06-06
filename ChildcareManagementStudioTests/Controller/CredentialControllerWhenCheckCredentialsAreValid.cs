using ChildcareManagementStudio.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the CredentialsAreValid method of the CredentialController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class CredentialControllerWhenCheckCredentialsAreValid
    {
        private CredentialController credentialController;

        [TestInitialize]
        public void TestInitialize()
        {
            credentialController = new CredentialController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfUsernameIsBlank()
        {
            string username = "";
            string password = "33c614ca3cf78827a85dc0d8d06bfcf8c4d923fd23c813acd50b80ed2d4d4fb3";
            Assert.ThrowsException<System.ArgumentNullException>(() => credentialController.CredentialsAreValid(username, password));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPasswordIsBlank()
        {
            string username = "mmouse";
            string password = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";
            Assert.ThrowsException<System.ArgumentNullException>(() => credentialController.CredentialsAreValid(username, password));
        }

        [TestMethod]
        public void ShouldReturnTrueWhenCredentialsAreValid()
        {
            string username = "mmouse";
            string password = "33c614ca3cf78827a85dc0d8d06bfcf8c4d923fd23c813acd50b80ed2d4d4fb3";
            Assert.AreEqual(true, credentialController.CredentialsAreValid(username, password));
        }

        [TestMethod]
        public void ShouldReturnFalseWhenCredentialsAreInvalid()
        {
            string username = "mmouse";
            string password = "mouse";
            Assert.AreEqual(false, credentialController.CredentialsAreValid(username, password));
        }
    }
}