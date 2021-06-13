using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.View;
using ChildcareManagementStudio.View.TeacherViews;
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
        private readonly PositionController positionController;
        private readonly SalaryController salaryController;
        private readonly CertificationController certificationController;
        private List<Employee> employeeList;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public TeacherViewTeacherDetailUserControl()
        {
            this.employeeController = new EmployeeController();
            this.positionController = new PositionController();
            this.salaryController = new SalaryController();
            this.certificationController = new CertificationController();
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
        /// Populate the listview with the employee's position history records.
        /// </summary>
        /// <param name="employeeId"></param>
        private void PopulatePositionHistoryListView(int employeeId)
        {
            this.listViewPositionHistory.Items.Clear();
           List <PositionRecord> positionList = this.positionController.GetPositionRecords(employeeId);
            foreach (PositionRecord current in positionList)
            {
                ListViewItem item = new ListViewItem(current.Type);
                item.SubItems.Add(current.SchoolYear);
                this.listViewPositionHistory.Items.Add(item);
            }
        }

        /// <summary>
        /// Populate the listview with the employee's salary history records.
        /// </summary>
        /// <param name="employeeId"></param>
        private void PopulateSalaryHistoryListView(int employeeId)
        {
            this.listViewPayHistory.Items.Clear();
            List<SalaryRecord> salaryList = this.salaryController.GetSalaryRecords(employeeId);
            foreach (SalaryRecord current in salaryList)
            {
                ListViewItem item = new ListViewItem(current.Rate.ToString());
                item.SubItems.Add(current.EffectiveDate.ToString("d"));
                this.listViewPayHistory.Items.Add(item);
            }
        }

        /// <summary>
        /// Populate the listview with the employee's certification history records.
        /// </summary>
        /// <param name="employeeId"></param>
        private void PopulateCertificationHistoryListView(int employeeId)
        {
            this.listViewCredentialHistory.Items.Clear();
            List<CertificationRecord> certificationList = this.certificationController.GetCertificationRecords(employeeId);
            foreach (CertificationRecord current in certificationList)
            {
                ListViewItem item = new ListViewItem(current.Type.ToString());
                item.SubItems.Add(current.ExpirationDate.ToString("d"));
                this.listViewCredentialHistory.Items.Add(item);
            }
        }

        /// <summary>
        /// When new value chosen in combobox the displayed teacher details update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.UpdateFormValues();           
        }

        /// <summary>
        /// Updates form values based on selected employee
        /// </summary>
        private void UpdateFormValues()
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                    this.FillFormValues(employeeId);
                    this.PopulatePositionHistoryListView(employeeId);
                    this.PopulateSalaryHistoryListView(employeeId);
                    this.PopulateCertificationHistoryListView(employeeId);
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
        /// Displays a message box for not choosing a teacher when needed
        /// </summary>
        private void DisplayChooseTeacherErrorBox()
        {
            string title = "No Teacher Chosen";
            string message = "Please choose a teacher to edit.";
            MessageBox.Show(message, title);
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
                this.DisplayChooseTeacherErrorBox();
            }
        }

        /// <summary>
        /// Handler for change positiion button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangePosition_Click(object sender, EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                AddPositionForm addPositionForm = new AddPositionForm(employeeId);
                addPositionForm.Show();
            }
            else
            {
                this.DisplayChooseTeacherErrorBox();
            }
        }

        /// <summary>
        /// Handler for update salary button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangePayRate_Click(object sender, EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                AddSalaryForm addSalaryForm = new AddSalaryForm(employeeId, this);
                addSalaryForm.Show();
            }
            else
            {
                this.DisplayChooseTeacherErrorBox();
            }
        }

        /// <summary>
        /// Handler for update crednetials button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddNewCredential_Click(object sender, EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int employeeId);
                AddCertificationForm addCertificationForm = new AddCertificationForm(employeeId, this);
                addCertificationForm.Show();
            }
            else
            {
                this.DisplayChooseTeacherErrorBox();
            }
        }

        /// <summary>
        /// Refresh the lists when enabled status changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherViewTeacherDetailUserControl_EnabledChanged(object sender, EventArgs e)
        {
            this.UpdateFormValues();
        }

       
    }
}
