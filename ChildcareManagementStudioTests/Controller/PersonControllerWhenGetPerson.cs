using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetPerson method of the PersonController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PersonControllerWhenGetPerson
    {
        private PersonController personController;

        [TestInitialize]
        public void TestInitialize()
        {
            personController = new PersonController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPersonIdIsNegative()
        {
            int personId = -1;
            Assert.ThrowsException<System.ArgumentException>(() => personController.GetPerson(personId));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfTheSpecifiedPersonDoesNotExist()
        {
            int personId = 0;
            Assert.ThrowsException<System.ArgumentException>(() => personController.GetPerson(personId));
        }

        [TestMethod]
        public void ShouldReturnPersonObjectIfTheSpecifiedPersonExists()
        {
            int personId = 1;
            Person person = personController.GetPerson(personId);
            Assert.AreEqual(1, person.PersonId);
            Assert.AreEqual("Mouse", person.LastName);
            Assert.AreEqual("Mickey", person.FirstName);
            Assert.AreEqual(new DateTime(1930, 1, 1), person.DateOfBirth);
            Assert.AreEqual("111-11-1111", person.SocialSecurityNumber);
            Assert.AreEqual("M", person.Gender);
            Assert.AreEqual("(111) 111-1111", person.PhoneNumber);
            Assert.AreEqual("123 Clubhouse Lane", person.AddressLine1);
            Assert.AreEqual("Orlando", person.City);
            Assert.AreEqual("FL", person.State);
            Assert.AreEqual("32830", person.ZipCode);
        }
    }
}