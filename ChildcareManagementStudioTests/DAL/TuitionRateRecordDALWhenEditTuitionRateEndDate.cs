using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the EditTuitionRateEndDate method of the TuitionRateRecordDAL class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordDALWhenEditTuitionRateEndDate
    {
        [TestMethod]
        public void ShouldEditTuitionRateEndDate()
        {
            Student student = new Student()
            {
                StudentId = 4
            };

            DateTime startDate = new DateTime(2021, 6, 15);
            DateTime endDate = new DateTime(2021, 6, 16);

            TuitionRateRecord tuitionRateRecord = new TuitionRateRecord()
            {
                Student = student,
                StartDate = startDate,
                EndDate = endDate
            };

            TuitionRateRecordDAL tuitionRateRecordDAL = new TuitionRateRecordDAL();
            tuitionRateRecordDAL.EditTuitionRateEndDate(tuitionRateRecord);

            List<TuitionRateRecord> tuitionRateRecordsFromDatabase = tuitionRateRecordDAL.GetTuitionRateRecords(student);
            TuitionRateRecord tuitionRateRecordFromDatabase = tuitionRateRecordsFromDatabase[0];

            Assert.AreEqual(1, tuitionRateRecordsFromDatabase.Count);
            Assert.AreEqual(tuitionRateRecord.EndDate, tuitionRateRecordFromDatabase.EndDate);
        }
    }
}