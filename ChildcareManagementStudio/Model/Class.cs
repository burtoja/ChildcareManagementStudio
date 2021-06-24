namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a physical Class of students and teacher(s)
    /// </summary>
    class Class
    {
        /// <summary>
        /// Property recording the id of the Class.
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// Property recording the classroom location.
        /// </summary>
        public string ClassroomLocation { get; set; }

        /// <summary>
        /// Property recording the school year with which the Class will be associated.
        /// </summary>
        public string SchoolYear { get; set; }
    }
}
