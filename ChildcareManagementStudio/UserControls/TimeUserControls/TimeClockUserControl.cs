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
        /// Handler for tick events which are used to update the clock value label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCurrentTime_Tick(object sender, EventArgs e)
        {
            this.labelValueCurrentTime.Text = DateTime.Now.ToString();
        }
    }
}
