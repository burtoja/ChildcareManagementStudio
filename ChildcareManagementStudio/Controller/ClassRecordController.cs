using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;

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

        /// <summary>
        /// Returns a list of Class objects matching the provided school year
        /// </summary>
        /// <param name="schoolYear">the school year for which to return a list of Class objects</param>
        /// <returns></returns>
        public List<ClassRecord> GetAllClassesForSchoolYear(string schoolYear)
        {
            return this.classRecordDAL.GetAllClassesForSchoolYear(schoolYear);
        }

        /// <summary>
        /// Adds class record to the DB
        /// </summary>
        /// <param name="classRecord">the ClassRecord object holding the class record information to be added</param>
        public void AddClassRecord(ClassRecord classRecord)
        {
            this.classRecordDAL.AddClassRecord(classRecord);
        }

        /// <summary>
        /// Edit the details of a Class
        /// </summary>
        /// <param name="originalClass">original Class object</param>
        /// <param name="revisedClass">revised Class object</param>
        public void EditClass(ClassRecord originalClass, ClassRecord revisedClass)
        {
            // TODO: Implement when DAL complete
        }
    }
}