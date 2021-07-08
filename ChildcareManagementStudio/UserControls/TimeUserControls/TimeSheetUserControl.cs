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
    }
}
