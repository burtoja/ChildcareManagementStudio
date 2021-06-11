using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    public partial class TeacherViewTeacherDetailUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private readonly List<Employee> employeeList;

        public TeacherViewTeacherDetailUserControl()
        {
            this.employeeController = new EmployeeController();
            InitializeComponent();
            this.employeeList = this.employeeController.GetAllEmployees();
            this.FillDropDownList();
        }

        public void FillDropDownList()
        {
            BindingList<Employee> employees = new BindingList<Employee>();
            foreach (Employee current in this.employeeList)
            {
                employees.Add(current);
            }
            this.comboBoxName.DataSource = employees;
            this.comboBoxName.ValueMember = "EmployeeId";
            this.comboBoxName.DisplayMember = "FullName";
            this.comboBoxName.SelectedIndex = -1;
            this.comboBoxName.SelectedText = "--select--";
        }

        private void FillFormValues(int employeeId)
        {
            Employee employee = this.employeeController.GetEmployee(employeeId);
            this.labelValueDOB.Text = employee.DateOfBirth.ToString("d");
            this.labelValueSSN.Text = employee.SocialSecurityNumber;
            this.labelValuePhone.Text = employee.PhoneNumber;
            this.labelValueGender.Text = employee.Gender;
            this.labelValueAddress1.Text = employee.AddressLine1;
            this.labelValueAddress2.Text = employee.AddressLine2;
            this.labelValueCity.Text = employee.City;
            this.labelValueState.Text = employee.State;
            this.labelValueZipCode.Text = employee.ZipCode;
            this.labelValueStartDate.Text = employee.StartDate.ToString("d");

        }

        private void ComboBoxName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                    this.FillFormValues(employeeId);
                }
                catch (Exception ex)
                {

                }
            }
            
        }
    }
}
