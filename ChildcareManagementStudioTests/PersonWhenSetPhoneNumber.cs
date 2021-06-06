using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests
{
    /// <summary>
    /// Class for testing the input validation for the PhoneNumber property of the Person class.
    /// </summary>
    [TestClass]
    public class PersonWhenSetPhoneNumber
    {
        private Person person;

        [TestInitialize]
        public void TestInitialize()
        {
            person = new Person();
        }

        [TestMethod]
        public void ShouldNotAllowBlankPhoneNumber()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithoutParenthesis()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "123-456-7890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithoutSpace()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123)456-7890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithoutDash()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123) 4567890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithTooFewDigitsInFirstSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(12) 456-7890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithTooManyDigitsInFirstSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(1234) 456-7890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithTooFewDigitsInSecondSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123) 45-7890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithTooManyDigitsInSecondSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123) 4567-7890");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithTooFewDigitsInThirdSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123) 456-789");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithTooManyDigitsInThirdSection()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123) 456-78901");
        }

        [TestMethod]
        public void ShouldNotAllowPhoneNumberWithCharactersThatAreNotNumbers()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.PhoneNumber = "(123) 456-789O");
        }

        [TestMethod]
        public void ShouldSetWhenPhoneNumberIsValid()
        {
            person.PhoneNumber = "(123) 456-7890";
            Assert.AreEqual("(123) 456-7890", person.PhoneNumber);
        }
    }
}