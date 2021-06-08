using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing employees.
    /// </summary>
    public class EmployeeController
    {
        private readonly EmployeeDAL employeeDAL;

        /// <summary>
        /// Constructor for the EmployeeController class.
        /// </summary>
        public EmployeeController()
        {
            employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Method that returns an Employee object for the specified person ID.
        /// </summary>
        /// <param name="personId">The person ID of the employee in question.</param>
        /// <returns>An Employee object for the specified employee.</returns>
        public Employee GetEmployee(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            return employeeDAL.GetEmployee(employeeId);
        }

        /// <summary>
        /// Method that returns Employee objects for all of the employees in the database.
        /// </summary>
        /// <returns>A list of Employee objects for all of the employees in the database.</returns>
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }

        /// <summary>
        /// Method that adds the specified employee to the database.
        /// </summary>
        /// <param name="employee">
        /// Employee object representing the employee to add.
        /// The Employee object cannot have a value for the EmployeeId property, since this will be assigned by the database.
        /// Additionally, the Employee object must have a value for the StartDate property.
        /// Finally, the Employee object cannot have values for any of the list properties (SalaryRecords, CertificationRecords, and PositionRecords).
        /// To add records for any of the list properties, use the appropriate method specific to that type of record.
        /// </param>
        public void AddEmployee(Employee employee)
        {
            if (employee.StartDate == default)
            {
                throw new ArgumentException("The Employee object must have a value for the StartDate property.", "employee");
            }

            if (employee.EmployeeId != default)
            {
                throw new ArgumentException("The EmployeeId property cannot be filled out because it will be assigned by the database.", "employee");
            }

            if (EmployeeListPropertiesHaveRecords(employee))
            {
                throw new ArgumentException("The Employee object cannot have salary, certification, or position records since these will not be added to the database by this method.", "employee");
            }

            employeeDAL.AddEmployee(employee);
        }

        /// <summary>
        /// Helper method that checks to see if any of the Employee list properties (SalaryRecords, CertificationRecords, and PositionRecords) have records.
        /// </summary>
        /// <param name="employee">The Employee object being evaluated.</param>
        /// <returns>True if any of the Employee list properties have records, false otherwise.</returns>
        private bool EmployeeListPropertiesHaveRecords(Employee employee)
        {
            return employee.SalaryRecords != null || employee.CertificationRecords != null || employee.PositionRecords != null;
        }
    }
}