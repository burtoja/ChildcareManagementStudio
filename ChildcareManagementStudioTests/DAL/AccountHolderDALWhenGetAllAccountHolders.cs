using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetAllAccountHolders method of the AccountHolderDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class AccountHolderDALWhenGetAllAccountHolders
    {
        [TestMethod]
        public void ShouldReturnAllEmployees()
        {
            AccountHolderDAL accountHolderDAL = new AccountHolderDAL();

            List<AccountHolder> accountHolders = accountHolderDAL.GetAllAccountHolders();
            Assert.AreEqual(4, accountHolders.Count);

            AccountHolder firstAccountHolder = accountHolders[3];
            Assert.AreEqual(101, firstAccountHolder.PersonId);
            Assert.AreEqual("Woodward", firstAccountHolder.LastName);
            Assert.AreEqual("Ryan", firstAccountHolder.FirstName);
            Assert.AreEqual(new DateTime(2020, 2, 14), firstAccountHolder.DateOfBirth);
            Assert.AreEqual("880-45-5899", firstAccountHolder.SocialSecurityNumber);
            Assert.AreEqual("M", firstAccountHolder.Gender);
            Assert.AreEqual("(613) 418-1082", firstAccountHolder.PhoneNumber);
            Assert.AreEqual("P.O. Box 156, 2014 Placerat. Av.", firstAccountHolder.AddressLine1);
            Assert.AreEqual("Bhilwara", firstAccountHolder.City);
            Assert.AreEqual("VA", firstAccountHolder.State);
            Assert.AreEqual("88249", firstAccountHolder.ZipCode);
            Assert.AreEqual(1, firstAccountHolder.AccountHolderId);

            AccountHolder secondAccountHolder = accountHolders[0];
            Assert.AreEqual(102, secondAccountHolder.PersonId);
            Assert.AreEqual("Holmes", secondAccountHolder.LastName);
            Assert.AreEqual("Ishmael", secondAccountHolder.FirstName);
            Assert.AreEqual(new DateTime(2014, 3, 1), secondAccountHolder.DateOfBirth);
            Assert.AreEqual("332-83-3496", secondAccountHolder.SocialSecurityNumber);
            Assert.AreEqual("F", secondAccountHolder.Gender);
            Assert.AreEqual("(140) 550-5520", secondAccountHolder.PhoneNumber);
            Assert.AreEqual("7460 Libero Av.", secondAccountHolder.AddressLine1);
            Assert.AreEqual("Apartment 691", secondAccountHolder.AddressLine2);
            Assert.AreEqual("Kohlu", secondAccountHolder.City);
            Assert.AreEqual("VA", secondAccountHolder.State);
            Assert.AreEqual("91990", secondAccountHolder.ZipCode);
            Assert.AreEqual(2, secondAccountHolder.AccountHolderId);
        }
    }
}