using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.View.ClassroomViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Creates and manages the UC for viewing and managing the list of active classroom records
    /// </summary>
    public partial class ViewClassroomListUserControl : UserControl
    {
        private readonly ClassroomController classroomController;
        private List<Classroom> classroomList;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public ViewClassroomListUserControl()
        {
            InitializeComponent();
            this.classroomController = new ClassroomController();
            this.classroomList = new List<Classroom>();
            RefreshClassroomListView();
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

        /// <summary>
        /// Refresh the list of registered classrooms
        /// </summary>
        public void RefreshClassroomListView()
        {
            this.listViewAllClassrooms.Items.Clear();
            this.classroomList = this.classroomController.GetAllClassrooms();
            foreach (Classroom current in classroomList)
            {
                ListViewItem item = new ListViewItem(current.Location.ToString());
                item.SubItems.Add(current.Capacity.ToString());
                this.listViewAllClassrooms.Items.Add(item);
            }
        }

        /// <summary>
        /// Handles edit selected classroom button clicks by opening the eidt classroom form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditSelectedClassroom_Click(object sender, EventArgs e)
        {
            if (this.listViewAllClassrooms.SelectedItems.Count == 0)
            {
                string title = "No Classroom Chosen";
                string message = "Please choose a classroom and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                ListViewItem item = listViewAllClassrooms.SelectedItems[0];
                Classroom selectedClassroom = this.classroomController.GetClassroom(this.classroomList[listViewAllClassrooms.SelectedIndices[0]].Id);
                EditClassroomForm editClassroomForm = new EditClassroomForm(this, selectedClassroom);
                editClassroomForm.Show();
                this.Enabled = false;
            }
        }
    }
}
