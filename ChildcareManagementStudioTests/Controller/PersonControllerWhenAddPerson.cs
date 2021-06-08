using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddPerson method of the PersonController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PersonControllerWhenAddPerson
    {
        private PersonController personController;

        [TestInitialize]
        public void TestInitialize()
        {
            personController = new PersonController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPersonIsMissingMandatoryProperty()
        {
            Person personToAdd = new Person
            {
                FirstName = "Donald",
                DateOfBirth = new DateTime(1950, 1, 1),
                SocialSecurityNumber = "333-33-3333",
                Gender = "M",
                PhoneNumber = "(333) 333-3333",
                AddressLine1 = "7550 Maple Street",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.ThrowsException<System.ArgumentException>(() => personController.AddPerson(personToAdd));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPersonAlreadyHasPersonId()
        {
            Person personToAdd = new Person
            {
                PersonId = 3,
                LastName = "Duck",
                FirstName = "Donald",
                DateOfBirth = new DateTime(1950, 1, 1),
                SocialSecurityNumber = "333-33-3333",
                Gender = "M",
                PhoneNumber = "(333) 333-3333",
                AddressLine1 = "7550 Maple Street",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.ThrowsException<System.ArgumentException>(() => personController.AddPerson(personToAdd));
        }

        [TestMethod]
        public void ShouldAddPersonAndSetPersonIdPropertyIfPropertiesAreValid()
        {
            Person personToAdd = new Person
            {
                LastName = "Duck",
                FirstName = "Donald",
                DateOfBirth = new DateTime(1950, 1, 1),
                SocialSecurityNumber = "444-44-4444",
                Gender = "M",
                PhoneNumber = "(333) 333-3333",
                AddressLine1 = "7550 Maple Street",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.AreEqual(default, personToAdd.PersonId);
            personController.AddPerson(personToAdd);
            Assert.AreNotEqual(default, personToAdd.PersonId);

            Person personFromDatabase = personController.GetPerson(personToAdd.PersonId);
            Assert.AreEqual("Duck", personFromDatabase.LastName);
            Assert.AreEqual("Donald", personFromDatabase.FirstName);
            Assert.AreEqual(new DateTime(1950, 1, 1), personFromDatabase.DateOfBirth);
            Assert.AreEqual("444-44-4444", personFromDatabase.SocialSecurityNumber);
            Assert.AreEqual("M", personFromDatabase.Gender);
            Assert.AreEqual("(333) 333-3333", personFromDatabase.PhoneNumber);
            Assert.AreEqual("7550 Maple Street", personFromDatabase.AddressLine1);
            Assert.AreEqual("Orlando", personFromDatabase.City);
            Assert.AreEqual("FL", personFromDatabase.State);
            Assert.AreEqual("32789", personFromDatabase.ZipCode);
        }
    }
}