using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class that records the assignment of a teacher to a classroom.
    /// </summary>
    public class TeacherClassroomAssignment
    {
        /// <summary>
        /// Property representing the teacher associated with the record.
        /// </summary>
        public Employee Teacher { get; set; }

        /// <summary>
        /// Property representing the classroom associated with the record.
        /// </summary>
        public Classroom Classroom { get; set; }

        /// <summary>
        /// Property representing the start date of the assignment.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Property recording the school year that the assignment is valid for.
        /// </summary>
        public string SchoolYear { get; set; }

        /// <summary>
        /// Property representing the position type for the assignment.
        /// </summary>
        public string PositionType { get; set; }
    }
}