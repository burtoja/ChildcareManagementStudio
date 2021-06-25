namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a classroom.
    /// </summary>
    public class Classroom
    {
        /// <summary>
        /// Property recording the unique ID of the classroom.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property recording the location of the classroom.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Property recording the number of students that the classroom can accommodate.
        /// </summary>
        public int Capacity { get; set; }
    }
}