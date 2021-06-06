using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests
{
    /// <summary>
    /// Class for testing the input validation for the Gender property of the Person class.
    /// </summary>
    [TestClass]
    public class PersonWhenSetGender
    {
        private Person person;

        [TestInitialize]
        public void TestInitialize()
        {
            person = new Person();
        }

        [TestMethod]
        public void ShouldNotAllowBlankGender()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.Gender = "");
        }

        [TestMethod]
        public void ShouldNotAllowMultipleCharacters()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.Gender = "MF");
        }

        [TestMethod]
        public void ShouldNotAllowAnInvalidCharacter()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.Gender = "X");
        }

        [TestMethod]
        public void ShouldNotAllowLowercaseCharacters()
        {
            Assert.ThrowsException<System.ArgumentException>(() => person.Gender = "m");
        }

        [TestMethod]
        public void ShouldSetWhenGenderIsValid()
        {
            person.Gender = "M";
            Assert.AreEqual("M", person.Gender);
        }
    }
}