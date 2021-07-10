using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddTuitionRateRecord method of the TuitionRateRecordController class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordControllerWhenAddTuitionRateRecord
    {
        [TestMethod]
        public void ShouldAddTuitionRateRecord()
        {
            TuitionRateRecordController tuitionRateRecordController = new TuitionRateRecordController();

            Student student = new Student()
            {
                StudentId = 1
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

            tuitionRateRecordController.AddTuitionRateRecord(tuitionRateRecord);

            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordController.GetAllTuitionRateRecords();
            TuitionRateRecord addedTuitionRateRecordFromDatabase = tuitionRateRecords[4];

            Assert.AreEqual(5, tuitionRateRecords.Count);
            Assert.AreEqual(tuitionRateRecord.Student.StudentId, addedTuitionRateRecordFromDatabase.Student.StudentId);
            Assert.AreEqual(tuitionRateRecord.AccountHolder.AccountHolderId, addedTuitionRateRecordFromDatabase.AccountHolder.AccountHolderId);
            Assert.AreEqual(tuitionRateRecord.StartDate, addedTuitionRateRecordFromDatabase.StartDate);
            Assert.AreEqual(tuitionRateRecord.DailyRate, addedTuitionRateRecordFromDatabase.DailyRate);
        }
    }
}