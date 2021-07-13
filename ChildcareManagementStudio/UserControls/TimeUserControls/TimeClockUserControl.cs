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
            this.employeeList.Insert(0, new Employee { FirstName = "Select an employee..." });
            BindingList<Employee> employees = new BindingList<Employee>();
            foreach (Employee current in this.employeeList)
            {
                employees.Add(current);
            }
            this.comboEmployeeName.DataSource = employees;
            this.comboEmployeeName.ValueMember = "EmployeeId";
            this.comboEmployeeName.DisplayMember = "FullName";
            this.comboEmployeeName.SelectedIndex = 0;
        }

        /// <summary>
        /// Checks to see if teacher is selected in the comboBox.
        /// Displays a message box for not choosing a teacher when needed
        /// </summary>
        /// <returns>true if teacher is selected in combo box</returns>
        private bool TeacherIsSelectedCheck()
        {
            if (this.comboEmployeeName.SelectedIndex <= 0)
            {
                this.DisplayMessageBox(
                    "No Teacher Chosen",
                    "Please choose a teacher.");
                return false;
            }
            else
            {
                return true;
            }               
        }

        /// <summary>
        /// Checks to see if the employee is clocked in (and not clocked out) 
        /// Displays error box for attempts to clock in when emplyee is already clocked in.
        /// </summary>
        /// <param name="employeeId">the employeeId of the emplyee to verify</param>
        /// <returns>true if employee is NOT clocked in</returns>
        private bool IsNotClockedInCheck(int employeeId)
        {
            if (this.clockRecordController.GetOpenClockRecord(employeeId) != null)
            {
                this.DisplayMessageBox(
                    "Employee Still Clocked In",
                    "This employee is still clocked in.  Please clock out before clocking in again.");         
                return false;
            }
            else
            {
                return true;
            }               
        }

        /// <summary>
        /// Displays message box and handles the enabling and disabling of the UC
        /// </summary>
        /// <param name="title">title of the message box</param>
        /// <param name="message">the message to display</param>
        private void DisplayMessageBox(string title, string message)
        {
            this.Enabled = false;
            MessageBox.Show(message, title);
            this.Enabled = true;
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
            if (this.TeacherIsSelectedCheck())
            {
                Int32.TryParse(this.comboEmployeeName.SelectedValue.ToString(), out int employeeId);
                if (this.IsNotClockedInCheck(employeeId))
                {
                    try
                    {
                        DateTime inTime = DateTime.Now;
                        ClockRecord clockInRecord = new ClockRecord()
                        {
                            EmployeeId = employeeId,
                            InDateTime = inTime
                        };
                        this.clockRecordController.ClockIn(clockInRecord);
                        this.DisplayMessageBox(
                            "Employee Clocked In",
                            "Employee has been clocked in at " + inTime);                       
                        this.buttonClockIn.Enabled = false;
                        this.buttonClockOut.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        this.DisplayMessageBox("Error Encountered", "Error: " + ex.Message);
                    }
                }
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
            if (this.TeacherIsSelectedCheck())
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
                    this.DisplayMessageBox(
                        "Employee Clocked Out",
                        "Employee has been clocked out: \r\n" +
                        "Time clocked in: " + outRecord.InDateTime.ToString() + "\r\n" +
                        "Time clocked out: " + outRecord.OutDateTime.ToString());
                    this.buttonClockIn.Enabled = true;
                    this.buttonClockOut.Enabled = false;
                }
                catch (Exception ex)
                {
                    this.DisplayMessageBox("Error Encountered", "Error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Handler to change button enabled state based upon selection in combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboEmployeeName.SelectedIndex > 0)
            {
                Int32.TryParse(this.comboEmployeeName.SelectedValue.ToString(), out int employeeId);
                if (this.clockRecordController.GetOpenClockRecord(employeeId) == null)
                {
                    this.buttonClockIn.Enabled = true;
                    this.buttonClockOut.Enabled = false;
                } else
                {
                    this.buttonClockIn.Enabled = false;
                    this.buttonClockOut.Enabled = true;
                }
            }
            else
            {
                this.buttonClockIn.Enabled = false;
                this.buttonClockOut.Enabled = false;
            }
                            
        }
    }
}
