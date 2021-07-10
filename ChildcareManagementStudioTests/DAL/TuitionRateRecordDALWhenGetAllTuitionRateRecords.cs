using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetAllTuitionRateRecords method of the TuitionRateRecordDAL class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordDALWhenGetAllTuitionRateRecords
    {
        [TestMethod]
        public void ShouldGetAllRecords()
        {
            TuitionRateRecordDAL tuitionRateRecordDAL = new TuitionRateRecordDAL();
            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordDAL.GetAllTuitionRateRecords();
            TuitionRateRecord firstRecord = tuitionRateRecords[0];

            Assert.AreEqual(6, tuitionRateRecords.Count);
            Assert.AreEqual(1, firstRecord.Student.StudentId);
            Assert.AreEqual(new DateTime(2021, 6, 1), firstRecord.StartDate);
            Assert.AreEqual(new DateTime(2021, 6, 30), firstRecord.EndDate);
            Assert.AreEqual(30, firstRecord.DailyRate);
            Assert.AreEqual(1, firstRecord.AccountHolder.AccountHolderId);
        }
    }
}