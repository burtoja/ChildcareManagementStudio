using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a student.
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Property representing the student's unique student ID.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// Property indicating when the student's vaccination records expire.
        /// </summary>
        public DateTime VaccinationRecordExpirationDate { get; set; }

        /// <summary>
        /// Property indicating when the student's physical exam records expire.
        /// </summary>
        public DateTime PhysicalExamExpirationDate { get; set; }
    }
}