using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.TeacherViews
{
    public partial class AddSalaryForm : Form
    {
        private readonly int employeeId;
        private readonly SalaryController salaryController;
        private readonly TeacherViewTeacherDetailUserControl referringUserControl;

        public AddSalaryForm(int employeeId, TeacherViewTeacherDetailUserControl referringUserControl)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.salaryController = new SalaryController();
            this.referringUserControl = referringUserControl;
            this.referringUserControl.Enabled = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if ((double)this.numericUpDownRate.Value == 0.00)
            {
                string title = "Pay Rate Error";
                string message = "Pay rate cannot equal zero.  Please correct and resubmit the form.";
                MessageBox.Show(message, title);
            }
            else if ((double)this.numericUpDownRate.Value < 0.00)
            {
                string title = "Pay Rate Error";
                string message = "Pay rate cannot be negative.  Please correct and resubmit the form.";
                MessageBox.Show(message, title);
            }
            else
            {
                string title = "Submit Record Confirmation";
                string message = "Are you sure you want to add a new record with the following information: \n\n" +
                    "Rate: $" + this.numericUpDownRate.Value.ToString("F") + "/hour \n" +
                    "Effective Date: " + this.dateTimePickerEffectiveDate.Value.ToString("d");
                DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.SubmitNewRecord();
                    this.referringUserControl.Enabled = true;
                    this.Close();
                }
                
            }

        }

        /// <summary>
        /// Submit record based on foem fields and display confirmation dialog if no exceptions
        /// </summary>
        private void SubmitNewRecord()
        {
            SalaryRecord record = new SalaryRecord
            {
                Rate = (double)this.numericUpDownRate.Value,
                EffectiveDate = this.dateTimePickerEffectiveDate.Value
            };
            try
            {
                this.salaryController.AddSalaryRecord(this.employeeId, record);
                string title = "Success";
                string message = "Record has been added.";
                MessageBox.Show(message, title);
            } 
            catch (SqliteException ex)
            {
                Console.WriteLine("TEST: " + ex.ErrorCode) ;
                if (ex.ErrorCode == -2147467259)
                {
                    string title = "Duplicate Record Error";
                    string message = "Error. This record matches anothed record on file for this employee.  " +
                        "Duplicate records are not allowed.  Please try again.";
                    MessageBox.Show(message, title);
                }
            }
            
            
        }

    }
}
