using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddTuitionRateRecord method of the TuitionRateRecordDAL class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordDALWhenAddTuitionRateRecord
    {
        [TestMethod]
        public void ShouldAddTuitionRateRecord()
        {
            TuitionRateRecordDAL tuitionRateRecordDAL = new TuitionRateRecordDAL();

            Student student = new Student()
            {
                StudentId = 5
            };

            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            DateTime startDate = new DateTime(2021, 7, 1);

            double dailyRate = 35;

            TuitionRateRecord tuitionRateRecord = new TuitionRateRecord()
            {
                Student = student,
                AccountHolder = accountHolder,
                StartDate = startDate,
                DailyRate = dailyRate
            };

            tuitionRateRecordDAL.AddTuitionRateRecord(tuitionRateRecord);

            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordDAL.GetAllTuitionRateRecords();
            TuitionRateRecord addedTuitionRateRecordFromDatabase = tuitionRateRecords[5];

            Assert.AreEqual(6, tuitionRateRecords.Count);
            Assert.AreEqual(tuitionRateRecord.Student.StudentId, addedTuitionRateRecordFromDatabase.Student.StudentId);
            Assert.AreEqual(tuitionRateRecord.AccountHolder.AccountHolderId, addedTuitionRateRecordFromDatabase.AccountHolder.AccountHolderId);
            Assert.AreEqual(tuitionRateRecord.StartDate, addedTuitionRateRecordFromDatabase.StartDate);
            Assert.AreEqual(tuitionRateRecord.DailyRate, addedTuitionRateRecordFromDatabase.DailyRate);
        }
    }
}