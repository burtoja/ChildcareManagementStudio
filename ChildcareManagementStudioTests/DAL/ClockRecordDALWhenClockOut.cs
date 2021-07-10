using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    [TestClass]
    public class ClockRecordDALWhenClockOut
    {
        private ClockRecordDAL clockRecordDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            this.clockRecordDAL = new ClockRecordDAL();
        }

        [TestMethod]
        public void ShouldUpdateRecordWithOutDateTimeForClockedOutEmployee()
        {
            int employeeId = 1;
            List<ClockRecord> recordsBefore = this.clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, recordsBefore.Count);
            ClockRecord inTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = new DateTime(2021, 7, 5, 08, 15, 0)
            };
            this.clockRecordDAL.ClockIn(inTestRecord);
            List<ClockRecord> recordsAfterClockIn = this.clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(2, recordsAfterClockIn.Count);
            ClockRecord outTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = inTestRecord.InDateTime,
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            this.clockRecordDAL.ClockOut(inTestRecord, outTestRecord);
            List<ClockRecord> recordsAfterClockOut = this.clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(2, recordsAfterClockOut.Count);
            Assert.AreEqual("7/5/2021 8:15:00 AM", recordsAfterClockOut[1].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:30:00 PM", recordsAfterClockOut[1].OutDateTime.ToString());
            this.clockRecordDAL.DeleteClockRecord(outTestRecord);
        }

        [TestMethod]
        public void ShouldUpdateRecordWithOutDateTimeForMinnie()
        {
            int employeeId = 2;
            List<ClockRecord> recordsBefore = this.clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, recordsBefore.Count);
            ClockRecord inTestRecord = recordsBefore[0];
            ClockRecord outTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = inTestRecord.InDateTime,
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            this.clockRecordDAL.ClockOut(inTestRecord, outTestRecord);
            List<ClockRecord> recordsAfterClockOut = this.clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, recordsAfterClockOut.Count);
            Assert.AreEqual("7/5/2021 8:00:00 AM", recordsAfterClockOut[1].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:30:00 PM", recordsAfterClockOut[1].OutDateTime.ToString());
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenClockInRecordNull()
        {
            int employeeId = 2;
            ClockRecord inTestRecord = null;
            ClockRecord outTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = new DateTime(2021, 7, 5, 8, 00, 0),
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            Assert.ThrowsException<System.ArgumentNullException>(() => this.clockRecordDAL.ClockOut(inTestRecord, outTestRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionWhenClockOutRecordNull()
        {
            int employeeId = 2;
            ClockRecord outTestRecord = null;
            ClockRecord inTestRecord = new ClockRecord()
            {
                EmployeeId = employeeId,
                InDateTime = new DateTime(2021, 7, 5, 8, 00, 0),
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            Assert.ThrowsException<System.ArgumentNullException>(() => this.clockRecordDAL.ClockOut(inTestRecord, outTestRecord));
        }
    }
}
