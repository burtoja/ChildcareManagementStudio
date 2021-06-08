using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the EditPerson method of the PersonController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PersonControllerWhenEditPerson
    {
        private PersonController personController;

        [TestInitialize]
        public void TestInitialize()
        {
            personController = new PersonController();
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

            Assert.ThrowsException<System.ArgumentNullException>(() => personController.EditPerson(originalPerson, revisedPerson));
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

            Assert.ThrowsException<System.ArgumentNullException>(() => personController.EditPerson(originalPerson, revisedPerson));
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

            Assert.ThrowsException<System.ArgumentException>(() => personController.EditPerson(originalPerson, revisedPerson));
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

            personController.EditPerson(originalPerson, revisedPerson);

            Person retrievedPerson = personController.GetPerson(originalPerson.PersonId);
            Assert.AreEqual("Lake Buena Vista", retrievedPerson.City);

            personController.EditPerson(revisedPerson, originalPerson);    // this line is intended to undo the change made during the test
        }
    }
}