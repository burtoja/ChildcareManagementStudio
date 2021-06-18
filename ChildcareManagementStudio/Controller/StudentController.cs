using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing students.
    /// </summary>
    public class StudentController
    {
        private readonly StudentDAL studentDAL;

        /// <summary>
        /// Constructor for the StudentController class.
        /// </summary>
        public StudentController()
        {
            studentDAL = new StudentDAL();
        }

        /// <summary>
        /// Method that returns a Student object for the specified student ID.
        /// </summary>
        /// <param name="studentId">The student ID of the student in question.</param>
        /// <returns>A Student object for the specified student.</returns>
        public Student GetStudent(int studentId)
        {
            if (studentId < 0)
            {
                throw new ArgumentException("The student ID cannot be a negative number.", "studentId");
            }

            return studentDAL.GetStudent(studentId);
        }
    }
}