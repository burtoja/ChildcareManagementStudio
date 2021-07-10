using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    /// <summary>
    /// Creates and manages the add class form
    /// </summary>
    public partial class AddNewClassRecordForm : Form
    {
        private readonly SetupClassUserControl referringUserControl;
        private readonly ClassroomController classroomController;
        private readonly ClassRecordController classRecordController;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl"></param>
        public AddNewClassRecordForm(SetupClassUserControl referringUserControl)
        {
            InitializeComponent();
            this.classroomController = new ClassroomController();
            this.classRecordController = new ClassRecordController();
            this.referringUserControl = referringUserControl;
            this.referringUserControl.Enabled = false;
            this.SetSchoolYearLabelText();
            this.PopulateClassroomComboBox();
        }

        /// <summary>
        /// Set the value text of the school year label
        /// </summary>
        private void SetSchoolYearLabelText()
        {
            this.labelValueSchoolYear.Text = this.referringUserControl.GetSchoolYear();
        }

        /// <summary>
        /// Populate the Classroom comboBox with the available classrooms
        /// </summary>
        private void PopulateClassroomComboBox()
        {
            BindingList<Classroom> classrooms = new BindingList<Classroom>();
            foreach (Classroom current in this.classroomController.GetAllClassrooms())
            {
                classrooms.Add(current);
            }
            this.comboBoxClassroom.DataSource = classrooms;
            this.comboBoxClassroom.ValueMember = "Id";
            this.comboBoxClassroom.DisplayMember = "Location";
            this.comboBoxClassroom.SelectedIndex = -1;
            this.comboBoxClassroom.SelectedText = "--select--";
        }

        /// <summary>
        /// Submit button click handler to attwmpt to create new class from from information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                string title;
                string message;
                ClassRecord classRecord = new ClassRecord
                {
                    SchoolYear = this.referringUserControl.GetSchoolYear(),
                    Classroom = this.GetSelectedClassroom()
                };
                try
                {
                    this.classRecordController.AddClassRecord(classRecord);
                    title = "Class Created";
                    message = "The class was successfully created  Please click 'Okay' to continue.";
                }
                catch (SqliteException)
                {
                    title = "Duplicate Class Error";
                    message = "A class has already been created in this classroom for the selected school year. " +
                        "Duplicates are not allowed.  Please click 'Okay' to continue.";
                }
                DialogResult dialogeResult = MessageBox.Show(message, title);
                if (dialogeResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Method to verify that user has selected values for the comboboxes.  Displays alert dialog boxes if not.
        /// </summary>
        /// <returns>true if both combo boxes are selected</returns>
        private bool IsInputValid()
        {
            if (this.comboBoxClassroom.SelectedIndex == -1)
            {
                string title = "Classroom Location Not Selected";
                string message = "The classroom location has not been selected.  Please click 'Okay' and try again.";
                MessageBox.Show(message, title);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Get the Classroom object for the selection in the comboBox
        /// </summary>
        /// <returns>Classroom object for the selected room</returns>
        private Classroom GetSelectedClassroom()
        {
            int selectedClassroomId;
            try
            {
                selectedClassroomId = Int32.Parse(this.comboBoxClassroom.SelectedValue.ToString());
                return this.classroomController.GetClassroom(selectedClassroomId);
            }
            catch (Exception)
            {
                string title = "Classroom SelectionError";
                string message = "The selected classroom could not be found.  Please click 'Okay' and try again.";
                MessageBox.Show(message, title);
                return null;
            }
        }

        /// <summary>
        /// Handles cancel button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        /// <summary>
        /// Handles actions for when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewClassRecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.referringUserControl.PopulateClassComboBox();
        }

    }
}
