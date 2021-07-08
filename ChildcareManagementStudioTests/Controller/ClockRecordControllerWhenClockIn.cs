using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    [TestClass]
    public class ClockRecordControllerWhenClockIn
    {
        private ClockRecordController clockRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordController = new ClockRecordController();
        }
        [TestMethod]
        public void ShouldAddNewRecordWithInDateTimeForEmployee()
        {
            List<ClockRecord> recordsBefore = this.clockRecordController.GetAllClockRecordsForEmployee(1);
            Assert.AreEqual(1, recordsBefore.Count);
            ClockRecord testRecord = new ClockRecord()
            {
                EmployeeId = 1,
                InDateTime = new System.DateTime(2021, 7, 6, 9, 30, 00)
            };
            this.clockRecordController.ClockIn(testRecord);
            List<ClockRecord> recordsAfter = this.clockRecordController.GetAllClockRecordsForEmployee(1);
            Assert.AreEqual(2, recordsAfter.Count);
            Assert.AreEqual("7/5/2021 8:00:00 AM", recordsAfter[0].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:00:00 PM", recordsAfter[0].OutDateTime.ToString());
            Assert.AreEqual("7/6/2021 9:30:00 AM", recordsAfter[1].InDateTime.ToString());
            this.clockRecordController.DeleteClockRecord(testRecord);
        }
    }
}
