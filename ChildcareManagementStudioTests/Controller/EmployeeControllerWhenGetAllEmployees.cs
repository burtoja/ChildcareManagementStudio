using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllEmployees method of the EmployeeController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class EmployeeControllerWhenGetAllEmployees
    {
        [TestMethod]
        public void ShouldReturnAllEmployees()
        {
            EmployeeController employeeController = new EmployeeController();

            List<Employee> employees = employeeController.GetAllEmployees();
            Assert.AreEqual(3, employees.Count);

            Employee firstEmployee = employees[1];
            Assert.AreEqual(1, firstEmployee.PersonId);
            Assert.AreEqual("Mouse", firstEmployee.LastName);
            Assert.AreEqual("Mickey", firstEmployee.FirstName);
            Assert.AreEqual(new DateTime(1930, 1, 1), firstEmployee.DateOfBirth);
            Assert.AreEqual("111-11-1111", firstEmployee.SocialSecurityNumber);
            Assert.AreEqual("M", firstEmployee.Gender);
            Assert.AreEqual("(111) 111-1111", firstEmployee.PhoneNumber);
            Assert.AreEqual("123 Clubhouse Lane", firstEmployee.AddressLine1);
            Assert.AreEqual("Orlando", firstEmployee.City);
            Assert.AreEqual("FL", firstEmployee.State);
            Assert.AreEqual("32830", firstEmployee.ZipCode);
            Assert.AreEqual(1, firstEmployee.EmployeeId);
            Assert.AreEqual(new DateTime(2021, 6, 5), firstEmployee.StartDate);
            Assert.AreEqual(1, firstEmployee.SalaryRecords.Count);
            Assert.AreEqual(new DateTime(2021, 6, 5), firstEmployee.SalaryRecords[0].EffectiveDate);
            Assert.AreEqual(10.00, firstEmployee.SalaryRecords[0].Rate);
            Assert.AreEqual(1, firstEmployee.CertificationRecords.Count);
            Assert.AreEqual("FCCPC", firstEmployee.CertificationRecords[0].Type);
            Assert.AreEqual(new DateTime(2021, 12, 31), firstEmployee.CertificationRecords[0].ExpirationDate);
            Assert.AreEqual(1, firstEmployee.PositionRecords.Count);
            Assert.AreEqual("Lead teacher", firstEmployee.PositionRecords[0].Type);
            Assert.AreEqual("2021-22", firstEmployee.PositionRecords[0].SchoolYear);

            Employee secondEmployee = employees[2];
            Assert.AreEqual(2, secondEmployee.PersonId);
            Assert.AreEqual("Mouse", secondEmployee.LastName);
            Assert.AreEqual("Minnie", secondEmployee.FirstName);
            Assert.AreEqual(new DateTime(1932, 6, 1), secondEmployee.DateOfBirth);
            Assert.AreEqual("222-22-2222", secondEmployee.SocialSecurityNumber);
            Assert.AreEqual("F", secondEmployee.Gender);
            Assert.AreEqual("(222) 222-2222", secondEmployee.PhoneNumber);
            Assert.AreEqual("123 Clubhouse Lane", secondEmployee.AddressLine1);
            Assert.AreEqual("Orlando", secondEmployee.City);
            Assert.AreEqual("FL", secondEmployee.State);
            Assert.AreEqual("32830", secondEmployee.ZipCode);
            Assert.AreEqual(2, secondEmployee.EmployeeId);
            Assert.AreEqual(new DateTime(2021, 6, 7), secondEmployee.StartDate);
            Assert.AreEqual(1, secondEmployee.SalaryRecords.Count);
            Assert.AreEqual(new DateTime(2021, 6, 7), secondEmployee.SalaryRecords[0].EffectiveDate);
            Assert.AreEqual(9.75, secondEmployee.SalaryRecords[0].Rate);
            Assert.AreEqual(1, secondEmployee.CertificationRecords.Count);
            Assert.AreEqual("FCCPC", secondEmployee.CertificationRecords[0].Type);
            Assert.AreEqual(new DateTime(2022, 6, 1), secondEmployee.CertificationRecords[0].ExpirationDate);
            Assert.AreEqual(1, secondEmployee.PositionRecords.Count);
            Assert.AreEqual("Assistant teacher", secondEmployee.PositionRecords[0].Type);
            Assert.AreEqual("2021-22", secondEmployee.PositionRecords[0].SchoolYear);
        }
    }
}