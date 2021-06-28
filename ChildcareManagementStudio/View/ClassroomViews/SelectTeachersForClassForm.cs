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
                Console.WriteLine(current.Teacher.FullName + " - " + current.Teacher.EmployeeId + " - " + current.StartDate.ToString()); //TODO: Remove after testing
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
        private void AddSelectedTeacherCalssroomAssignments(ListViewItem current)
        {
            string errorsFromAddOperations = "";
            Console.WriteLine("Checking item to see if it should be added (ADD)...");
            int employeeId = Int32.Parse(current.SubItems[1].Text);
            if (!this.originalListAssignedTeacherIds.Contains(employeeId))
            {
                Console.WriteLine("---BEGIN ITEM (ADD)---");  // TODO: Remove after testing (All)
                //Console.WriteLine("VALUES FOR OBJECT FROM FORM BEFORE ADD METHOD CALL..."); 
                //Console.WriteLine("Name: " + this.employeeController.GetEmployee(employeeId).FullName);
                //Console.WriteLine("Date: " + this.positionController.GetCurrentPositionRecord(employeeId).StartDate);
                //Console.WriteLine("Position: " + this.positionController.GetCurrentPositionRecord(employeeId).Type);
                TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment
                {
                    Teacher = this.employeeController.GetEmployee(employeeId),
                    ClassRecord = this.classRecord,
                    StartDate = new DateTime(2021, 8, 1),  // TODO: TESTING - added this until I can figure out the date issue
                    //StartDate = this.employeeController.GetEmployee(employeeId).StartDate,  
                    PositionType = this.positionController.GetCurrentPositionRecord(employeeId).Type
                };
                try
                {
                    this.teacherClassroomAssignmentController.AddTeacherClassroomAssignment(teacherClassroomAssignment);
                }
                catch (Exception ex)
                {
                    errorsFromAddOperations += "\r\nTeacher name: " + teacherClassroomAssignment.Teacher.FullName + " - " +
                        "ID: " + teacherClassroomAssignment.Teacher.EmployeeId + " - " +
                        "Start Date: " + teacherClassroomAssignment.StartDate.ToString("d") +
                        "\r\n\r\n" + ex.Message; //TODO: Remove exception message after testing complete
                }
                Console.WriteLine("-------------------------END ITEM (ADD)--------------------------------------");
            }
            if (errorsFromAddOperations != "")
            {
                string title = "Error Adding Teacher(s)";
                string message = "Errors were found when adding teachers. The following teachers were not added: \r\n" + errorsFromAddOperations;
                MessageBox.Show(message, title);
            }
        }

        /// <summary>
        /// Removes any recently unchecked teacher from the class
        /// </summary>
        private void RemoveDeselectedTeacherClassroomAssignments(ListViewItem current)
        {
            string errorsFromRemoveOperations = "";
            Console.WriteLine("Checking item to see if it should be removed (REMOVE)...");
            if (!current.Checked && this.originalListAssignedTeacherIds.Contains(Int32.Parse(current.SubItems[1].Text)))
            {               
                int employeeId = Int32.Parse(current.SubItems[1].Text);
                TeacherClassroomAssignment teacherClassroomAssignment = this.originalTeacherClassroomAssignmentList[this.originalListAssignedTeacherIds.IndexOf(employeeId)];

                Console.WriteLine("---BEGIN ITEM (REMOVE)---"); // TODO: Remove after testing (all)
                //Console.WriteLine("VALUES FOR OBJECT FROM FORM BEFORE REMOVE METHOD CALL...");  
                //Console.WriteLine("Name: " + this.employeeController.GetEmployee(employeeId).FullName);
                //Console.WriteLine("Employee ID: " + this.employeeController.GetEmployee(employeeId).EmployeeId);
                //Console.WriteLine("Classroom: " + this.classRecord.Identifier);
                //Console.WriteLine("Date (employeeController): " + this.employeeController.GetEmployee(employeeId).StartDate);                    
                //Console.WriteLine("Date (positionController): " + this.positionController.GetCurrentPositionRecord(employeeId).StartDate);
                //Console.WriteLine("Position: " + this.positionController.GetCurrentPositionRecord(employeeId).Type);

                Console.WriteLine("TEST - Teacher object made: " + teacherClassroomAssignment.StartDate + " " + teacherClassroomAssignment.Teacher.EmployeeId);  // TODO: Remove after testing
                try
                {
                    this.teacherClassroomAssignmentController.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
                }
                catch (Exception ex)
                {
                    errorsFromRemoveOperations += "\r\nTeacher name: " + teacherClassroomAssignment.Teacher.FullName + " - " +
                        "ID: " + teacherClassroomAssignment.Teacher.EmployeeId + " - " +
                        "Start Date: " + teacherClassroomAssignment.StartDate.ToString("d") +
                        "\r\n\r\n" + ex.Message; //TODO: Remove exception message after testing complete
                }
                Console.WriteLine("-------------------------END ITEM (REMOVE)--------------------------------------");
            }
            if (errorsFromRemoveOperations != "")
            {
                string title = "Error Removing Teacher(s)";
                string message = "Errors were found when removing teachers. The following teachers were not removed: \r\n" + errorsFromRemoveOperations;
                MessageBox.Show(message, title);
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

        /// <summary>
        /// Event handler for submit button click events.  Will cehck each teacher item in the listview and determine if
        /// the teacher should be assigned to the class, removed from the class, or left unaltered.  Then executes the
        /// appropriate action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem current in this.listViewTeacherChoices.Items)
            {
                if (!current.Checked && this.originalListAssignedTeacherIds.Contains(Int32.Parse(current.SubItems[1].Text)))
                {
                    this.RemoveDeselectedTeacherClassroomAssignments(current);
                }
                else
                {
                    this.AddSelectedTeacherCalssroomAssignments(current);
                }                
            }
            this.Close();
            this.referringUserControl.PopulateSelectedTeacherList();
        }
    }
}
