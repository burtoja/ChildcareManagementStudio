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
        private readonly TeacherClassroomAssignmentController teacherClassroomAssignmentController;
        private readonly PositionController positionController;
        private readonly List<int> originalListAssignedTeacherIds;

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
            this.teacherClassroomAssignmentController = new TeacherClassroomAssignmentController();
            this.positionController = new PositionController();
            this.originalListAssignedTeacherIds = new List<int>();
            this.labelClassIdentifier.Text = this.classRecord.Identifier;
            this.PopulateOriginalListAssignedTeacherIds();
            this.PopulateTeacherListView();
        }

        /// <summary>
        /// Update the current list of assigned teachers based on DB 
        /// </summary>
        private void PopulateOriginalListAssignedTeacherIds()
        {
            this.originalListAssignedTeacherIds.Clear();
            foreach (TeacherClassroomAssignment current in this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.classRecord.ClassId))
            {
                this.originalListAssignedTeacherIds.Add(current.Teacher.EmployeeId);
            }
        }

        /// <summary>
        /// Determines if the supplied emplyeeId is in the list if emplyeeIds of teachers currently assigned to this class
        /// </summary>
        /// <param name="employeeId">emplyeeId to search for</param>
        /// <returns>true if the Id is found in the list of currently assigned Ids</returns>
        private bool IsAssignedToCurrentClass(int employeeId)
        {
            return this.originalListAssignedTeacherIds.Contains(employeeId);   
        }

        /// <summary>
        /// Populate the teacher choice listView with the teachers in the DB and marks those assigned tot his class with check marks
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
                if (this.IsAssignedToCurrentClass(current.EmployeeId))
                {
                    item.Checked = true;
                }                   
            }
        }

        private void AddSelectedTeacherCalssroomAssignments()
        {
            ListView.CheckedListViewItemCollection checkedItems = this.listViewTeacherChoices.CheckedItems;
            foreach (ListViewItem current in checkedItems)
            {
                int employeeId = Int32.Parse(current.SubItems[1].Text);
                if (!this.originalListAssignedTeacherIds.Contains(employeeId))
                {
                    TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment
                    {
                        Teacher = this.employeeController.GetEmployee(employeeId),
                        ClassRecord = this.classRecord,
                        StartDate = this.employeeController.GetEmployee(employeeId).StartDate,  // TODO: Should this be the position StartDate????
                        PositionType = this.positionController.GetCurrentPositionRecord(employeeId).Type 
                    };
                    try
                    {
                        this.teacherClassroomAssignmentController.AddTeacherClassroomAssignment(teacherClassroomAssignment);
                    }
                    catch (Exception ex)
                    {
                        string title = "Error Adding Teacher";
                        string message = "The Teacher was not added. The following error was encoutnered: " + ex.Message;
                        MessageBox.Show(message, title);
                    }
                }
            }
        }

        private void RemoveDeselectedTeacherClassroomAssignments()
        {
            foreach (int current in this.originalListAssignedTeacherIds)
            {
               
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
            this.AddSelectedTeacherCalssroomAssignments();
            this.RemoveDeselectedTeacherClassroomAssignments();

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
