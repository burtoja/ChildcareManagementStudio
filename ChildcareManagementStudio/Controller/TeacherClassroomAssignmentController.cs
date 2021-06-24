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
    }
}