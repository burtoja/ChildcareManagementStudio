using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for class records.
    /// </summary>
    public class ClassRecordController
    {
        private readonly ClassRecordDAL classRecordDAL;

        /// <summary>
        /// Constructor for the ClassRecordController class.
        /// </summary>
        public ClassRecordController()
        {
            classRecordDAL = new ClassRecordDAL();
        }

        /// <summary>
        /// Method that gets the requested class record.
        /// </summary>
        /// <param name="classId">Unique ID of the class record.</param>
        /// <returns>A ClassRecord object representing the requested class record.</returns>
        public ClassRecord GetClassRecord(int classId)
        {
            return classRecordDAL.GetClassRecord(classId);
        }
    }
}