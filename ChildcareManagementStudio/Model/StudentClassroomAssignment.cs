namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class that records the assignment of a student to a classroom.
    /// </summary>
    public class StudentClassroomAssignment
    {
        /// <summary>
        /// Property representing the student associated with the record.
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// Property representing the classroom associated with the record.
        /// </summary>
        public Classroom Classroom { get; set; }

        /// <summary>
        /// Property recording the school year that the assignment is valid for.
        /// </summary>
        public string SchoolYear { get; set; }
    }
}