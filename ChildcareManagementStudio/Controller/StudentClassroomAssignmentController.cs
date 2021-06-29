using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
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

        /// <summary>
        /// Method that returns a list of students that are not currently enrolled in a class for the specified school year.
        /// </summary>
        /// <param name="schoolYear">The school year being specified.</param>
        /// <returns>A list of students that are not currently enrolled in a class for the specified school year.</returns>
        public List<Student> GetAvailableStudents(string schoolYear)
        {
            return studentClassroomAssignmentDAL.GetAvailableStudents(schoolYear);
        }

        /// <summary>
        /// Method that adds a student/classroom assignment to the database.
        /// </summary>
        /// <param name="studentClassroomAssignment">An object representing the student/classroom assignment being added.</param>
        public void AddStudentClassroomAssignment(StudentClassroomAssignment studentClassroomAssignment)
        {
            if (studentClassroomAssignment == null)
            {
                throw new ArgumentNullException("studentClassroomAssignment", "The StudentClassroomAssignment object cannot be null.");
            }

            studentClassroomAssignmentDAL.AddStudentClassroomAssignment(studentClassroomAssignment);
        }

        /// <summary>
        /// Method that deletes a student/classroom assignment.
        /// </summary>
        /// <param name="studentClassroomAssignment">The student/classroom assignment being deleted.</param>
        public void DeleteStudentClassroomAssignment(StudentClassroomAssignment studentClassroomAssignment)
        {
            if (studentClassroomAssignment == null)
            {
                throw new ArgumentNullException("studentClassroomAssignment", "The StudentClassroomAssignment object cannot be null.");
            }

            studentClassroomAssignmentDAL.DeleteStudentClassroomAssignment(studentClassroomAssignment);
        }
    }
}