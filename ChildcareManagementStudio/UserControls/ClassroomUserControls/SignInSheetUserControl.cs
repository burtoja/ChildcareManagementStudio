using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Class will create and manage the sign-in sheet tab in the Classrooms section of the application
    /// </summary>
    public partial class SignInSheetUserControl : UserControl
    {
        private readonly SchoolYearDAL schoolYearDAL;
        private readonly ClassroomDAL classroomDAL;
        private readonly ClassRecordDAL classRecordDAL;
        private readonly StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public SignInSheetUserControl()
        {
            InitializeComponent();

            schoolYearDAL = new SchoolYearDAL();
            classroomDAL = new ClassroomDAL();
            classRecordDAL = new ClassRecordDAL();
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();

            List<string> schoolYears = schoolYearDAL.GetAllSchoolYears();
            List<Classroom> classrooms = classroomDAL.GetAllClassrooms();

            schoolYearComboBox.DataSource = schoolYears;
            classComboBox.DataSource = classrooms;

            schoolYearComboBox.SelectedIndex = schoolYears.Count - 1;
        }
    }
}
