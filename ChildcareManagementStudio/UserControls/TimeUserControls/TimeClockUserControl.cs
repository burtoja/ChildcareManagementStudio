using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    /// <summary>
    /// This class will create and manage the time clock UC
    /// </summary>
    public partial class TimeClockUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private readonly ClockRecordController clockRecordController;
        private List<Employee> employeeList;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public TimeClockUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.clockRecordController = new ClockRecordController();
            this.PopulateDropDownList();
        }

        /// <summary>
        /// Populate the comboBox with teacher names
        /// </summary>
        public void PopulateDropDownList()
        {
            this.employeeList = this.employeeController.GetAllEmployees();
            BindingList<Employee> employees = new BindingList<Employee>();
            foreach (Employee current in this.employeeList)
            {
                employees.Add(current);
            }
            this.comboEmployeeName.DataSource = employees;
            this.comboEmployeeName.ValueMember = "EmployeeId";
            this.comboEmployeeName.DisplayMember = "FullName";
            this.comboEmployeeName.SelectedIndex = -1;
            this.comboEmployeeName.SelectedText = "--select--";
        }

        /// <summary>
        /// Displays a message box for not choosing a teacher when needed
        /// </summary>
        private void DisplayChooseTeacherErrorBox()
        {
            string title = "No Teacher Chosen";
            string message = "Please choose a teacher to edit.";
            MessageBox.Show(message, title);
        }

        /// <summary>
        /// Handler for tick events which are used to update the clock value label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCurrentTime_Tick(object sender, EventArgs e)
        {
            this.labelValueCurrentTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Handle clock-in button click events.  Attempt to create clock-in record for selected
        /// employee or deliver proper message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClockIn_Click(object sender, EventArgs e)
        {
            if (this.comboEmployeeName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboEmployeeName.SelectedValue.ToString(), out int employeeId);
                    DateTime inTime = DateTime.Now;
                    ClockRecord clockInRecord = new ClockRecord()
                    {
                        EmployeeId = employeeId,
                        InDateTime = inTime
                    };
                    this.clockRecordController.ClockIn(clockInRecord);
                    string title = "Employee Clocked In";
                    string message = this.comboEmployeeName.SelectedText +
                        " has been clocked in at " + inTime;
                    MessageBox.Show(message, title);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else
            {
                this.DisplayChooseTeacherErrorBox();
            }
            
        }

        /// <summary>
        /// Handles button clicks of the clock out button.  Attempts to clock out the employee
        /// and provides meesages if there are errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClockOut_Click(object sender, EventArgs e)
        {
            if (this.comboEmployeeName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboEmployeeName.SelectedValue.ToString(), out int employeeId);
                    DateTime outTime = DateTime.Now;
                    ClockRecord inRecord = this.clockRecordController.GetOpenClockRecord(employeeId);
                    ClockRecord outRecord = new ClockRecord()
                    {
                        EmployeeId = employeeId,
                        InDateTime = inRecord.InDateTime,
                        OutDateTime = outTime
                    };
                    this.clockRecordController.ClockOut(inRecord, outRecord);
                    string title = "Employee Clocked Out";
                    string message = this.comboEmployeeName.SelectedText +
                        " was clocked in at " +
                        outRecord.InDateTime.ToString() +
                        "has been clocked out at " + outRecord.OutDateTime.ToString();
                    MessageBox.Show(message, title);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else
            {
                this.DisplayChooseTeacherErrorBox();
            }

        }
    }
}
