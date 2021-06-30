using System;
using System.Collections.Generic;
using System.Linq;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing an employee.
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Property representing the employee's unique employee ID.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Property indicating when the employee started at the center.
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                List<PositionRecord> sortedPositionRecords = PositionRecords.OrderBy(x => x.StartDate).ToList();
                return sortedPositionRecords.First().StartDate;
            }
        }

        /// <summary>
        /// Property containing an employee's salary records.
        /// </summary>
        public List<SalaryRecord> SalaryRecords { get; set; }

        /// <summary>
        /// Property containing an employee's certification records.
        /// </summary>
        public List<CertificationRecord> CertificationRecords { get; set; }

        /// <summary>
        /// Property containing an employee's position records.
        /// </summary>
        public List<PositionRecord> PositionRecords { get; set; }
    }
}