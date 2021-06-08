using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the EditPerson method of the PersonDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PersonDALWhenEditPerson
    {
        private PersonDAL personDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            personDAL = new PersonDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfOriginalPersonIsNull()
        {
            Person originalPerson = null;

            Person revisedPerson = new Person
            {
                PersonId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830"
            };

            Assert.ThrowsException<System.ArgumentNullException>(() => personDAL.EditPerson(originalPerson, revisedPerson));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfRevisedPersonIsNull()
        {
            Person originalPerson = new Person
            {
                PersonId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830"
            };

            Person revisedPerson = null;

            Assert.ThrowsException<System.ArgumentNullException>(() => personDAL.EditPerson(originalPerson, revisedPerson));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPersonIdIsDifferent()
        {
            Person originalPerson = new Person
            {
                PersonId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830"
            };

            Person revisedPerson = new Person
            {
                PersonId = 2,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830"
            };

            Assert.ThrowsException<System.ArgumentException>(() => personDAL.EditPerson(originalPerson, revisedPerson));
        }

        [TestMethod]
        public void ShouldUpdateDatabaseIfArgumentsAreValid()
        {
            Person originalPerson = new Person
            {
                PersonId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830"
            };

            Person revisedPerson = new Person
            {
                PersonId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830"
            };

            personDAL.EditPerson(originalPerson, revisedPerson);

            Person retrievedPerson = personDAL.GetPerson(originalPerson.PersonId);
            Assert.AreEqual("Lake Buena Vista", retrievedPerson.City);

            personDAL.EditPerson(revisedPerson, originalPerson);    // this line is intended to undo the change made during the test
        }
    }
}