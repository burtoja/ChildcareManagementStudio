using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddPositionRecord method of the PositionController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PositionControllerWhenAddPositionRecord
    {
        private PositionController positionController;

        [TestInitialize]
        public void TestInitialize()
        {
            positionController = new PositionController();
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
            Assert.ThrowsException<System.ArgumentException>(() => positionController.AddPositionRecord(employeeId, positionRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPositionRecordIsNull()
        {
            int employeeId = 1;
            PositionRecord positionRecord = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => positionController.AddPositionRecord(employeeId, positionRecord));
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
            positionController.AddPositionRecord(employeeId, positionRecord);
            List<PositionRecord> positionRecords = positionController.GetPositionRecords(employeeId);
            Assert.AreEqual(2, positionRecords.Count);
            Assert.AreEqual("Lead teacher", positionRecords[1].Type);
            Assert.AreEqual("2022-2023", positionRecords[1].SchoolYear);
            positionController.DeletePositionRecord(employeeId, positionRecord);
        }
    }
}