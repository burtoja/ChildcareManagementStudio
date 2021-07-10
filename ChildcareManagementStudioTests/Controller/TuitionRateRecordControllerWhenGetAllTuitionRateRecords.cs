using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllTuitionRateRecords method of the TuitionRateRecordController class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordControllerWhenGetAllTuitionRateRecords
    {
        [TestMethod]
        public void ShouldGetAllRecords()
        {
            TuitionRateRecordController tuitionRateRecordController = new TuitionRateRecordController();
            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordController.GetAllTuitionRateRecords();
            TuitionRateRecord firstRecord = tuitionRateRecords[0];

            Assert.AreEqual(5, tuitionRateRecords.Count);
            Assert.AreEqual(1, firstRecord.Student.StudentId);
            Assert.AreEqual(new DateTime(2021, 6, 1), firstRecord.StartDate);
            Assert.AreEqual(new DateTime(2021, 6, 30), firstRecord.EndDate);
            Assert.AreEqual(30, firstRecord.DailyRate);
            Assert.AreEqual(1, firstRecord.AccountHolder.AccountHolderId);
        }
    }
}