using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the EditTuitionRateEndDate method of the TuitionRateRecordController class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordControllerWhenEditTuitionRateEndDate
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

            TuitionRateRecordController tuitionRateRecordController = new TuitionRateRecordController();
            tuitionRateRecordController.EditTuitionRateEndDate(tuitionRateRecord);

            List<TuitionRateRecord> tuitionRateRecordsFromDatabase = tuitionRateRecordController.GetTuitionRateRecords(student);
            TuitionRateRecord tuitionRateRecordFromDatabase = tuitionRateRecordsFromDatabase[0];

            Assert.AreEqual(1, tuitionRateRecordsFromDatabase.Count);
            Assert.AreEqual(tuitionRateRecord.EndDate, tuitionRateRecordFromDatabase.EndDate);
        }
    }
}