using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class used to communicate the amount of gross pay
    /// that an employee is owed within a date range.
    /// </summary>
    public class GrossPay
    {
        /// <summary>
        /// The employee that is owed the pay.
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// The start date used to calculate the gross pay owed.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date used to calculate the gross pay owed.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The amount of gross pay that the employee is owed.
        /// </summary>
        public double Amount { get; set; }
    }
}