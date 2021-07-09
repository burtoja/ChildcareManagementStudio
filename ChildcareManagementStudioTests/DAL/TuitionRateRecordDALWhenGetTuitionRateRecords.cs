using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetTuitionRateRecords method of the TuitionRateRecordDAL class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordDALWhenGetTuitionRateRecords
    {
        private TuitionRateRecordDAL tuitionRateRecordDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            tuitionRateRecordDAL = new TuitionRateRecordDAL();
        }

        [TestMethod]
        public void ShouldGetRecordsForStudent()
        {
            Student student = new Student()
            {
                StudentId = 1
            };

            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordDAL.GetTuitionRateRecords(student);
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

            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordDAL.GetTuitionRateRecords(accountHolder);
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