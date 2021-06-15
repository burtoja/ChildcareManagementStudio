using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetPositionRecords method of the PositionController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PositionControllerWhenGetPositionRecords
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
            Assert.ThrowsException<System.ArgumentException>(() => positionController.GetPositionRecords(employeeId));
        }

        [TestMethod]
        public void ShouldReturnEmptyListIfRecordsDoNotExist()
        {
            int employeeId = 0;
            List<PositionRecord> positionRecords = positionController.GetPositionRecords(employeeId);
            Assert.AreEqual(0, positionRecords.Count);
        }

        [TestMethod]
        public void ShouldReturnRecordsIfTheyExist()
        {
            int employeeId = 1;
            List<PositionRecord> positionRecords = positionController.GetPositionRecords(employeeId);
            Assert.AreEqual(1, positionRecords.Count);
            Assert.AreEqual("Lead teacher", positionRecords[0].Type);
            Assert.AreEqual("2021-22", positionRecords[0].SchoolYear);
        }
    }
}
