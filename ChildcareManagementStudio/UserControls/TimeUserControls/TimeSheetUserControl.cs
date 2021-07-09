using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    public partial class TimeSheetUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private readonly ClockRecordController clockRecordController;
        private List<Employee> employeeList;

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
            BindingList<Employee> employees = new BindingList<Employee>();
            foreach (Employee current in this.employeeList)
            {
                employees.Add(current);
            }
            this.comboBoxEmployee.DataSource = employees;
            this.comboBoxEmployee.ValueMember = "EmployeeId";
            this.comboBoxEmployee.DisplayMember = "FullName";
            this.comboBoxEmployee.SelectedIndex = -1;
            this.comboBoxEmployee.SelectedText = "--select--";
        }

        /// <summary>
        /// Handles button clicks to generate the report for the parameters set in the comboBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            ClockRecordBindingSource.Clear();
            EmployeeBindingSource.Clear();
            int employeeId;
            DateTime startTargetDate;
            DateTime endTargetDate;
            try
            {
                employeeId = (int)this.comboBoxEmployee.SelectedValue;
                startTargetDate = this.dateTimePickerStart.Value;
                endTargetDate = this.dateTimePickerEnd.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            List<ClockRecord> clockRecords = this.clockRecordController.GetAllClockRecordsForEmployee(employeeId);
            foreach (ClockRecord clockRecord in clockRecords)
            {
                int startRangeResult = DateTime.Compare(clockRecord.InDateTime, startTargetDate);
                int endRangeResult = DateTime.Compare(clockRecord.InDateTime, endTargetDate);

                if (startRangeResult >= 0
                    && endRangeResult <= 0
                    &&  clockRecord.OutDateTime.ToString("d") != "1/1/0001")
                {
                    ClockRecordBindingSource.Add(clockRecord);
                }               
            }
            if (ClockRecordBindingSource.Count == 0)
            {
                this.Enabled = false;
                string title = "No Clock Records Meet Criteria";
                string message = "The employee has no recorded work hours in the given range.";
                MessageBox.Show(message, title);
                this.Enabled = true;
            }
            else
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
}
