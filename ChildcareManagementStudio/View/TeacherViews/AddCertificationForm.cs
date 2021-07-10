using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
using Microsoft.Data.Sqlite;
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
        private readonly ViewTeacherDetailUserControl referringUserControl;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="employeeId">the employeeId of the employee receiving the record</param>
        /// <param name="referringUserControl">the user control that called this form</param>
        public AddCertificationForm(int employeeId, ViewTeacherDetailUserControl referringUserControl)
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
            this.referringUserControl.Enabled = true;
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
                this.SubmitNewRecord();
                this.referringUserControl.Enabled = true;
                this.Close();
            }
            
        }

        /// <summary>
        /// Attempts to submit new record to DB
        /// </summary>
        private void SubmitNewRecord()
        {
            CertificationRecord record = new CertificationRecord
            {
                Type = this.textBoxDescriptionValue.Text,
                ExpirationDate = this.dateTimePickerExpirationDate.Value
            };
            try
            {
                this.certificationController.AddCertificationRecord(this.employeeId, record);
            }
            catch (SqliteException ex)
            {
                Console.WriteLine("TEST: " + ex.ErrorCode);
                if (ex.ErrorCode == -2147467259)
                {
                    string title = "Duplicate Record Error";
                    string message = "Error. This record matches anothed record on file for this employee.  " +
                        "Duplicate records are not allowed.  Please try again.";
                    MessageBox.Show(message, title);
                }
            }

        }

        /// <summary>
        /// Re-enable referring UC when X is clicked to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCertificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
        }
    }
}
