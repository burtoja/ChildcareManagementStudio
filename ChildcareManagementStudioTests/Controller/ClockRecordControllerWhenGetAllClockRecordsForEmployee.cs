using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    [TestClass]
    public class ClockRecordControllerWhenGetAllClockRecordsForEmployee
    {
        private ClockRecordController clockRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordController = new ClockRecordController();
        }

        [TestMethod]
        public void ShouldReturnAllClockRecordsForEmployee()
        {
            int employeeId = 1;
            List<ClockRecord> records = this.clockRecordController.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, records.Count);
            Assert.AreEqual("7/5/2021 8:00:00 AM", records[0].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:00:00 PM", records[0].OutDateTime.ToString());
        }
    }
}
