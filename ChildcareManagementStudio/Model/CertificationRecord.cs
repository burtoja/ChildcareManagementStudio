using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class for storing certification records for an employee.
    /// </summary>
    public class CertificationRecord
    {
        /// <summary>
        /// Property for the name of the certification.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Property for the expiration date of the certification.
        /// </summary>
        public DateTime ExpirationDate { get; set; }
    }
}