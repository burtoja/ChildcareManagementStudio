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
        /// Property representing the class record associated with the record.
        /// </summary>
        public ClassRecord ClassRecord { get; set; }
    }
}