using ChildcareManagementStudio.View.ClassroomViews;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Creates and manages the UC for viewing and managing the list of active classroom records
    /// </summary>
    public partial class ViewClassroomListUserControl : UserControl
    {
        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public ViewClassroomListUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles Add New Classroom button clicks to open the appropriate form and disable this UC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddNewClassroom_Click(object sender, EventArgs e)
        {
            AddNewClassroomForm addNewClassroomForm = new AddNewClassroomForm(this);
            addNewClassroomForm.Show();
            this.Enabled = false;
        }
    }
}
