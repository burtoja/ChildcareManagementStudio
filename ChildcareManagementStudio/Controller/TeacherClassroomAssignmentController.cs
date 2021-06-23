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
        /// <param name="schoolYear">School year being requested.</param>
        /// <param name="classroomLocation">Classroom location being requested.</param>
        /// <returns>All teacher/classroom assignments for the requested school year and classroom.</returns>
        public List<TeacherClassroomAssignment> GetTeacherClassroomAssignments(string schoolYear, string classroomLocation)
        {
            if (string.IsNullOrEmpty(schoolYear))
            {
                throw new ArgumentNullException("schoolYear", "The school year cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(classroomLocation))
            {
                throw new ArgumentNullException("classroomLocation", "The classroom location cannot be null or empty.");
            }

            return teacherClassroomAssignmentDAL.GetTeacherClassroomAssignments(schoolYear, classroomLocation);
        }
    }
}