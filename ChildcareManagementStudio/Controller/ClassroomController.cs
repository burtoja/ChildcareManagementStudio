using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing classrooms.
    /// </summary>
    public class ClassroomController
    {
        private readonly ClassroomDAL classroomDAL;

        /// <summary>
        /// Constructor for the ClassroomController class.
        /// </summary>
        public ClassroomController()
        {
            classroomDAL = new ClassroomDAL();
        }

        /// <summary>
        /// Method that returns a Classroom object representing the requested classroom.
        /// </summary>
        /// <param name="location">Location of the classroom being requested.</param>
        /// <returns>A Classroom object representing the requested classroom.</returns>
        public Classroom GetClassroom(string location)
        {
            if (string.IsNullOrEmpty(location))
            {
                throw new ArgumentNullException("location", "The classroom location cannot be null.");
            }

            return classroomDAL.GetClassroom(location);
        }
    }
}