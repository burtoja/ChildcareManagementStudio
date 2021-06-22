using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls.StudentUserControls;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.StudentViews
{
    public partial class EditStudentForm : Form
    {
        private readonly ViewStudentDetailUserControl referringControl;
        private readonly StudentController studentController;
        private readonly Student originalStudent;

        /// <summary>
        /// Constructor for the edit student form
        /// </summary>
        /// <param name="theStudent">the Student object to be edited</param>
        /// <param name="referingControl">the reffering user control</param>
        public EditStudentForm(Student theStudent, ViewStudentDetailUserControl referingControl)
        {
            InitializeComponent();
            this.referringControl = referingControl;
            this.studentController = new StudentController();
            this.originalStudent = theStudent;
            this.referringControl.Enabled = false;
            this.FillFormWithOriginalStudentInfo();
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
                try
                {
                    Student revisedStudent = new Student
                    {
                        PersonId = this.originalStudent.PersonId,
                        StudentId = this.originalStudent.StudentId,
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
                        VaccinationRecordExpirationDate = this.originalStudent.VaccinationRecordExpirationDate,
                        PhysicalExamExpirationDate = this.originalStudent.PhysicalExamExpirationDate
                    };
                    this.studentController.EditStudent(this.originalStudent, revisedStudent);
                    string title = "Student Updated";
                    string message = "The student information has been updated. Click 'Okay' to continue.";
                    DialogResult dialogeResult = MessageBox.Show(message, title);
                    if (dialogeResult == DialogResult.OK)
                    {
                        this.referringControl.Enabled = true;
                        this.referringControl.FillDropDownList(revisedStudent.StudentId);
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
            this.FillFormWithOriginalStudentInfo();
        }

        /// <summary>
        /// Fills form fields with original emplyee data
        /// </summary>
        private void FillFormWithOriginalStudentInfo()
        {
            this.textBoxFirstName.Text = this.originalStudent.FirstName;
            this.textBoxLastName.Text = this.originalStudent.LastName;
            this.dateTimePickerDOB.Value = this.originalStudent.DateOfBirth;
            this.textBoxSSN.Text = this.originalStudent.SocialSecurityNumber;
            this.textBoxPhoneNumber.Text = this.originalStudent.PhoneNumber;
            this.comboBoxGender.Text = this.originalStudent.Gender;
            this.textBoxAddress1.Text = this.originalStudent.AddressLine1;
            this.textBoxAddress2.Text = this.originalStudent.AddressLine2;
            this.textBoxCity.Text = this.originalStudent.City;
            this.comboBoxState.Text = this.originalStudent.State;
            this.textBoxZipCode.Text = this.originalStudent.ZipCode;
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
                alertText += "Student first name cannot be blank. ";
            }
            if (String.IsNullOrEmpty(this.textBoxFirstName.Text))
            {
                alertText += "Student last name cannot be blank. ";
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

        /// <summary>
        /// Handler to re-enable the referring UC when form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringControl.Enabled = true;
        }
    }
}
