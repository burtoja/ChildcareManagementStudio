using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddCertificationRecord method of the CertificationController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class CertificationControllerWhenAddCertificationRecord
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
            CertificationRecord certificationRecord = new CertificationRecord
            {
                Type = "DCF",
                ExpirationDate = new DateTime(2022, 12, 31)
            };
            Assert.ThrowsException<System.ArgumentException>(() => certificationController.AddCertificationRecord(employeeId, certificationRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfCertificationRecordIsNull()
        {
            int employeeId = 1;
            CertificationRecord certificationRecord = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => certificationController.AddCertificationRecord(employeeId, certificationRecord));
        }

        [TestMethod]
        public void ShouldAddValidRecord()
        {
            int employeeId = 1;
            CertificationRecord certificationRecord = new CertificationRecord
            {
                Type = "DCF",
                ExpirationDate = new DateTime(2022, 12, 31)
            };
            certificationController.AddCertificationRecord(employeeId, certificationRecord);
            List<CertificationRecord> certificationRecords = certificationController.GetCertificationRecords(employeeId);
            Assert.AreEqual(2, certificationRecords.Count);
            Assert.AreEqual("DCF", certificationRecords[1].Type);
            Assert.AreEqual(new DateTime(2022, 12, 31), certificationRecords[1].ExpirationDate);
            certificationController.DeleteCertificationRecord(employeeId, certificationRecord);
        }
    }
}