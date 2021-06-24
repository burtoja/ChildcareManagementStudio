using ChildcareManagementStudio.Model;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing classes of students, techers, locations
    /// </summary>
    class ClassController
    {
        //private readonly ClassDAL classDAL;

        /// <summary>
        /// Constructor for ClassController
        /// </summary>
        public ClassController()
        {
            //this.classDAL = new ClassDAL();
        }

        public void AddClass(Class theClass)
        {
            //TODO:  Implement this method when DAL complete
        }

        /// <summary>
        /// Get the class by ClassId
        /// </summary>
        /// <param name="classId">the class id of the class to be retrieved</param>
        /// <returns></returns>
        public Class GetClass(int classId) 
        {
            // TODO: Implement when DAL complete (and remove demoClass)
            Class demoClass = new Class
            {
                ClassId = 2,
                ClassroomLocation = "Multi-purpose Room",
                SchoolYear = "2021-22"
            };
            return demoClass;
        }

        /// <summary>
        /// Returns a list of Class objects matching the provided school year
        /// </summary>
        /// <param name="schoolYear">the school year for which to return a list of Class objects</param>
        /// <returns></returns>
        public List<Class> GetAllClassesForSchoolYear(string schoolYear)
        {
            // TODO: Implement when DAL complete (and remove demoList)
            Class demoClass1 = new Class
            {
                ClassId = 1,
                ClassroomLocation = "Multi-purpose Room",
                SchoolYear = "2021-22"
            };
            Class demoClass2 = new Class
            {
                ClassId = 2,
                ClassroomLocation = "Room 5A",
                SchoolYear = "2021-22"
            };
            List<Class> demoList = new List<Class>
            {
                demoClass1,
                demoClass2
            };
            return demoList;
        }

        /// <summary>
        /// Edit the details of a Class
        /// </summary>
        /// <param name="originalClass">original Class object</param>
        /// <param name="revisedClass">revised Class object</param>
        public void EditClass(Class originalClass, Class revisedClass)
        {
            // TODO: Implement when DAL complete
        }

    }
}
