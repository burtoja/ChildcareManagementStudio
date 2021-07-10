using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.Controller
{
    [TestClass]
    public class ClockRecordControllerWhenGetOpenClockRecord
    {
        private ClockRecordController clockRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordController = new ClockRecordController();
        }

        [TestMethod]
        public void ShouldReturnSingleRecord()
        {
            int employeeId = 2;
            ClockRecord testRecord = this.clockRecordController.GetOpenClockRecord(employeeId);
            Assert.AreEqual(2, testRecord.EmployeeId);
            Assert.AreEqual("7/5/2021 8:00:00 AM", testRecord.InDateTime.ToString());
            Assert.AreEqual("1/1/0001 12:00:00 AM", testRecord.OutDateTime.ToString());
        }

        [TestMethod]
        public void ShouldReturnNullObjectReference()
        {
            int employeeId = 1;
            ClockRecord testRecord = this.clockRecordController.GetOpenClockRecord(employeeId);
            Assert.IsNull(testRecord);
        }
    }
}
