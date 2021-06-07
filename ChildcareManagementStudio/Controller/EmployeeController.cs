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
    }
}