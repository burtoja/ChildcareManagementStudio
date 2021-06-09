using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddCertificationRecord method of the CertificationDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class CertificationDALWhenAddCertificationRecord
    {
        private CertificationDAL certificationDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            certificationDAL = new CertificationDAL();
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
            Assert.ThrowsException<System.ArgumentException>(() => certificationDAL.AddCertificationRecord(employeeId, certificationRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfCertificationRecordIsNull()
        {
            int employeeId = 1;
            CertificationRecord certificationRecord = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => certificationDAL.AddCertificationRecord(employeeId, certificationRecord));
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
            certificationDAL.AddCertificationRecord(employeeId, certificationRecord);
            List<CertificationRecord> certificationRecords = certificationDAL.GetCertificationRecords(employeeId);
            Assert.AreEqual(2, certificationRecords.Count);
            Assert.AreEqual("DCF", certificationRecords[1].Type);
            Assert.AreEqual(new DateTime(2022, 12, 31), certificationRecords[1].ExpirationDate);
            certificationDAL.DeleteCertificationRecord(employeeId, certificationRecord);
        }
    }
}