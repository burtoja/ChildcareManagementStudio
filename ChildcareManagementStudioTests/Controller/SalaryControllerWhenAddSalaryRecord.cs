using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddSalaryRecord method of the SalaryController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class SalaryControllerWhenAddSalaryRecord
    {
        private SalaryController salaryController;

        [TestInitialize]
        public void TestInitialize()
        {
            salaryController = new SalaryController();
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
            Assert.ThrowsException<System.ArgumentException>(() => salaryController.AddSalaryRecord(employeeId, salaryRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfSalaryRecordIsNull()
        {
            int employeeId = 1;
            SalaryRecord salaryRecord = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => salaryController.AddSalaryRecord(employeeId, salaryRecord));
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
            salaryController.AddSalaryRecord(employeeId, salaryRecord);
            List<SalaryRecord> salaryRecords = salaryController.GetSalaryRecords(employeeId);
            Assert.AreEqual(2, salaryRecords.Count);
            Assert.AreEqual(new DateTime(2022, 1, 1), salaryRecords[1].EffectiveDate);
            Assert.AreEqual(12, salaryRecords[1].Rate);
            salaryController.DeleteSalaryRecord(employeeId, salaryRecord);
        }
    }
}