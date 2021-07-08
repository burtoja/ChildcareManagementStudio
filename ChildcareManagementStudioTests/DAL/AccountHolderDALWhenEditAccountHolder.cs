using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the EditAccountHolder method of the AccountHolderDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class AccountHolderDALWhenEditAccountHolder
    {
        private AccountHolderDAL accountHolderDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            accountHolderDAL = new AccountHolderDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfOriginalAccountHolderIsNull()
        {
            AccountHolder originalAccountHolder = null;

            AccountHolder revisedAccountHolder = new AccountHolder
            {
                PersonId = 102,
                AccountHolderId = 2,
                LastName = "Holmes",
                FirstName = "Ishmael",
                DateOfBirth = new DateTime(2014, 3, 1),
                SocialSecurityNumber = "332-83-3496",
                Gender = "F",
                PhoneNumber = "(140) 550-5520",
                AddressLine1 = "7460 Libero Av.",
                AddressLine2 = "Apartment 691",
                City = "Kohlu",
                State = "VA",
                ZipCode = "99999"
            };

            Assert.ThrowsException<System.ArgumentNullException>(() => accountHolderDAL.EditAccountHolder(originalAccountHolder, revisedAccountHolder));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfRevisedAccountHolderIsNull()
        {
            AccountHolder originalAccountHolder = new AccountHolder
            {
                PersonId = 102,
                AccountHolderId = 2,
                LastName = "Holmes",
                FirstName = "Ishmael",
                DateOfBirth = new DateTime(2014, 3, 1),
                SocialSecurityNumber = "332-83-3496",
                Gender = "F",
                PhoneNumber = "(140) 550-5520",
                AddressLine1 = "7460 Libero Av.",
                AddressLine2 = "Apartment 691",
                City = "Kohlu",
                State = "VA",
                ZipCode = "91990"
            };

            AccountHolder revisedAccountHolder = null;

            Assert.ThrowsException<System.ArgumentNullException>(() => accountHolderDAL.EditAccountHolder(originalAccountHolder, revisedAccountHolder));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfAccountHolderIdIsDifferent()
        {
            AccountHolder originalAccountHolder = new AccountHolder
            {
                PersonId = 102,
                AccountHolderId = 2,
                LastName = "Holmes",
                FirstName = "Ishmael",
                DateOfBirth = new DateTime(2014, 3, 1),
                SocialSecurityNumber = "332-83-3496",
                Gender = "F",
                PhoneNumber = "(140) 550-5520",
                AddressLine1 = "7460 Libero Av.",
                AddressLine2 = "Apartment 691",
                City = "Kohlu",
                State = "VA",
                ZipCode = "91990"
            };

            AccountHolder revisedAccountHolder = new AccountHolder
            {
                PersonId = 102,
                AccountHolderId = 3,
                LastName = "Holmes",
                FirstName = "Ishmael",
                DateOfBirth = new DateTime(2014, 3, 1),
                SocialSecurityNumber = "332-83-3496",
                Gender = "F",
                PhoneNumber = "(140) 550-5520",
                AddressLine1 = "7460 Libero Av.",
                AddressLine2 = "Apartment 691",
                City = "Kohlu",
                State = "VA",
                ZipCode = "99999"
            };

            Assert.ThrowsException<System.ArgumentException>(() => accountHolderDAL.EditAccountHolder(originalAccountHolder, revisedAccountHolder));
        }

        [TestMethod]
        public void ShouldUpdateDatabaseIfArgumentsAreValid()
        {
            AccountHolder originalAccountHolder = new AccountHolder
            {
                PersonId = 102,
                AccountHolderId = 2,
                LastName = "Holmes",
                FirstName = "Ishmael",
                DateOfBirth = new DateTime(2014, 3, 1),
                SocialSecurityNumber = "332-83-3496",
                Gender = "F",
                PhoneNumber = "(140) 550-5520",
                AddressLine1 = "7460 Libero Av.",
                AddressLine2 = "Apartment 691",
                City = "Kohlu",
                State = "VA",
                ZipCode = "91990"
            };

            AccountHolder revisedAccountHolder = new AccountHolder
            {
                PersonId = 102,
                AccountHolderId = 2,
                LastName = "Holmes",
                FirstName = "Ishmael",
                DateOfBirth = new DateTime(2014, 3, 1),
                SocialSecurityNumber = "332-83-3496",
                Gender = "F",
                PhoneNumber = "(140) 550-5520",
                AddressLine1 = "7460 Libero Av.",
                AddressLine2 = "Apartment 691",
                City = "Kohlu",
                State = "VA",
                ZipCode = "99999"
            };

            accountHolderDAL.EditAccountHolder(originalAccountHolder, revisedAccountHolder);

            AccountHolder retrievedAccountHolder = accountHolderDAL.GetAllAccountHolders()[0];
            Assert.AreEqual("99999", retrievedAccountHolder.ZipCode);

            accountHolderDAL.EditAccountHolder(revisedAccountHolder, originalAccountHolder);    // this line is intended to undo the change made during the test
        }
    }
}