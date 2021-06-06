namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class for storing position records for an employee.
    /// </summary>
    public class PositionRecord
    {
        /// <summary>
        /// Property for the name of the position.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Property for the school year when the employee held the specified position.
        /// </summary>
        public string SchoolYear { get; set; }
    }
}