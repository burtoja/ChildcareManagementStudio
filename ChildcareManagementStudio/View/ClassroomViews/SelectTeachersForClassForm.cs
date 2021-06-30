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
        private readonly List<TeacherClassroomAssignment> originalTeacherClassroomAssignmentList;
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
            this.originalTeacherClassroomAssignmentList = this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.classRecord.ClassId);
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
            foreach (TeacherClassroomAssignment current in this.originalTeacherClassroomAssignmentList)
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

        /// <summary>
        /// Assigns any newly checked teacher to the class
        /// </summary>
        /// <param name="current">current ListViewItem to be added if it meets the conditions</param>
        /// <returns>error message</returns>
        private string AddSelectedTeacherClassroomAssignments(ListViewItem current)
        {
            string errorsFromAddOperations = "";
            int employeeId = Int32.Parse(current.SubItems[1].Text);
            if (current.Checked && !this.originalListAssignedTeacherIds.Contains(employeeId))
            {
                TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment
                {
                    Teacher = this.employeeController.GetEmployee(employeeId),
                    ClassRecord = this.classRecord,
                    //StartDate = this.employeeController.GetEmployee(employeeId).StartDate,  
                };
                try
                {
                    this.teacherClassroomAssignmentController.AddTeacherClassroomAssignment(teacherClassroomAssignment);
                }
                catch (Exception ex)
                {
                    errorsFromAddOperations += "\r\n\r\n(ADD ERROR) Teacher name: " + teacherClassroomAssignment.Teacher.FullName + " - " +
                        "ID: " + teacherClassroomAssignment.Teacher.EmployeeId + " - " +
                        "\r\n" + ex.Message; //TODO: Remove exception message after testing complete
                }
            }
            return errorsFromAddOperations;

        }

        /// <summary>
        /// Removes any recently unchecked teacher from the class
        /// </summary>
        /// <param name="current">the current ListViewItem to be removed if it meets the conditions</param>
        /// <returns>error message text</returns>
        private string RemoveDeselectedTeacherClassroomAssignments(ListViewItem current)
        {
            string errorsFromRemoveOperations = "";
            if (!current.Checked && this.originalListAssignedTeacherIds.Contains(Int32.Parse(current.SubItems[1].Text)))
            {               
                int employeeId = Int32.Parse(current.SubItems[1].Text);
                TeacherClassroomAssignment teacherClassroomAssignment = this.originalTeacherClassroomAssignmentList[this.originalListAssignedTeacherIds.IndexOf(employeeId)];
                try
                {
                    this.teacherClassroomAssignmentController.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
                }
                catch (Exception ex)
                {
                    errorsFromRemoveOperations += "\r\n\r\n(DELETE ERROR) Teacher name: " + teacherClassroomAssignment.Teacher.FullName + " - " +
                        "ID: " + teacherClassroomAssignment.Teacher.EmployeeId + " - " +
                        "\r\n" + ex.Message; //TODO: Remove exception message after testing complete
                }
            }
            return errorsFromRemoveOperations;
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

        /// <summary>
        /// Event handler for submit button click events.  Will cehck each teacher item in the listview and determine if
        /// the teacher should be assigned to the class, removed from the class, or left unaltered.  Then executes the
        /// appropriate action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, System.EventArgs e)
        {
            string errorMessage = "";
            foreach (ListViewItem current in this.listViewTeacherChoices.Items)
            {
                if (!current.Checked && this.originalListAssignedTeacherIds.Contains(Int32.Parse(current.SubItems[1].Text)))
                {
                    errorMessage += this.RemoveDeselectedTeacherClassroomAssignments(current);
                }
                else
                {
                    errorMessage += this.AddSelectedTeacherClassroomAssignments(current);
                }                
            }
            if (errorMessage != "")
            {
                string title = "Error Updating Teacher(s)";
                string message = "Errors were found when updating teachers. The following teachers were not updated:" + errorMessage;
                MessageBox.Show(message, title);
            }
            this.Close();
            this.referringUserControl.PopulateSelectedTeacherList();
        }

    }
}
