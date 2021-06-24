using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Get the class by ClassId
        /// </summary>
        /// <param name="classId">the class id of the class to be retrieved</param>
        /// <returns></returns>
        public Class GetClass(int classId) 
        {
            // TODO: implement when DAL complete (and remove demoClass
            Class demoClass = new Class
            {
                ClassId = 2,
                ClassroomLocation = "Multi-purpose Room",
                SchoolYear = "2021-22"
            };
            return demoClass;
        }



    }
}
