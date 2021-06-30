using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddEmployee method of the EmployeeController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class EmployeeControllerWhenAddEmployee
    {
        private EmployeeController employeeController;

        [TestInitialize]
        public void TestInitialize()
        {
            employeeController = new EmployeeController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfEmployeeAlreadyHasEmployeeId()
        {
            Employee employeeToAdd = new Employee
            {
                EmployeeId = 3,
                LastName = "Duck",
                FirstName = "Daffy",
                DateOfBirth = new DateTime(1950, 6, 1),
                SocialSecurityNumber = "666-66-6666",
                Gender = "F",
                PhoneNumber = "(333) 333-3333",
                AddressLine1 = "7550 Maple Street",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.ThrowsException<System.ArgumentException>(() => employeeController.AddEmployee(employeeToAdd));
        }

        [TestMethod]
        public void ShouldAddEmployeeAndSetEmployeeIdPropertyIfPropertiesAreValid()
        {
            Employee employeeToAdd = new Employee
            {
                LastName = "Duck",
                FirstName = "Daffy",
                DateOfBirth = new DateTime(1950, 6, 1),
                SocialSecurityNumber = "666-66-6666",
                Gender = "F",
                PhoneNumber = "(333) 333-3333",
                AddressLine1 = "7550 Maple Street",
                City = "Orlando",
                State = "FL",
                ZipCode = "32789"
            };

            Assert.AreEqual(default, employeeToAdd.EmployeeId);
            employeeController.AddEmployee(employeeToAdd);
            Assert.AreNotEqual(default, employeeToAdd.EmployeeId);

            Employee employeeFromDatabase = employeeController.GetEmployee(employeeToAdd.EmployeeId);
            Assert.AreEqual("Duck", employeeFromDatabase.LastName);
            Assert.AreEqual("Daffy", employeeFromDatabase.FirstName);
            Assert.AreEqual(new DateTime(1950, 6, 1), employeeFromDatabase.DateOfBirth);
            Assert.AreEqual("666-66-6666", employeeFromDatabase.SocialSecurityNumber);
            Assert.AreEqual("F", employeeFromDatabase.Gender);
            Assert.AreEqual("(333) 333-3333", employeeFromDatabase.PhoneNumber);
            Assert.AreEqual("7550 Maple Street", employeeFromDatabase.AddressLine1);
            Assert.AreEqual("Orlando", employeeFromDatabase.City);
            Assert.AreEqual("FL", employeeFromDatabase.State);
            Assert.AreEqual("32789", employeeFromDatabase.ZipCode);
        }
    }
}
