using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetSalaryRecords method of the SalaryDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class CredentialDALWhenGetSalaryRecords
    {
        private SalaryDAL salaryDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            salaryDAL = new SalaryDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfEmployeeIdIsNegative()
        {
            int employeeId = -1;
            Assert.ThrowsException<System.ArgumentException>(() => salaryDAL.GetSalaryRecords(employeeId));
        }

        [TestMethod]
        public void ShouldReturnEmptyListIfRecordsDoNotExist()
        {
            int employeeId = 0;
            List<SalaryRecord> salaryRecords = salaryDAL.GetSalaryRecords(employeeId);
            Assert.AreEqual(0, salaryRecords.Count);
        }

        [TestMethod]
        public void ShouldReturnRecordsIfTheyExist()
        {
            int employeeId = 1;
            List<SalaryRecord> salaryRecords = salaryDAL.GetSalaryRecords(employeeId);
            Assert.AreEqual(1, salaryRecords.Count);
            Assert.AreEqual(new DateTime(2021, 6, 5), salaryRecords[0].EffectiveDate);
            Assert.AreEqual(10.00, salaryRecords[0].Rate);
        }
    }
}