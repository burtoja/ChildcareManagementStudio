using System;
using System.Collections.Generic;

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
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Property containing an employee's salary records.
        /// The records are stored as a List of Tuple objects.
        /// The first value in each Tuple object is the date that the given salary became effective.
        /// The second value in each Tuple object is the hourly pay rate for the employee.
        /// </summary>
        public List<Tuple<DateTime, double>> SalaryRecords { get; set; }

        /// <summary>
        /// Property containing an employee's certification records.
        /// The records are stored as a List of Tuple objects.
        /// The first value in each Tuple object is the type of certification that the employee earned.
        /// The second value in each Tuple object is the expiration date for the given certification.
        /// </summary>
        public List<Tuple<string, DateTime>> CertificationRecords { get; set; }

        /// <summary>
        /// Property containing an employee's position records.
        /// </summary>
        public List<PositionRecord> PositionRecords { get; set; }
    }
}