using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.TeacherViews
{
    /// <summary>
    /// This class will create and manage the add position record form
    /// </summary>
    public partial class AddPositionForm : Form
    {
        private readonly int employeeId;
        private readonly PositionController positionController;
        private readonly PositionTypeController positionTypeController;
        //private readonly SchoolYearController schoolYearController;
        private readonly TeacherViewTeacherDetailUserControl referringUserControl;
        //private readonly List<string> positionTypeList;
        //private readonly List<string> schoolYearList;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="employeeId"></param>
        public AddPositionForm(int employeeId, TeacherViewTeacherDetailUserControl referringUserControl)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.referringUserControl = referringUserControl;
            this.positionController = new PositionController();
            this.positionTypeController = new PositionTypeController();
            //this.schoolYearController = new SchoolYearController();
            this.FillPositionTypeDropDownList();
            this.FillSchoolYearDropDownList();
        }

        /// <summary>
        /// Fill combobox with position types from DB
        /// </summary>
        public void FillPositionTypeDropDownList()
        {
            List<string> positionTypeList = this.positionTypeController.GetAllPositionTypes();
            this.comboBoxPosition.DataSource = positionTypeList;
            this.comboBoxPosition.SelectedIndex = -1;
            this.comboBoxPosition.SelectedText = "--select--";
        }

        /// <summary>
        /// Fill combobox with position types from DB
        /// </summary>
        public void FillSchoolYearDropDownList()
        {
            //List<string> schoolYearList = this.schoolYearController.GetAllSchoolYears();
            //this.comboBoxPosition.DataSource = schoolYearList;
            //this.comboBoxPosition.SelectedIndex = -1;
            //this.comboBoxPosition.SelectedText = "--select--";
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
                    SchoolYear = this.comboBoxSchoolYear.SelectedValue.ToString(),
                    //StartDate = this.dateTimePickerStartDate.Value
                };
                this.positionController.AddPositionRecord(this.employeeId, record);
                string title = "Success";
                string message = "Record has been added.";
                MessageBox.Show(message, title);
                this.referringUserControl.Enabled = true;
                this.Close();
            }

        }
    }
}
