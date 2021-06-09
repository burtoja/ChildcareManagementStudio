using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing salaries.
    /// </summary>
    public class SalaryController
    {
        private readonly SalaryDAL salaryDAL;

        /// <summary>
        /// Constructor for the SalaryController class.
        /// </summary>
        public SalaryController()
        {
            salaryDAL = new SalaryDAL();
        }

        /// <summary>
        /// Method that returns all of the salary records for a given employee.
        /// </summary>
        /// <param name="employeeId">The employee ID of the employee in question.</param>
        /// <returns>A list of all the salary records for the specified employee.</returns>
        public List<SalaryRecord> GetSalaryRecords(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            return this.salaryDAL.GetSalaryRecords(employeeId);
        }

        /// <summary>
        /// Method that adds a salary record to the database.
        /// </summary>
        /// <param name="employeeId">The employee ID for the employee that the record is associated with.</param>
        /// <param name="salaryRecord">A SalaryRecord object containing the details of the salary record.</param>
        public void AddSalaryRecord(int employeeId, SalaryRecord salaryRecord)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            if (salaryRecord == null)
            {
                throw new ArgumentNullException("salaryRecord", "The salary record cannot be null.");
            }

            salaryDAL.AddSalaryRecord(employeeId, salaryRecord);
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeleteSalaryRecord(int employeeId, SalaryRecord salaryRecord)
        {
            salaryDAL.DeleteSalaryRecord(employeeId, salaryRecord);
        }
    }
}