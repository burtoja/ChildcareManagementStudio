using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{

    [TestClass]
    public class ClockRecordControllerWhenDeleteRecord
    {

        private ClockRecordController clockRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordController = new ClockRecordController();
        }

        [TestMethod]
        public void ShouldNotChangeTheRecordCount()
        {
            ClockRecord testRecord = new ClockRecord()
            {
                EmployeeId = 1,
                InDateTime = new DateTime(2021, 5, 5, 10, 10, 10)
            };
            int originalNumberofRecords = this.clockRecordController.GetAllClockRecordsForEmployee(1).Count;
            this.clockRecordController.ClockIn(testRecord);
            int recordCountAfterAdd = this.clockRecordController.GetAllClockRecordsForEmployee(1).Count;
            this.clockRecordController.DeleteClockRecord(testRecord);
            int recordCountAfterDelete = this.clockRecordController.GetAllClockRecordsForEmployee(1).Count;
            Assert.AreEqual(recordCountAfterAdd, originalNumberofRecords + 1);
            Assert.AreEqual(recordCountAfterDelete, originalNumberofRecords);
        }
    }
}
