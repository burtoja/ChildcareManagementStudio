using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    /// <summary>
    /// This class will create and manage the time sheet UC
    /// </summary>
    public partial class TimeSheetUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private readonly ClockRecordController clockRecordController;
        private List<Employee> employeeList;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public TimeSheetUserControl()
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
            this.comboBoxEmployee.DataSource = employees;
            this.comboBoxEmployee.ValueMember = "EmployeeId";
            this.comboBoxEmployee.DisplayMember = "FullName";
            this.comboBoxEmployee.SelectedIndex = 0;
        }

        /// <summary>
        /// Checks to see if employee is selected in the comboBox.
        /// Displays a message box for not choosing a teacher when needed
        /// </summary>
        /// <returns>true if teacher is selected in combo box</returns>
        private bool EmployeeIsSelectedCheck()
        {
            if (this.comboBoxEmployee.SelectedIndex == -1)
            {
                this.Enabled = false;
                string title = "No Employee Chosen";
                string message = "Please choose a employee.";
                MessageBox.Show(message, title);
                this.Enabled = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Gets the employeeId from the comboBox.  Displays a dialog box and returns -1 if fail
        /// </summary>
        /// <returns>employeeID from comboBox</returns>
        private int GetEmployeeIdFromComboBox()
        {
            int employeeId;
            try
            {
                employeeId = (int)this.comboBoxEmployee.SelectedValue;
                return employeeId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }            
        }

        /// <summary>
        /// Checks to see if records were found that match the criteria provided in the form.
        /// If no records found a dialog box is displayed and false is returned.
        /// </summary>
        /// <returns>true if records were found within criteria</returns>
        private bool HasRecordsThatMatchCriteria()
        {
            if (ClockRecordBindingSource.Count == 0)
            {
                this.Enabled = false;
                string title = "No Clock Records Meet Criteria";
                string message = "The employee has no recorded work hours in the given range.";
                MessageBox.Show(message, title);
                this.Enabled = true;
                return false;
            }
            else
            {
                return true;
            }
                
        }

        /// <summary>
        /// Handles button clicks to generate the report for the parameters set in the comboBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            this.reportViewerTimeSheet.Clear();
            ClockRecordBindingSource.Clear();
            EmployeeBindingSource.Clear();          
            if (this.EmployeeIsSelectedCheck())
            {
                int employeeId = this.GetEmployeeIdFromComboBox();
                DateTime startTargetDate = this.dateTimePickerStart.Value;
                DateTime endTargetDate = this.dateTimePickerEnd.Value;
                List<ClockRecord> clockRecords = this.clockRecordController.GetAllClockRecordsForEmployee(employeeId);
                foreach (ClockRecord clockRecord in clockRecords)
                {
                    int startRangeResult = DateTime.Compare(clockRecord.InDateTime, startTargetDate);
                    int endRangeResult = DateTime.Compare(clockRecord.InDateTime, endTargetDate);

                    if (startRangeResult >= 0
                        && endRangeResult <= 0
                        && clockRecord.OutDateTime.ToString("d") != "1/1/0001")
                    {
                        ClockRecordBindingSource.Add(clockRecord);
                    }
                }
                if (this.HasRecordsThatMatchCriteria())
                {
                    Employee employee = this.employeeController.GetEmployee((employeeId));
                    EmployeeBindingSource.Add(employee);

                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("startTargetDate", startTargetDate.ToString("ddd M/d/yyyy"));
                    parameters[1] = new ReportParameter("endTargetDate", endTargetDate.ToString("ddd MM/dd/yyyy"));
                    this.reportViewerTimeSheet.LocalReport.SetParameters(parameters);

                    this.reportViewerTimeSheet.RefreshReport();
                }
            }                        
        }

        /// <summary>
        /// Handles clear button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.reportViewerTimeSheet.Clear();
            this.comboBoxEmployee.SelectedIndex = -1;
            this.comboBoxEmployee.SelectedText = "--select--";
        }
        
        /// <summary>
        /// Handler for clear button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearReportEventHandler(object sender, EventArgs e)
        {
            this.reportViewerTimeSheet.Clear();
        }
    }
}
