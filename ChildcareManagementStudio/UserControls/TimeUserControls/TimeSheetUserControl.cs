using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
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

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            ClockRecordBindingSource.Clear();
            int employeeId;
            DateTime startTargetDate;
            DateTime endTargetDate;
            try
            {
                employeeId = 1; // (int)this.comboBoxEmployee.SelectedValue;
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
                if (startRangeResult >= 1 && endRangeResult <= 1)
                {
                    ClockRecordBindingSource.Add(clockRecord);
                }
            }
            this.reportViewerTimeSheet.RefreshReport();
        }
    }
}
