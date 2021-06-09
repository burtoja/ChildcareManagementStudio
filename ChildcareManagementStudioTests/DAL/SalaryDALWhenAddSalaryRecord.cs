using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddSalaryRecord method of the SalaryDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class SalaryDALWhenAddSalaryRecord
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
            SalaryRecord salaryRecord = new SalaryRecord
            {
                EffectiveDate = new DateTime(2022, 1, 1),
                Rate = 12
            };
            Assert.ThrowsException<System.ArgumentException>(() => salaryDAL.AddSalaryRecord(employeeId, salaryRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfSalaryRecordIsNull()
        {
            int employeeId = 1;
            SalaryRecord salaryRecord = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => salaryDAL.AddSalaryRecord(employeeId, salaryRecord));
        }

        [TestMethod]
        public void ShouldAddValidRecord()
        {
            int employeeId = 1;
            SalaryRecord salaryRecord = new SalaryRecord
            {
                EffectiveDate = new DateTime(2022, 1, 1),
                Rate = 12
            };
            salaryDAL.AddSalaryRecord(employeeId, salaryRecord);
            List<SalaryRecord> salaryRecords = salaryDAL.GetSalaryRecords(employeeId);
            Assert.AreEqual(2, salaryRecords.Count);
            Assert.AreEqual(new DateTime(2022, 1, 1), salaryRecords[1].EffectiveDate);
            Assert.AreEqual(12, salaryRecords[1].Rate);
            salaryDAL.DeleteSalaryRecord(employeeId, salaryRecord);
        }
    }
}