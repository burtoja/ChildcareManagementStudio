using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View
{
    /// <summary>
    /// Form used to edit teacher information. 
    /// </summary>
    public partial class EditTeacherForm : Form
    {
        private readonly ViewTeacherDetailUserControl referringControl;
        private readonly EmployeeController employeeController;
        private readonly Employee originalEmployee;

        /// <summary>
        /// Constructor for the form.  Disables the referring control and pre-fills form fields.
        /// </summary>
        /// <param name="theEmployee">the employee to be edited</param>
        /// <param name="referingControl">the referring User Control</param>
        public EditTeacherForm(Employee theEmployee, ViewTeacherDetailUserControl referingControl)
        {
            InitializeComponent();
            this.referringControl = referingControl;
            this.employeeController = new EmployeeController();
            this.originalEmployee = theEmployee;
            this.referringControl.Enabled = false;
            this.FillFormWithOriginalEmployeeInfo();
        }
    
        /// <summary>
        /// Actions to perform whne submit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.labelErrorMessage.Text = this.CheckInputFields();

            if (this.labelErrorMessage.Text == "")
            {
                string firstName = this.textBoxFirstName.Text;
                string lastName = this.textBoxLastName.Text;
                DateTime dob = this.dateTimePickerDOB.Value;
                string ssn = this.textBoxSSN.Text;
                string phone = this.textBoxPhoneNumber.Text;
                string gender = this.comboBoxGender.Text;
                string address1 = this.textBoxAddress1.Text;
                string address2 = this.textBoxAddress2.Text;
                string city = this.textBoxCity.Text;
                string state = this.comboBoxState.Text;
                string zip = this.textBoxZipCode.Text;
                DateTime startDate = this.dateTimePickerStartDate.Value;
                try
                {
                    Employee revisedEmployee = new Employee
                    {
                        PersonId = this.originalEmployee.PersonId,
                        EmployeeId = this.originalEmployee.EmployeeId,
                        LastName = lastName,
                        FirstName = firstName,
                        DateOfBirth = dob,
                        SocialSecurityNumber = ssn,
                        PhoneNumber = phone,
                        Gender = gender,
                        AddressLine1 = address1,
                        AddressLine2 = address2,
                        City = city,
                        State = state,
                        ZipCode = zip,
                        StartDate = startDate,
                        SalaryRecords = this.originalEmployee.SalaryRecords,
                        CertificationRecords = this.originalEmployee.CertificationRecords,
                        PositionRecords = this.originalEmployee.PositionRecords
                    };
                    this.employeeController.EditEmployee(this.originalEmployee, revisedEmployee);
                    string title = "Teacher Updated";
                    string message = "The teacher information has been updated. Click 'Okay' to continue.";
                    DialogResult dialogeResult = MessageBox.Show(message, title);
                    if (dialogeResult == DialogResult.OK)
                    {
                        this.referringControl.Enabled = true;
                        this.referringControl.FillDropDownList(revisedEmployee.EmployeeId);
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    this.labelErrorMessage.Text = "Form data not submitted." + ex.Message + " Please fix and try again. ";
                }
            }
        }

        /// <summary>
        /// Handler for button clicks of the Reset button.  Should reset the form to default values
        /// from the original employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.FillFormWithOriginalEmployeeInfo();
        }

         /// <summary>
        /// Fills form fields with original emplyee data
        /// </summary>
        private void FillFormWithOriginalEmployeeInfo()
        {
            this.textBoxFirstName.Text = this.originalEmployee.FirstName;
            this.textBoxLastName.Text = this.originalEmployee.LastName;
            this.dateTimePickerDOB.Value = this.originalEmployee.DateOfBirth;
            this.textBoxSSN.Text = this.originalEmployee.SocialSecurityNumber;
            this.textBoxPhoneNumber.Text = this.originalEmployee.PhoneNumber;
            this.comboBoxGender.Text = this.originalEmployee.Gender;
            this.textBoxAddress1.Text = this.originalEmployee.AddressLine1;
            this.textBoxAddress2.Text = this.originalEmployee.AddressLine2;
            this.textBoxCity.Text = this.originalEmployee.City;
            this.comboBoxState.Text = this.originalEmployee.State;
            this.textBoxZipCode.Text = this.originalEmployee.ZipCode;
            this.dateTimePickerStartDate.Value = this.originalEmployee.StartDate; 
        }

        /// <summary>
        /// Performs inital validation on the form fields.
        /// </summary>
        /// <returns>alert text to be displayed if errors are found (blank string if no errors)</returns>
        private string CheckInputFields()
        {
            String alertText = "";

            if (String.IsNullOrEmpty(this.textBoxLastName.Text))
            {
                alertText += "Patient first name cannot be blank. ";
            }
            if (String.IsNullOrEmpty(this.textBoxFirstName.Text))
            {
                alertText += "Patient last name cannot be blank. ";
            }
            if (DateTime.Compare(this.dateTimePickerDOB.Value, DateTime.Now) > 0)
            {
                alertText += "The date of birth cannot be in the future. ";
            }
            if (this.textBoxPhoneNumber.Text.Length != 14)
            {
                alertText += "Ten digit phone number is required of the following format: (xxx) xxx-xxxx";
            }
            if (String.IsNullOrEmpty(this.textBoxAddress1.Text))
            {
                alertText += "Address cannot be blank. ";
            }
            if (String.IsNullOrEmpty(this.comboBoxState.Text))
            {
                alertText += "State must be selected. ";
            }
            if (String.IsNullOrEmpty(this.textBoxCity.Text))
            {
                alertText += "City is required. ";
            }
            else if (char.IsLower(textBoxCity.Text[0]))
            {
                alertText += "City name should start with a capital letter. ";
            }
            if (this.textBoxZipCode.Text.Length != 5)
            {
                alertText += "Five digit zip number is required. ";
            }

            return alertText;
        }
    }
}
