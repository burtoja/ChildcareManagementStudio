using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
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
                SalaryRecord record = new SalaryRecord
                {
                    Rate = (double)this.numericUpDownRate.Value,
                    EffectiveDate = this.dateTimePickerEffectiveDate.Value
                };
                this.salaryController.AddSalaryRecord(this.employeeId, record);
                string title = "Success";
                string message = "Record has been added.";
                MessageBox.Show(message, title);
                this.referringUserControl.Enabled = true;
                this.Close();
            }

        }
    }
}
