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
            int employeeId;
            TeacherClassroomAssignment teacherClassroomAssignment;
            foreach (ListViewItem current in checkedItems)
            {
                employeeId = Int32.Parse(current.SubItems[1].Text);               
                if (!this.originalListAssignedTeacherIds.Contains(employeeId))
                {
                    Console.WriteLine("ADD...");   // TODO: Remove after testing
                    Console.WriteLine("Name: " + this.employeeController.GetEmployee(employeeId).FullName);
                    Console.WriteLine("Date: " + this.positionController.GetCurrentPositionRecord(employeeId).StartDate);
                    Console.WriteLine("Position: " + this.positionController.GetCurrentPositionRecord(employeeId).Type);
                    teacherClassroomAssignment = new TeacherClassroomAssignment
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
            this.Close();
        }


        private void RemoveDeselectedTeacherClassroomAssignments()
        {
            Console.WriteLine("TEST - Made it into RemoveDeselectedTeacherClassroomAssignments()");
            int employeeId;
            //TeacherClassroomAssignment teacherClassroomAssignment;
            foreach (ListViewItem current in this.listViewTeacherChoices.Items)
            {
                Console.WriteLine("TEST  - Made it into foreach loop");
                if (!current.Checked)
                {
                    employeeId = Int32.Parse(current.SubItems[1].Text);

                    Console.WriteLine("REMOVE...");  // TODO: Remove after testing
                    Console.WriteLine("Name: " + this.employeeController.GetEmployee(employeeId).FullName);
                    Console.WriteLine("Employee ID: " + this.employeeController.GetEmployee(employeeId).EmployeeId);
                    Console.WriteLine("Classroom: " + this.classRecord.Identifier);
                    Console.WriteLine("Date (employeeController): " + this.employeeController.GetEmployee(employeeId).StartDate);                    
                    Console.WriteLine("Date (positionController): " + this.positionController.GetCurrentPositionRecord(employeeId).StartDate);
                    Console.WriteLine("Position: " + this.positionController.GetCurrentPositionRecord(employeeId).Type);

                    TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment()
                    {
                        Teacher = this.employeeController.GetEmployee(employeeId),
                        ClassRecord = this.classRecord,
                        StartDate = this.employeeController.GetEmployee(employeeId).StartDate,
                        //StartDate = this.positionController.GetCurrentPositionRecord(employeeId).StartDate,
                        PositionType = this.positionController.GetCurrentPositionRecord(employeeId).Type
                    };
                    //teacherClassroomAssignment = this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.classRecord.ClassId)[0];
                    Console.WriteLine("TEST - Teacher object made: " + teacherClassroomAssignment.StartDate + " " + teacherClassroomAssignment.Teacher.EmployeeId);
                    try
                    {
                        this.teacherClassroomAssignmentController.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
                        Console.WriteLine("TEST - finished try block (remove)");
                        foreach (TeacherClassroomAssignment current1 in this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.classRecord.ClassId)) 
                        {
                            Console.WriteLine("AFTER LIST...");  // TODO: Remove after testing
                            Console.WriteLine("Name: " + current1.Teacher.FullName);
                            Console.WriteLine("Employee ID: " + current1.Teacher.EmployeeId);
                            Console.WriteLine("Classroom: " + current1.ClassRecord.Identifier);
                            Console.WriteLine("Date: " + current1.StartDate);
                            Console.WriteLine("Position: " + current1.PositionType);
                        }
                    }
                    catch (Exception ex)
                    {
                        string title = "Error Removing Teacher";
                        string message = "The Teacher was not removed. The following error was encoutnered: " + ex.Message;
                        MessageBox.Show(message, title);
                    }
                }
            }
            this.Close();
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
            this.RemoveDeselectedTeacherClassroomAssignments();
            // this.AddSelectedTeacherCalssroomAssignments();
            this.referringUserControl.PopulateSelectedTeacherList();
        }
    }
}
