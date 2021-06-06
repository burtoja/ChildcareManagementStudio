using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class for storing salary records for an employee.
    /// </summary>
    public class SalaryRecord
    {
        /// <summary>
        /// Property for the date when the specified salary took effect.
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Property for the hourly pay rate (in US dollars).
        /// </summary>
        public double Rate { get; set; }
    }
}