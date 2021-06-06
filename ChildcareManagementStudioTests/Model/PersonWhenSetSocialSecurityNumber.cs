using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests
{
    /// <summary>
    /// Class for testing the input validation for the SocialSecurityNumber property of the Person class.
    /// </summary>
    [TestClass]
    public class PersonWhenSetSocialSecurityNumber
    {
        private Person person;

        [TestInitialize]
        public void TestInitialize()
        {
            person = new Person();
        }

        [TestMethod]
        public void ShouldNotAllowBlankSocialSecurityNumber()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithoutDashes()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "123456789");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithTooFewDigitsInFirstSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "12-45-6789");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithTooManyDigitsInFirstSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "1234-45-6789");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithTooFewDigitsInSecondSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "123-4-6789");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithTooManyDigitsInSecondSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "123-456-6789");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithTooFewDigitsInThirdSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "123-45-678");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithTooManyDigitsInThirdSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "123-45-67890");
        }

        [TestMethod]
        public void ShouldNotAllowSocialSecurityNumberWithCharactersThatAreNotNumbers()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.SocialSecurityNumber = "O23-45-6789");
        }

        [TestMethod]
        public void ShouldSetWhenSocialSecurityNumberIsValid()
        {
            person.SocialSecurityNumber = "123-45-6789";
            Assert.AreEqual("123-45-6789", person.SocialSecurityNumber);
        }
    }
}