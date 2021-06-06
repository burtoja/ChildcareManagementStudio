using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetCertificationRecords method of the CertificationController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class CertificationControllerWhenGetCertificationRecords
    {
        private CertificationController certificationController;

        [TestInitialize]
        public void TestInitialize()
        {
            certificationController = new CertificationController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfEmployeeIdIsNegative()
        {
            int employeeId = -1;
            Assert.ThrowsException<System.ArgumentException>(() => certificationController.GetCertificationRecords(employeeId));
        }

        [TestMethod]
        public void ShouldReturnEmptyListIfRecordsDoNotExist()
        {
            int employeeId = 0;
            List<CertificationRecord> certificationRecords = certificationController.GetCertificationRecords(employeeId);
            Assert.AreEqual(0, certificationRecords.Count);
        }

        [TestMethod]
        public void ShouldReturnRecordsIfTheyExist()
        {
            int employeeId = 1;
            List<CertificationRecord> certificationRecords = certificationController.GetCertificationRecords(employeeId);
            Assert.AreEqual(1, certificationRecords.Count);
            Assert.AreEqual("FCCPC", certificationRecords[0].Type);
            Assert.AreEqual(new DateTime(2021, 12, 31), certificationRecords[0].ExpirationDate);
        }
    }
}