using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddAccountHolder method of the AccountHolderDAL class.
    /// </summary>
    [TestClass]
    public class AccountHolderDALWhenAddAccountHolder
    {
        private AccountHolderDAL accountHolderDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            accountHolderDAL = new AccountHolderDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfAccountHolderAlreadyHasAccountHolderId()
        {
            AccountHolder accountHolderToAdd = new AccountHolder
            {
                AccountHolderId = 3,
                LastName = "Lightyear",
                FirstName = "Buzz",
                DateOfBirth = new DateTime(1990, 6, 1),
                SocialSecurityNumber = "915-73-6455",
                Gender = "M",
                PhoneNumber = "(444) 444-4444",
                AddressLine1 = "123 Space St.",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.ThrowsException<System.ArgumentException>(() => accountHolderDAL.AddAccountHolder(accountHolderToAdd));
        }

        [TestMethod]
        public void ShouldAddAccountHolderAndSetAccountHolderIdPropertyIfPropertiesAreValid()
        {
            AccountHolder accountHolderToAdd = new AccountHolder
            {
                LastName = "Lightyear",
                FirstName = "Buzz",
                DateOfBirth = new DateTime(1990, 6, 1),
                SocialSecurityNumber = "915-73-6455",
                Gender = "M",
                PhoneNumber = "(444) 444-4444",
                AddressLine1 = "123 Space St.",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.AreEqual(default, accountHolderToAdd.AccountHolderId);
            accountHolderDAL.AddAccountHolder(accountHolderToAdd);
            Assert.AreNotEqual(default, accountHolderToAdd.AccountHolderId);

            AccountHolder accountHolderFromDatabase = accountHolderDAL.GetAllAccountHolders()[1];
            Assert.AreEqual("Lightyear", accountHolderFromDatabase.LastName);
            Assert.AreEqual("Buzz", accountHolderFromDatabase.FirstName);
            Assert.AreEqual(new DateTime(1990, 6, 1), accountHolderFromDatabase.DateOfBirth);
            Assert.AreEqual("915-73-6455", accountHolderFromDatabase.SocialSecurityNumber);
            Assert.AreEqual("M", accountHolderFromDatabase.Gender);
            Assert.AreEqual("(444) 444-4444", accountHolderFromDatabase.PhoneNumber);
            Assert.AreEqual("123 Space St.", accountHolderFromDatabase.AddressLine1);
            Assert.AreEqual("Orlando", accountHolderFromDatabase.City);
            Assert.AreEqual("FL", accountHolderFromDatabase.State);
            Assert.AreEqual("32789", accountHolderFromDatabase.ZipCode);
        }
    }
}