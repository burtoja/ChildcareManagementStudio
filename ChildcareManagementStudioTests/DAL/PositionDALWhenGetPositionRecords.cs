using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetPositionRecords method of the CertificationDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PositionDALWhenGetPositionRecords
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
            Assert.ThrowsException<System.ArgumentException>(() => positionDAL.GetPositionRecords(employeeId));
        }

        [TestMethod]
        public void ShouldReturnEmptyListIfRecordsDoNotExist()
        {
            int employeeId = 0;
            List<PositionRecord> positionRecords = positionDAL.GetPositionRecords(employeeId);
            Assert.AreEqual(0, positionRecords.Count);
        }

        [TestMethod]
        public void ShouldReturnRecordsIfTheyExist()
        {
            int employeeId = 1;
            List<PositionRecord> positionRecords = positionDAL.GetPositionRecords(employeeId);
            Assert.AreEqual(1, positionRecords.Count);
            Assert.AreEqual("Lead teacher", positionRecords[0].Type);
            Assert.AreEqual("2021-2022", positionRecords[0].SchoolYear);
        }
    }
}