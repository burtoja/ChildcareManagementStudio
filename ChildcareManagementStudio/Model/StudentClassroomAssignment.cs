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
        /// Property representing the class record associated with the record.
        /// </summary>
        public ClassRecord ClassRecord { get; set; }
    }
}