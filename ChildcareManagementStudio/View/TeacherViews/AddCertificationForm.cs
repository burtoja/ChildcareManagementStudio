using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.TeacherViews
{
    /// <summary>
    /// This class will create and manage the add certification form
    /// </summary>
    public partial class AddCertificationForm : Form
    {
        private readonly int employeeId;
        private readonly CertificationController certificationController;
        private readonly TeacherViewTeacherDetailUserControl referringUserControl;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="employeeId">the employeeId of the employee receiving the record</param>
        /// <param name="referringUserControl">the user control that called this form</param>
        public AddCertificationForm(int employeeId, TeacherViewTeacherDetailUserControl referringUserControl)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.certificationController = new CertificationController();
            this.referringUserControl = referringUserControl;
            this.referringUserControl.Enabled = false;
        }

        /// <summary>
        /// Handles cancel button clicks and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles submit button clicks and attempts to add a new record to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.textBoxDescriptionValue.Text == "")
            {
                string title = "Empty Description Error";
                string message = "Please add a description for the certification and resubmit.";
                MessageBox.Show(message, title);
            }
            else
            {
                CertificationRecord record = new CertificationRecord
                {
                    Type = this.textBoxDescriptionValue.Text,
                    ExpirationDate = this.dateTimePickerExpirationDate.Value
                };
                this.certificationController.AddCertificationRecord(this.employeeId, record);
                string title = "Success";
                string message = "Record has been added.";
                MessageBox.Show(message, title);
                this.referringUserControl.Enabled = true;
                this.Close();
            }
            
        }
    }
}
