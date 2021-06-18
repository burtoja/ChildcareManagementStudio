using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    public partial class MainStudentUserControl : UserControl
    {
        private readonly ViewStudentListUserControl viewStudentListUserControl;
        private readonly AddStudentUserControl addStudentUserControl;

        /// <summary>
        /// Constructor for the control
        /// </summary>
        public MainStudentUserControl()
        {
            InitializeComponent();
            this.viewStudentListUserControl = new ViewStudentListUserControl(this);
            this.addStudentUserControl = new AddStudentUserControl(this);
            this.AddUserControls();
        }

        /// <summary>
        /// Add the user controls to the proper tab pages
        /// </summary>
        private void AddUserControls()
        {
            this.tabViewAllStudents.Controls.Add(this.viewStudentListUserControl);
            this.tabAddStudent.Controls.Add(this.addStudentUserControl);
        }

        /// <summary>
        /// Event handler to listen for tab selected events and refresh the employee list when heard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlStudent_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // View All Student tab
                    
                    break;
                case 1:
                    // View Student Details tab
                    
                    break;
                case 2:
                    // Add New Student tab

                    break;
            }
        }
    }
}
