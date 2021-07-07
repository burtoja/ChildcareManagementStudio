using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    [TestClass]
    public class ClockRecordDALWhenGetAllClockRecordsForEmployee
    {
        [TestMethod]
        public void ShouldReturnAllClockRecordsForEmployee()
        {
            int employeeId = 1;
            ClockRecordDAL clockRecordDAL = new ClockRecordDAL();
            List<ClockRecord> records = clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, records.Count);
            Assert.AreEqual("7/5/2021 8:00:00 AM", records[0].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:00:00 PM", records[0].OutDateTime.ToString());
        }
    }
}
