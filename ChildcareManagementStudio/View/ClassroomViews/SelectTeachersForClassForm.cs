using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    /// <summary>
    /// Creates and manages the form used to select teachers to associate with the class
    /// </summary>
    public partial class SelectTeachersForClassForm : Form
    {
        private readonly SetupClassUserControl referringUserControl;
        private readonly ClassRecord classRecord;
        private readonly EmployeeController employeeController;
        private readonly TeacherClassroomAssignmentController teacherClassroomAssignmentcontroller;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl">The userControl opening this form</param>
        public SelectTeachersForClassForm(SetupClassUserControl referringUserControl, ClassRecord classRecord)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.classRecord = classRecord;
            this.employeeController = new EmployeeController();
            this.teacherClassroomAssignmentcontroller = new TeacherClassroomAssignmentController();
            this.labelClassIdentifier.Text = this.classRecord.Identifier;
            this.PopulateTeacherListView();
        }

        /// <summary>
        /// Populate the teacher choice listView with the teachers in the DB
        /// </summary>
        private void PopulateTeacherListView()
        {
            this.listViewTeacherChoices.Items.Clear();
            List<Employee> teacherList = this.employeeController.GetAllEmployees();
            foreach (Employee current in teacherList)
            {
                ListViewItem item = new ListViewItem(current.FullName);
                item.SubItems.Add(current.EmployeeId.ToString());
                this.listViewTeacherChoices.Items.Add(item);
            }
        }

        /// <summary>
        /// Re-enable referring UC on form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectTeachersForClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
        }

        /// <summary>
        /// Provides confirmation dialogue and close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            string title = "Cancel Teacher Selection Updates";
            string message = "Changes to assigned teacher list were not saved. Please click okay to go back to the class setup page.";
            MessageBox.Show(message, title);
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, System.EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = this.listViewTeacherChoices.CheckedItems;

            foreach (ListViewItem item in checkedItems)
            {
                Console.WriteLine("Name: " + item.SubItems[0].Text + " --- Id: " + item.SubItems[1].Text); 
            }
            //if (e.CurrentValue == CheckState.Unchecked)
            //{
            //    price += Double.Parse(
            //        this.ListView1.Items[e.Index].SubItems[1].Text);
            //}
            //else if ((e.CurrentValue == CheckState.Checked))
            //{
            //    price -= Double.Parse(
            //        this.ListView1.Items[e.Index].SubItems[1].Text);
            //}
        }
    }
}
