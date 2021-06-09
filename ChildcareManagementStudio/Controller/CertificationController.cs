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

        /// <summary>
        /// Method that adds a certification record to the database.
        /// </summary>
        /// <param name="employeeId">The employee ID of the employee that the record is associated with.</param>
        /// <param name="certificationRecord">A CertificationRecord object that contains the details of the certification record.</param>
        public void AddCertificationRecord(int employeeId, CertificationRecord certificationRecord)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            if (certificationRecord == null)
            {
                throw new ArgumentNullException("certificationRecord", "The certification record cannot be null.");
            }

            certificationDAL.AddCertificationRecord(employeeId, certificationRecord);
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeleteCertificationRecord(int employeeId, CertificationRecord certificationRecord)
        {
            certificationDAL.DeleteCertificationRecord(employeeId, certificationRecord);
        }
    }
}