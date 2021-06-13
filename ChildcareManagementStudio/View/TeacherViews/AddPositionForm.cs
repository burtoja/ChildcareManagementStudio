using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls;
using Microsoft.Data.Sqlite;
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
            positionTypeList.Insert(0, "Choose a Position...");
            this.comboBoxPosition.DataSource = positionTypeList;
        }

        /// <summary>
        /// Fill combobox with position types from DB
        /// </summary>
        public void FillSchoolYearDropDownList()
        {
            //List<string> schoolYearList = this.schoolYearController.GetAllSchoolYears();
            //schoolYearList.Insert(0, "Choose a School Year...");
            //this.comboBoxPosition.DataSource = schoolYearList;
        }

        /// <summary>
        /// Close form on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.referringUserControl.Enabled = true;
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
            if (this.comboBoxPosition.SelectedIndex == 0)
            {
                string title = "Position Type Choice Error";
                string message = "Please choose a position type and resubmit.";
                MessageBox.Show(message, title);
            }
            else if (this.comboBoxSchoolYear.SelectedIndex == 0)
            {
                string title = "Position Type Choice Error";
                string message = "Please choose a school year and resubmit.";
                MessageBox.Show(message, title);
            }
            else
            {
                string title = "Submit Record Confirmation";
                string message = "Are you sure you want to add a new record with the following information: \n\n" +
                    "Position: " + this.comboBoxPosition.SelectedValue + "\n" +
                    "School Year: " + this.comboBoxSchoolYear.SelectedValue + "\n" +
                    "Start Date: " + this.dateTimePickerStartDate.Value.ToString("d");
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
        /// Attempts to submit new record to DB
        /// </summary>
        private void SubmitNewRecord()
        {
            PositionRecord record = new PositionRecord
            {
                Type = this.comboBoxPosition.SelectedValue.ToString(),
                SchoolYear = this.comboBoxSchoolYear.SelectedValue.ToString(),
                //StartDate = this.dateTimePickerStartDate.Value
            };
            try
            {
                this.positionController.AddPositionRecord(this.employeeId, record);
                string title = "Success";
                string message = "Record has been added.";
                MessageBox.Show(message, title);
            }
            catch (SqliteException ex)
            {
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
