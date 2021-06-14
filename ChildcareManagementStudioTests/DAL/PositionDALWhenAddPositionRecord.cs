using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddPositionRecord method of the PositionDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PositionDALWhenAddPositionRecord
    {
        private PositionDAL positionDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            positionDAL = new PositionDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfEmployeeIdIsNegative()
        {
            int employeeId = -1;
            PositionRecord positionRecord = new PositionRecord
            {
                StartDate = new DateTime(2021, 9, 1),
                Type = "Lead teacher",
                SchoolYear = "2021-2022"
            };
            Assert.ThrowsException<System.ArgumentException>(() => positionDAL.AddPositionRecord(employeeId, positionRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPositionRecordIsNull()
        {
            int employeeId = 1;
            PositionRecord positionRecord = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => positionDAL.AddPositionRecord(employeeId, positionRecord));
        }

        [TestMethod]
        public void ShouldAddValidRecord()
        {
            int employeeId = 1;
            PositionRecord positionRecord = new PositionRecord
            {
                StartDate = new DateTime(2021, 9, 1),
                Type = "Lead teacher",
                SchoolYear = "2022-2023"
            };
            positionDAL.AddPositionRecord(employeeId, positionRecord);
            List<PositionRecord> positionRecords = positionDAL.GetPositionRecords(employeeId);
            Assert.AreEqual(2, positionRecords.Count);
            Assert.AreEqual("Lead teacher", positionRecords[1].Type);
            Assert.AreEqual("2022-2023", positionRecords[1].SchoolYear);
            positionDAL.DeletePositionRecord(employeeId, positionRecord);
        }
    }
}