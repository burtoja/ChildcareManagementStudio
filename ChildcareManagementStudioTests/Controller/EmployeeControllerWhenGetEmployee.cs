using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetEmployee method of the EmployeeController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class EmployeeControllerWhenGetEmployee
    {
        private EmployeeController employeeController;

        [TestInitialize]
        public void TestInitialize()
        {
            employeeController = new EmployeeController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfEmployeeIdIsNegative()
        {
            int employeeId = -1;
            Assert.ThrowsException<System.ArgumentException>(() => employeeController.GetEmployee(employeeId));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfTheSpecifiedEmployeeDoesNotExist()
        {
            int employeeId = 0;
            Assert.ThrowsException<System.ArgumentException>(() => employeeController.GetEmployee(employeeId));
        }

        [TestMethod]
        public void ShouldReturnEmployeeObjectIfTheSpecifiedEmployeeExists()
        {
            int employeeId = 1;
            Employee employee = employeeController.GetEmployee(employeeId);
            Assert.AreEqual(1, employee.PersonId);
            Assert.AreEqual("Mouse", employee.LastName);
            Assert.AreEqual("Mickey", employee.FirstName);
            Assert.AreEqual(new DateTime(1930, 1, 1), employee.DateOfBirth);
            Assert.AreEqual("111-11-1111", employee.SocialSecurityNumber);
            Assert.AreEqual("M", employee.Gender);
            Assert.AreEqual("(111) 111-1111", employee.PhoneNumber);
            Assert.AreEqual("123 Clubhouse Lane", employee.AddressLine1);
            Assert.AreEqual("Orlando", employee.City);
            Assert.AreEqual("FL", employee.State);
            Assert.AreEqual("32830", employee.ZipCode);
            Assert.AreEqual(employeeId, employee.EmployeeId);
            Assert.AreEqual(new DateTime(2021, 6, 5), employee.StartDate);

            Assert.AreEqual(1, employee.SalaryRecords.Count);
            Assert.AreEqual(new DateTime(2021, 6, 5), employee.SalaryRecords[0].EffectiveDate);
            Assert.AreEqual(10.00, employee.SalaryRecords[0].Rate);

            Assert.AreEqual(1, employee.CertificationRecords.Count);
            Assert.AreEqual("FCCPC", employee.CertificationRecords[0].Type);
            Assert.AreEqual(new DateTime(2021, 12, 31), employee.CertificationRecords[0].ExpirationDate);

            Assert.AreEqual(1, employee.PositionRecords.Count);
            Assert.AreEqual("Lead teacher", employee.PositionRecords[0].Type);
            Assert.AreEqual("2021-22", employee.PositionRecords[0].SchoolYear);
        }
    }
}