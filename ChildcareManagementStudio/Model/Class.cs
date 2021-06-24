namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a combination of a classroom and a school year.
    /// </summary>
    public class Class
    {
        /// <summary>
        /// The unique ID for the class.
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// The classroom associated with the record.
        /// </summary>
        public Classroom Classroom { get; set; }

        /// <summary>
        /// The school year associated with the record.
        /// </summary>
        public string SchoolYear { get; set; }
    }
}