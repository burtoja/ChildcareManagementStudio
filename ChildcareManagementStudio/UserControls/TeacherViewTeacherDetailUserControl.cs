using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    /// <summary>
    /// User control to display teacher details based on pull-down menu selection of teacher
    /// </summary>
    public partial class TeacherViewTeacherDetailUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private List<Employee> employeeList;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public TeacherViewTeacherDetailUserControl()
        {
            this.employeeController = new EmployeeController();
            InitializeComponent();          
        }

        /// <summary>
        /// Fills the Name combobox with names of employees stored in DB
        /// </summary>
        public void FillDropDownList()
        {
            this.employeeList = this.employeeController.GetAllEmployees();
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
            this.ResetFormValues();
        }

        /// <summary>
        /// Fills comboboxes with names of employees in DB and preselects the indicated employee
        /// </summary>
        /// <param name="presetEmployeeId"></param>
        public void FillDropDownList(int presetEmployeeId)
        {
            this.FillDropDownList();
            this.comboBoxName.SelectedValue = presetEmployeeId;
        }

        /// <summary>
        /// Display the employee details from the DB
        /// </summary>
        /// <param name="employeeId"></param>
        private void FillFormValues(int employeeId)
        {
            Employee employee = this.employeeController.GetEmployee(employeeId);
            this.labelValueDOB.Text = employee.DateOfBirth.ToString("d");
            this.labelValueSSN.Text = employee.SocialSecurityNumber;
            this.labelValuePhone.Text = employee.PhoneNumber;
            this.labelValueGender.Text = employee.Gender;
            this.labelValueAddress1.Text = employee.AddressLine1;
            this.labelValueAddress2.Text = employee.AddressLine2 ?? "n/a";
            this.labelValueCity.Text = employee.City;
            this.labelValueState.Text = employee.State;
            this.labelValueZipCode.Text = employee.ZipCode;
            this.labelValueStartDate.Text = employee.StartDate.ToString("d");
        }

        /// <summary>
        /// When new value chosen in combobox the displayed teacher details update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                    this.FillFormValues(employeeId);
                }
                catch
                {
                    this.ResetFormValues();
                }
            }
            
        }

        /// <summary>
        /// Resets teacher details to empty
        /// </summary>
        private void ResetFormValues()
        {
            this.labelValueDOB.Text = "";
            this.labelValueSSN.Text = "";
            this.labelValuePhone.Text = "";
            this.labelValueGender.Text = "";
            this.labelValueAddress1.Text = "";
            this.labelValueAddress2.Text = "";
            this.labelValueCity.Text = "";
            this.labelValueState.Text = "";
            this.labelValueZipCode.Text = "";
            this.labelValueStartDate.Text = "";
        }

        /// <summary>
        /// Handles events needed to open the edit teacher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditTeacher_Click(object sender, EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                    Employee employee = this.employeeController.GetEmployee(employeeId);
                    EditTeacherForm editTeacherForm = new EditTeacherForm(employee, this);
                    editTeacherForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else
            {
                string title = "No Teacher Chosen";
                string message = "Please choose a teacher to edit.";
                MessageBox.Show(message, title);
            }

        }

    }
}
