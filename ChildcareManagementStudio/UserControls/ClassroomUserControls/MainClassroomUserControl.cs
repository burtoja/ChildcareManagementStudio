using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Class to create and mange main tabpage for classroom section of application
    /// </summary>
    public partial class MainClassroomUserControl : UserControl
    {
        private readonly ViewClassroomListUserControl viewClassroomListUserControl;
        private readonly AddStudentsToClassroomUserControl addStudentsToClassroomUserControl;
        
        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public MainClassroomUserControl()
        {
            InitializeComponent();
            this.viewClassroomListUserControl = new ViewClassroomListUserControl();
            this.addStudentsToClassroomUserControl = new AddStudentsToClassroomUserControl();
            this.AddUserControls();
        }

        /// <summary>
        /// Add the user controls to the proper tab pages
        /// </summary>
        private void AddUserControls()
        {
            this.tabPageListClassrooms.Controls.Add(this.viewClassroomListUserControl);
            this.tabPageEditClassroom.Controls.Add(this.addStudentsToClassroomUserControl);
        }

        /// <summary>
        /// Event handler to listen for tab selected events and refresh the classroom list when heard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlStudent_Selected(object sender, TabControlEventArgs e)
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

                case 3:
                    // Generate Sign-in Report tab

                break;
            }
        }
    }
}
