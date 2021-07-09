using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAccountHolder method of the AccountHolderController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class AccountHolderControllerWhenGetAccountHolder
    {
        [TestMethod]
        public void ShouldReturnAccountHolder()
        {
            AccountHolderController accountHolderController = new AccountHolderController();
            AccountHolder accountHolder = accountHolderController.GetAccountHolder(1);

            Assert.AreEqual(101, accountHolder.PersonId);
            Assert.AreEqual("Woodward", accountHolder.LastName);
            Assert.AreEqual("Ryan", accountHolder.FirstName);
            Assert.AreEqual(new DateTime(2020, 2, 14), accountHolder.DateOfBirth);
            Assert.AreEqual("880-45-5899", accountHolder.SocialSecurityNumber);
            Assert.AreEqual("M", accountHolder.Gender);
            Assert.AreEqual("(613) 418-1082", accountHolder.PhoneNumber);
            Assert.AreEqual("P.O. Box 156, 2014 Placerat. Av.", accountHolder.AddressLine1);
            Assert.AreEqual("Bhilwara", accountHolder.City);
            Assert.AreEqual("VA", accountHolder.State);
            Assert.AreEqual("88249", accountHolder.ZipCode);
            Assert.AreEqual(1, accountHolder.AccountHolderId);
        }
    }
}