using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for teacher/classroom assignments.
    /// </summary>
    public class TeacherClassroomAssignmentController
    {
        private readonly TeacherClassroomAssignmentDAL teacherClassroomAssignmentDAL;

        /// <summary>
        /// Constructor for the TeacherClassroomAssignmentController class.
        /// </summary>
        public TeacherClassroomAssignmentController()
        {
            teacherClassroomAssignmentDAL = new TeacherClassroomAssignmentDAL();
        }

        /// <summary>
        /// Method that gets all teacher/classroom assignments for a given school year and classroom.
        /// </summary>
        /// <param name="classId">Class ID being requested.</param>
        /// <returns>All teacher/classroom assignments for the requested school year and classroom.</returns>
        public List<TeacherClassroomAssignment> GetTeacherClassroomAssignments(int classId)
        {
            return teacherClassroomAssignmentDAL.GetTeacherClassroomAssignments(classId);
        }

        /// <summary>
        /// Method that adds a teacher/classroom assignment to the database.
        /// </summary>
        /// <param name="teacherClassroomAssignment">An object representing the teacher/classroom assignment being added.</param>
        public void AddTeacherClassroomAssignment(TeacherClassroomAssignment teacherClassroomAssignment)
        {
            if (teacherClassroomAssignment == null)
            {
                throw new ArgumentNullException("teacherClassroomAssignment", "The TeacherClassroomAssignment object cannot be null.");
            }

            teacherClassroomAssignmentDAL.AddTeacherClassroomAssignment(teacherClassroomAssignment);
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeleteTeacherClassroomAssignment(TeacherClassroomAssignment teacherClassroomAssignment)
        {
            teacherClassroomAssignmentDAL.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
        }
    }
}