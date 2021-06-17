using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    /// <summary>
    /// This class will create and mange the student list UC
    /// </summary>
    public partial class ViewStudentListUserControl : UserControl
    {
        private readonly MainStudentUserControl mainStudentUserControl;
        private readonly StudentController studentController;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        /// <param name="mainStudentUserControl"></param>
        public ViewStudentListUserControl(MainStudentUserControl mainStudentUserControl)
        {
            InitializeComponent();
            this.mainStudentUserControl = mainStudentUserControl;
            this.studentController = new StudentController();
            this.PopulateListView();
        }


        /// <summary>
        /// Gets list of all students and finds their associated Person to build information
        /// items and adds them to the list view
        /// </summary>
        private void PopulateListView()
        {
            List<Student> studentList = this.studentController.GetAllStudents();
            foreach (Student current in studentList)
            {
                ListViewItem item = new ListViewItem(current.LastName.ToString());
                item.SubItems.Add(current.FirstName.ToString());
                item.SubItems.Add(current.DateOfBirth.ToString("d"));
                item.SubItems.Add(current.StudentId.ToString());
                this.listViewAllStudents.Items.Add(item);
            }
        }

        /// <summary>
        /// Helper method to reset the list and refresh the results
        /// </summary>
        public void ResetStudentListResults()
        {
            this.listViewAllStudents.Items.Clear();
            this.PopulateListView();
        }

        /// <summary>
        /// Button click causes a view of the student details to be shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewStudentDetails_Click(object sender, System.EventArgs e)
        {
            if (this.listViewAllStudents.SelectedItems.Count == 0)
            {
                string title = "No Student Chosen";
                string message = "Please choose a student and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                ListViewItem item = listViewAllStudents.SelectedItems[0];
                if (Int32.TryParse(item.SubItems[4].Text, out int selectedEmployeeId))
                {
                    this.mainStudentUserControl.tabControlStudent.SelectedIndex = 1;
                    this.mainStudentUserControl.ViewStudentDetailUserControl.FillDropDownList(selectedStudentId);
                }
            }
        }

    }
}
