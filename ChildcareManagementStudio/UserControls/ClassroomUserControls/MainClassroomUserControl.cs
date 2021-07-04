using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Class to create and mange main tabpage for classroom section of application
    /// </summary>
    public partial class MainClassroomUserControl : UserControl
    {
        private readonly ViewClassroomListUserControl viewClassroomListUserControl;
        private readonly SetupClassUserControl addStudentsToClassroomUserControl;
        private readonly GenerateDocumentsUserControl attendanceReportUserControl;
        private readonly SignInSheetUserControl signInSheetUserControl;
        
        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public MainClassroomUserControl()
        {
            InitializeComponent();
            this.viewClassroomListUserControl = new ViewClassroomListUserControl();
            this.addStudentsToClassroomUserControl = new SetupClassUserControl();
            this.attendanceReportUserControl = new GenerateDocumentsUserControl();
            this.signInSheetUserControl = new SignInSheetUserControl();
            this.AddUserControls();
        }

        /// <summary>
        /// Add the user controls to the proper tab pages
        /// </summary>
        private void AddUserControls()
        {
            this.tabPageListClassrooms.Controls.Add(this.viewClassroomListUserControl);
            this.tabPageEditClass.Controls.Add(this.addStudentsToClassroomUserControl);
            this.tabPageAttendanceSheet.Controls.Add(this.attendanceReportUserControl);
            this.tabPageSignInSheet.Controls.Add(this.signInSheetUserControl);
        }

        /// <summary>
        /// Event handler for selecting tabs within the Classroom section of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlMainClassroom_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // View Classroom List tab

                    break;
                case 1:
                    // Edit Students In Classroom tab

                    break;
                case 2:
                    // Generate Attendance Report tab
                    this.attendanceReportUserControl.UpdateComboBoxes();
                    break;
                case 3:
                    // Generate Sign-in Report tab
                    this.signInSheetUserControl.UpdateComboBoxes();
                    break;
            }
        }
    }
}
