using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    public class StudentClassroomAssignmentController
    {
        private readonly StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        /// <summary>
        /// Constructor for the StudentClassroomAssignmentController class.
        /// </summary>
        public StudentClassroomAssignmentController()
        {
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();
        }

        /// <summary>
        /// Method that returns a list of all the StudentClassroomAssignment objects associated with a specific class record (classroom + school year).
        /// </summary>
        /// <param name="classId">The unique ID of the class being requested.</param>
        /// <returns>A list of all the StudentClassroomAssignment objects associated with a specific class record.</returns>
        public List<StudentClassroomAssignment> GetStudentsInClass(int classId)
        {
            return studentClassroomAssignmentDAL.GetStudentsInClass(classId);
        }
    }
}