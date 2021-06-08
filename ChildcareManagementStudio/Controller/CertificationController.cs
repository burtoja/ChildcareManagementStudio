using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing certifications.
    /// </summary>
    public class CertificationController
    {
        private readonly CertificationDAL certificationDAL;

        /// <summary>
        /// Constructor for the CertificationController class.
        /// </summary>
        public CertificationController()
        {
            certificationDAL = new CertificationDAL();
        }

        /// <summary>
        /// Method that returns all of the certification records for a given employee.
        /// </summary>
        /// <param name="employeeId">Employee ID for the employee in question.</param>
        /// <returns>A list of all the certification records for the specified employee.</returns>
        public List<CertificationRecord> GetCertificationRecords(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            return this.certificationDAL.GetCertificationRecords(employeeId);
        }
    }
}