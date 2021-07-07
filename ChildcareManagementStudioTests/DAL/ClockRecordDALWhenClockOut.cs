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
        [TestMethod]
        public void ShouldUpdateRecordWithOutDateTimeForEmployee()
        {
            int employeeId = 2;
            ClockRecordDAL clockRecordDAL = new ClockRecordDAL();
            List<ClockRecord> recordsBefore = clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Assert.AreEqual(1, recordsBefore.Count);
            ClockRecord inTestRecord = recordsBefore[0];
            Console.WriteLine("TEST: (OutTime from the InRecord) -- " + inTestRecord.OutDateTime.ToString());

            ClockRecord outTestRecord = new ClockRecord()            
            {
                EmployeeId = employeeId,
                InDateTime = inTestRecord.InDateTime,
                OutDateTime = new DateTime(2021, 7, 5, 17, 30, 0)
            };
            Console.WriteLine("TEST: (OutTime from the OutRecord) -- " + outTestRecord.OutDateTime.ToString());

            clockRecordDAL.ClockOut(inTestRecord, outTestRecord);
            List <ClockRecord> recordsAfter = clockRecordDAL.GetAllClockRecordsForEmployee(employeeId);
            Console.WriteLine("TEST: (OutTime from the DB After) -- " + recordsAfter[0].OutDateTime.ToString());

            Assert.AreEqual(1, recordsAfter.Count);
            Assert.AreEqual("7/5/2021 8:00:00 AM", recordsAfter[0].InDateTime.ToString());
            Assert.AreEqual("7/5/2021 5:30:00 PM", recordsAfter[0].OutDateTime.ToString());
        }
    }
}
