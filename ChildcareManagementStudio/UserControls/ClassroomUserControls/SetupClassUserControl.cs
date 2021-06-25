using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Creates and manages the user control to manage class setup
    /// </summary>
    public partial class SetupClassUserControl : UserControl
    {
        private readonly ClassRecordController classRecordController;
        private readonly ClassroomController classroomController;
        private readonly ClassRecord classRecord;
        private string schoolYear;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public SetupClassUserControl()
        {
            InitializeComponent();
            this.classRecordController = new ClassRecordController();
            this.classroomController = new ClassroomController();
            this.classRecord = new ClassRecord();
            this.SetDefaultSchoolYear();
            this.PopulateClassComboBox();
            this.PopulateClassroomComboBox();
            this.PopulateSelectedTeacherList();
        }

        /// <summary>
        /// Sets the intial school year used for the page and sets the school year label to display it
        /// </summary>
        private void SetDefaultSchoolYear()
        {
            this.schoolYear = "2021-22";    // TODO:  Make this dynamic
            this.labelValueSchoolYear.Text = this.schoolYear;
        }

        /// <summary>
        /// Populate the class combo box with the current ClassReocrds for the set school year
        /// </summary>
        private void PopulateClassComboBox()
        {
            List<ClassRecord> classRecordList = new List<ClassRecord>();
            classRecordList = this.classRecordController.GetAllClassesForSchoolYear(this.schoolYear);
            BindingList<ClassRecord> classRecords = new BindingList<ClassRecord>();
            foreach (ClassRecord current in classRecordList)
            {
                classRecords.Add(current);
            }
            this.comboBoxClassroom.DataSource = classRecords;
            this.comboBoxClassroom.ValueMember = "Id";
            this.comboBoxClassroom.DisplayMember = "Location"; 
            this.comboBoxClassroom.SelectedIndex = -1;
            this.comboBoxClassroom.SelectedText = "--select--";
        }

        /// <summary>
        /// Populate th Classroom comboBox with the available classrooms
        /// </summary>
        private void PopulateClassroomComboBox()
        {
            List<Classroom> classroomList = new List<Classroom>();
            classroomList = this.classroomController.GetAllClassrooms();
            BindingList<Classroom> classrooms = new BindingList<Classroom>();
            foreach (Classroom current in classroomList)
            {
                classrooms.Add(current);
            }
            this.comboBoxClass.DataSource = classrooms;
            this.comboBoxClass.ValueMember = "";
            this.comboBoxClass.DisplayMember = "Identifier";
            this.comboBoxClass.SelectedIndex = -1;
            this.comboBoxClass.SelectedText = "--select--";
        }

        /// <summary>
        /// Populates the teacher listView
        /// </summary>
        private void PopulateSelectedTeacherList()
        {
            
        }

        /// <summary>
        /// Handles clicks of the dit teacher list button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditTeacherList_Click(object sender, EventArgs e)
        {

        }
    }
}
