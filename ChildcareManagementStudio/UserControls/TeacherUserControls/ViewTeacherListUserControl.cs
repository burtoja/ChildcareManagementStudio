using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    /// <summary>
    /// This class will serve to build and manage the user control which displays all teachers (employees)
    /// and allows for selecting a teacher (row) to view details
    /// </summary>
    public partial class ViewTeacherListUserControl : UserControl
    {
        private readonly MainTeacherUserControl mainTeacherUserControl;
        private readonly EmployeeController employeeController;

        /// <summary>
        /// Constructor for the user control.
        /// Note: comment out the this.PopulateListView(); to be able to work in the Designer view
        /// for this user control.  The DB is not active until app runs which seems to freak out
        /// VisualStudio.
        /// </summary>
        public ViewTeacherListUserControl(MainTeacherUserControl mainTeacherUserControl)
        {
            InitializeComponent();
            this.mainTeacherUserControl = mainTeacherUserControl;
            this.employeeController = new EmployeeController();
            this.PopulateListView();           
        }

        /// <summary>
        /// Gets list of all emplyees and finds their associated Person to build information
        /// items and adds them to the list view
        /// </summary>
        private void PopulateListView()
        {
            List<Employee> employeeList = this.employeeController.GetAllEmployees();
            foreach (Employee current in employeeList)
            {
                ListViewItem item = new ListViewItem(current.LastName.ToString());
                item.SubItems.Add(current.FirstName.ToString());
                item.SubItems.Add(current.DateOfBirth.ToString("d"));
                item.SubItems.Add(current.PhoneNumber.ToString());
                item.SubItems.Add(current.EmployeeId.ToString());
                this.listViewAllTeachers.Items.Add(item);
            }
        }

        /// <summary>
        /// Helper method to reset the list and refresh the results
        /// </summary>
        public void ResetEmployeeListResults()
        {
            this.listViewAllTeachers.Items.Clear();
            this.PopulateListView();
        }

        /// <summary>
        /// Button click causes a view of the employee details to be shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewTeacherDetails_Click(object sender, System.EventArgs e)
        {
            if (this.listViewAllTeachers.SelectedItems.Count == 0)
            {
                string title = "No Teacher Chosen";
                string message = "Please choose a teacher and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                ListViewItem item = listViewAllTeachers.SelectedItems[0];
                if (Int32.TryParse(item.SubItems[4].Text, out int selectedEmployeeId))
                {
                    this.mainTeacherUserControl.tabControlTeacher.SelectedIndex = 1;
                    this.mainTeacherUserControl.ViewTeacherDetailUserControl.FillDropDownList(selectedEmployeeId);
                }
            }
        }

    }
}
