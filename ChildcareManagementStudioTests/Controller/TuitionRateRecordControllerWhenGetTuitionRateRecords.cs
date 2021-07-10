using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetTuitionRateRecords method of the TuitionRateRecordController class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordControllerWhenGetTuitionRateRecords
    {
        private TuitionRateRecordController tuitionRateRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            tuitionRateRecordController = new TuitionRateRecordController();
        }

        [TestMethod]
        public void ShouldGetRecordsForStudent()
        {
            Student student = new Student()
            {
                StudentId = 1
            };

            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordController.GetTuitionRateRecords(student);
            TuitionRateRecord firstRecord = tuitionRateRecords[0];

            Assert.AreEqual(2, tuitionRateRecords.Count);
            Assert.AreEqual(1, firstRecord.Student.StudentId);
            Assert.AreEqual(new DateTime(2021, 6, 1), firstRecord.StartDate);
            Assert.AreEqual(new DateTime(2021, 6, 30), firstRecord.EndDate);
            Assert.AreEqual(30, firstRecord.DailyRate);
            Assert.AreEqual(1, firstRecord.AccountHolder.AccountHolderId);
        }

        [TestMethod]
        public void ShouldGetRecordsForAccountHolder()
        {
            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordController.GetTuitionRateRecords(accountHolder);
            TuitionRateRecord firstRecord = tuitionRateRecords[0];

            Assert.AreEqual(3, tuitionRateRecords.Count);
            Assert.AreEqual(1, firstRecord.Student.StudentId);
            Assert.AreEqual(new DateTime(2021, 6, 1), firstRecord.StartDate);
            Assert.AreEqual(new DateTime(2021, 6, 30), firstRecord.EndDate);
            Assert.AreEqual(30, firstRecord.DailyRate);
            Assert.AreEqual(1, firstRecord.AccountHolder.AccountHolderId);
        }
    }
}