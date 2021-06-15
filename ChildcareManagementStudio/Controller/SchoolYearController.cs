using ChildcareManagementStudio.DAL;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for school years.
    /// </summary>
    public class SchoolYearController
    {
        private readonly SchoolYearDAL schoolYearDAL;

        public SchoolYearController()
        {
            schoolYearDAL = new SchoolYearDAL();
        }

        /// <summary>
        /// Method that returns all of the school years in the database.
        /// </summary>
        /// <returns>All of the school years in the database.</returns>
        public List<string> GetAllSchoolYears()
        {
            return schoolYearDAL.GetAllSchoolYears();
        }
    }
}