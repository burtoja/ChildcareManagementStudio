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
        /// Method that edits an employee's records in the database.
        /// Note that this method cannot be used to edit position records, salary records, or certification records.
        /// The method will throw an exception if any of the aforementioned records are different between the original and revised Employee objects.
        /// </summary>
        /// <param name="originalEmployee">Employee object representing the employee's records before the edits are made.</param>
        /// <param name="revisedEmployee">Employee object representing the person's records after the edits are made.</param>
        public void EditEmployee(Employee originalEmployee, Employee revisedEmployee)
        {
            if (originalEmployee == null)
            {
                throw new ArgumentNullException("originalEmployee", "The original employee cannot be null.");
            }

            if (revisedEmployee == null)
            {
                throw new ArgumentNullException("revisedEmployee", "The revised employee cannot be null.");
            }

            if (originalEmployee.EmployeeId != revisedEmployee.EmployeeId)
            {
                throw new ArgumentException("The employee ID must be the same for both Employee objects.");
            }

            if (SalaryRecordsAreDifferent(originalEmployee, revisedEmployee))
            {
                throw new ArgumentException("Salary records cannot be changed using the EditEmployee method.  Use a method specifically for salary records instead.");
            }

            if (CertificationRecordsAreDifferent(originalEmployee, revisedEmployee))
            {
                throw new ArgumentException("Certification records cannot be changed using the EditEmployee method.  Use a method specifically for certification records instead.");
            }

            if (PositionRecordsAreDifferent(originalEmployee, revisedEmployee))
            {
                throw new ArgumentException("Position records cannot be changed using the EditEmployee method.  Use a method specifically for position records instead.");
            }

            employeeDAL.EditEmployee(originalEmployee, revisedEmployee);
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

        /// <summary>
        /// Helper method that compares the position records for two Employee objects.
        /// </summary>
        /// <param name="originalEmployee">The first Employee object being evaluated.</param>
        /// <param name="revisedEmployee">The second Employee object being evaluated.</param>
        /// <returns>True if the position records are different, false otherwise.</returns>
        private bool PositionRecordsAreDifferent(Employee originalEmployee, Employee revisedEmployee)
        {
            if ((originalEmployee.PositionRecords == null) != (revisedEmployee.PositionRecords == null))
            {
                return true;
            }

            if (originalEmployee.PositionRecords == null && revisedEmployee.PositionRecords == null)
            {
                return false;
            }

            if (originalEmployee.PositionRecords.Count != revisedEmployee.PositionRecords.Count)
            {
                return true;
            }

            for (int recordIndex = 0; recordIndex < originalEmployee.PositionRecords.Count; recordIndex++)
            {
                if (originalEmployee.PositionRecords[recordIndex].Type != revisedEmployee.PositionRecords[recordIndex].Type)
                {
                    return true;
                }

                if (originalEmployee.PositionRecords[recordIndex].SchoolYear != revisedEmployee.PositionRecords[recordIndex].SchoolYear)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Helper method that compares the salary records for two Employee objects.
        /// </summary>
        /// <param name="originalEmployee">The first Employee object being evaluated.</param>
        /// <param name="revisedEmployee">The second Employee object being evaluated.</param>
        /// <returns>True if the salary records are different, false otherwise.</returns>
        private bool SalaryRecordsAreDifferent(Employee originalEmployee, Employee revisedEmployee)
        {
            if ((originalEmployee.SalaryRecords == null) != (revisedEmployee.SalaryRecords == null))
            {
                return true;
            }

            if (originalEmployee.SalaryRecords == null && revisedEmployee.SalaryRecords == null)
            {
                return false;
            }

            if (originalEmployee.SalaryRecords.Count != revisedEmployee.SalaryRecords.Count)
            {
                return true;
            }

            for (int recordIndex = 0; recordIndex < originalEmployee.SalaryRecords.Count; recordIndex++)
            {
                if (originalEmployee.SalaryRecords[recordIndex].EffectiveDate != revisedEmployee.SalaryRecords[recordIndex].EffectiveDate)
                {
                    return true;
                }

                if (originalEmployee.SalaryRecords[recordIndex].Rate != revisedEmployee.SalaryRecords[recordIndex].Rate)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Helper method that compares the certification records for two Employee objects.
        /// </summary>
        /// <param name="originalEmployee">The first Employee object being evaluated.</param>
        /// <param name="revisedEmployee">The second Employee object being evaluated.</param>
        /// <returns>True if the certification records are different, false otherwise.</returns>
        private bool CertificationRecordsAreDifferent(Employee originalEmployee, Employee revisedEmployee)
        {
            if ((originalEmployee.CertificationRecords == null) != (revisedEmployee.CertificationRecords == null))
            {
                return true;
            }

            if (originalEmployee.CertificationRecords == null && revisedEmployee.CertificationRecords == null)
            {
                return false;
            }

            if (originalEmployee.CertificationRecords.Count != revisedEmployee.CertificationRecords.Count)
            {
                return true;
            }

            for (int recordIndex = 0; recordIndex < originalEmployee.CertificationRecords.Count; recordIndex++)
            {
                if (originalEmployee.CertificationRecords[recordIndex].Type != revisedEmployee.CertificationRecords[recordIndex].Type)
                {
                    return true;
                }

                if (originalEmployee.CertificationRecords[recordIndex].ExpirationDate != revisedEmployee.CertificationRecords[recordIndex].ExpirationDate)
                {
                    return true;
                }
            }

            return false;
        }
    }
}