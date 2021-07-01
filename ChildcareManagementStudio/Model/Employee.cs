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
        /// Note:  Is set to a DateTime of 1/1/1900 12:00:00 AM if not position records are in DB yet
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                try
                {
                    List<PositionRecord> sortedPositionRecords = PositionRecords.OrderBy(x => x.StartDate).ToList();
                    return sortedPositionRecords.First().StartDate;
                }
                catch (Exception ex)
                {
                    return new DateTime(1900, 1, 1);
                }
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