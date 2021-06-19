using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Method that returns Student objects for all of the students in the database.
        /// </summary>
        /// <returns>A list of Student objects for all of the students in the database.</returns>
        public List<Student> GetAllStudents()
        {
            return studentDAL.GetAllStudents();
        }


        /// <summary>
        /// Method that adds the specified student to the database.
        /// </summary>
        /// <param name="student">
        /// Student object representing the student to add.
        /// The Student object cannot have a value for the StudentId property, since this will be assigned by the database.
        /// </param>
        public void AddStudent(Student student)
        {
            if (student.StudentId != default)
            {
                throw new ArgumentException("The StudentId property cannot be filled out because it will be assigned by the database.", "student");
            }
            
            //TODO:  Add check for list properties (vaccination records, physical records, etc.

            studentDAL.AddStudent(student);
        }
    }
}