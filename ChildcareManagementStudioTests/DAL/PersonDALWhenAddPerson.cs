using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddPerson method of the PersonDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PersonDALWhenAddPerson
    {
        private PersonDAL personDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            personDAL = new PersonDAL();
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

            Assert.ThrowsException<System.ArgumentException>(() => personDAL.AddPerson(personToAdd));
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

            Assert.ThrowsException<System.ArgumentException>(() => personDAL.AddPerson(personToAdd));
        }

        [TestMethod]
        public void ShouldAddPersonAndSetPersonIdPropertyIfPropertiesAreValid()
        {
            Person personToAdd = new Person
            {
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

            Assert.AreEqual(default, personToAdd.PersonId);
            personDAL.AddPerson(personToAdd);
            Assert.AreNotEqual(default, personToAdd.PersonId);

            Person personFromDatabase = personDAL.GetPerson(personToAdd.PersonId);
            Assert.AreEqual("Duck", personFromDatabase.LastName);
            Assert.AreEqual("Donald", personFromDatabase.FirstName);
            Assert.AreEqual(new DateTime(1950, 1, 1), personFromDatabase.DateOfBirth);
            Assert.AreEqual("333-33-3333", personFromDatabase.SocialSecurityNumber);
            Assert.AreEqual("M", personFromDatabase.Gender);
            Assert.AreEqual("(333) 333-3333", personFromDatabase.PhoneNumber);
            Assert.AreEqual("7550 Maple Street", personFromDatabase.AddressLine1);
            Assert.AreEqual("Orlando", personFromDatabase.City);
            Assert.AreEqual("FL", personFromDatabase.State);
            Assert.AreEqual("32789", personFromDatabase.ZipCode);
        }
    }
}