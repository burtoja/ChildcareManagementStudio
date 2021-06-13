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
    /// <summary>
    /// This class will create and manage the add position record form
    /// </summary>
    public partial class AddPositionForm : Form
    {
        private readonly int employeeId;
        private readonly PositionTypeController positionTypeController;
        private readonly TeacherViewTeacherDetailUserControl referringUserControl;
        //private readonly List<string> positionTypeList;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="employeeId"></param>
        public AddPositionForm(int employeeId, TeacherViewTeacherDetailUserControl referringUserControl)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.referringUserControl = referringUserControl;
            this.positionTypeController = new PositionTypeController();
            this.FillDropDownList();
        }

        /// <summary>
        /// Fill combobox with position types from DB
        /// </summary>
        public void FillDropDownList()
        {
            List<string> positionTypeList = this.positionTypeController.GetPositionTypes();
            this.comboBoxPosition.DataSource = positionTypeList;
            this.comboBoxPosition.SelectedIndex = -1;
            this.comboBoxPosition.SelectedText = "--select--";
        }

        /// <summary>
        /// Close form on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for submit button clicks.  Submits data and closes form and returns
        /// control to the reffering control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.comboBoxPosition.SelectedIndex != -1)
            {
                string title = "Position Type Choice Error";
                string message = "Please choose a position type and resubmit.";
                MessageBox.Show(message, title);
            }
            else
            {
                PositionRecord record = new PositionRecord
                {
                    Type = this.comboBoxPosition.SelectedValue.ToString(),
                    SchoolYear = this.dateTimePickerExpirationDate.Value //TODO: Should we have effective date???? Answer before proceding
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
