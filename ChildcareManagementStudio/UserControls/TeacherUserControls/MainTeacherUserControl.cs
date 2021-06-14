using ChildcareManagementStudio.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    /// <summary>
    /// This class will build and manage the main tab user control on the Teacher portion of the app
    /// </summary>
    public partial class MainTeacherUserControl : UserControl
    {
        private ViewTeacherListUserControl viewTeacherListUserControl;
        public ViewTeacherDetailUserControl viewTeacherDetailUserControl { get; }
        private AddTeacherUserControl addTeacherUserControl;

        /// <summary>
        /// Constructor for the control
        /// </summary>
        public MainTeacherUserControl()
        {
            InitializeComponent();
            this.viewTeacherListUserControl = new ViewTeacherListUserControl(this);
            this.viewTeacherDetailUserControl = new ViewTeacherDetailUserControl(this);
            this.addTeacherUserControl = new AddTeacherUserControl(this);
            this.AddUserControls();
        }

        /// <summary>
        /// Add the user controls to the proper tab pages
        /// </summary>
        private void AddUserControls()
        {
            this.tabViewAllTeachers.Controls.Add(this.viewTeacherListUserControl);
            this.tabViewTeacherDetails.Controls.Add(this.viewTeacherDetailUserControl);
            this.tabAddTeacher.Controls.Add(this.addTeacherUserControl);
        }

        /// <summary>
        /// Event handler to listen for tab selected events and refresh the employee list when heard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlTeacher_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // View All Teachers tab
                    this.viewTeacherListUserControl.ResetEmployeeListResults();
                    break;
                case 1:
                    // View Teacher Details tab
                    this.viewTeacherDetailUserControl.FillDropDownList();
                    break;
                case 2:
                    // Add New Teacher tab

                    break;
            }
        }

    }
}
