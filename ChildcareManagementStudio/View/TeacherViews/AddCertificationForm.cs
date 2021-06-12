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
    public partial class AddCertificationForm : Form
    {
        private readonly int employeeId;
        private readonly CertificationController certificationController;
        private readonly TeacherViewTeacherDetailUserControl referringUserControl;

        public AddCertificationForm(int employeeId, TeacherViewTeacherDetailUserControl referringUserControl)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.certificationController = new CertificationController();
            this.referringUserControl = referringUserControl;
            this.referringUserControl.Enabled = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.textBoxDescriptionValue.Text == "")
            {
                string title = "Add Description";
                string message = "Please add a description for the certification.";
                MessageBox.Show(message, title);
            }
            else
            {
                CertificationRecord record = new CertificationRecord();
                record.Type = this.textBoxDescriptionValue.Text;
                record.ExpirationDate = this.dateTimePickerExpirationDate.Value;
                this.certificationController.AddCertificationRecord(this.employeeId, record);
                string title = "Success";
                string message = "Record has been add.";
                MessageBox.Show(message, title);
                this.referringUserControl.Enabled = true;
                this.Close();
            }
            
        }
    }
}
