using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the EditEmployee method of the EmployeeController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class EmployeeControllerWhenEditEmployee
    {
        private EmployeeController employeeController;

        [TestInitialize]
        public void TestInitialize()
        {
            employeeController = new EmployeeController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfOriginalEmployeeIsNull()
        {
            Employee originalEmployee = null;

            Employee revisedEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            Assert.ThrowsException<System.ArgumentNullException>(() => employeeController.EditEmployee(originalEmployee, revisedEmployee));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfRevisedEmployeeIsNull()
        {
            Employee originalEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            Employee revisedEmployee = null;

            Assert.ThrowsException<System.ArgumentNullException>(() => employeeController.EditEmployee(originalEmployee, revisedEmployee));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfEmployeeIdIsDifferent()
        {
            Employee originalEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            Employee revisedEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 2,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            Assert.ThrowsException<System.ArgumentException>(() => employeeController.EditEmployee(originalEmployee, revisedEmployee));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfSalaryRecordsAreDifferent()
        {
            Employee originalEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            List<SalaryRecord> revisedSalaryRecords = new List<SalaryRecord>();
            SalaryRecord revisedSalaryRecord = new SalaryRecord
            {
                EffectiveDate = new DateTime(2021, 6, 5),
                Rate = 10
            };
            revisedSalaryRecords.Add(revisedSalaryRecord);

            Employee revisedEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 2,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5),
                SalaryRecords = revisedSalaryRecords
            };

            Assert.ThrowsException<System.ArgumentException>(() => employeeController.EditEmployee(originalEmployee, revisedEmployee));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfCertificationRecordsAreDifferent()
        {
            Employee originalEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            List<CertificationRecord> revisedCertificationRecords = new List<CertificationRecord>();
            CertificationRecord revisedCertificationRecord = new CertificationRecord
            {
                Type = "DCF",
                ExpirationDate = new DateTime(2021, 6, 5)
            };
            revisedCertificationRecords.Add(revisedCertificationRecord);

            Employee revisedEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 2,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5),
                CertificationRecords = revisedCertificationRecords
            };

            Assert.ThrowsException<System.ArgumentException>(() => employeeController.EditEmployee(originalEmployee, revisedEmployee));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfPositionRecordsAreDifferent()
        {
            Employee originalEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            List<PositionRecord> revisedPositionRecords = new List<PositionRecord>();
            PositionRecord revisedPositionRecord = new PositionRecord
            {
                Type = "Lead teacher",
                SchoolYear = "2021-2022"
            };
            revisedPositionRecords.Add(revisedPositionRecord);

            Employee revisedEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 2,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5),
                PositionRecords = revisedPositionRecords
            };

            Assert.ThrowsException<System.ArgumentException>(() => employeeController.EditEmployee(originalEmployee, revisedEmployee));
        }

        [TestMethod]
        public void ShouldUpdateDatabaseIfArgumentsAreValid()
        {
            Employee originalEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Orlando",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 5)
            };

            Employee revisedEmployee = new Employee
            {
                PersonId = 1,
                EmployeeId = 1,
                LastName = "Mouse",
                FirstName = "Mickey",
                DateOfBirth = new DateTime(1930, 1, 1),
                SocialSecurityNumber = "111-11-1111",
                Gender = "M",
                PhoneNumber = "(111) 111-1111",
                AddressLine1 = "123 Clubhouse Lane",
                City = "Lake Buena Vista",
                State = "FL",
                ZipCode = "32830",
                StartDate = new DateTime(2021, 6, 6)
            };

            employeeController.EditEmployee(originalEmployee, revisedEmployee);

            Employee retrievedEmployee = employeeController.GetEmployee(originalEmployee.EmployeeId);
            Assert.AreEqual("Lake Buena Vista", retrievedEmployee.City);
            Assert.AreEqual(new DateTime(2021, 6, 6), retrievedEmployee.StartDate);

            employeeController.EditEmployee(revisedEmployee, originalEmployee);    // this line is intended to undo the change made during the test
        }
    }
}