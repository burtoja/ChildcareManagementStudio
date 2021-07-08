using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.DAL
{
    [TestClass]
    public class ClockRecordDALWhenDeleteRecord
    {
        private ClockRecordDAL clockRecordDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordDAL = new ClockRecordDAL();
        }

        [TestMethod]
        public void ShouldNotChangeTheRecordCount()
        {
            ClockRecord testRecord = new ClockRecord()
            {
                EmployeeId = 1,
                InDateTime = new DateTime(2021, 5, 5, 10, 10, 10)
            };
            int originalNumberofRecords = this.clockRecordDAL.GetAllClockRecordsForEmployee(1).Count;
            this.clockRecordDAL.ClockIn(testRecord);
            int recordCountAfterAdd = this.clockRecordDAL.GetAllClockRecordsForEmployee(1).Count;
            this.clockRecordDAL.DeleteClockRecord(testRecord);
            int recordCountAfterDelete = this.clockRecordDAL.GetAllClockRecordsForEmployee(1).Count;
            Assert.AreEqual(recordCountAfterAdd, originalNumberofRecords + 1);
            Assert.AreEqual(recordCountAfterDelete, originalNumberofRecords);
        }

    }
}
