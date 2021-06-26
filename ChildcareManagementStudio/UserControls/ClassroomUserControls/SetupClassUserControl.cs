using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.View.ClassroomViews;
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
        public void PopulateClassComboBox()
        {
            List<ClassRecord> classRecordList = new List<ClassRecord>();
            classRecordList = this.classRecordController.GetAllClassesForSchoolYear(this.schoolYear);
            BindingList<ClassRecord> classRecords = new BindingList<ClassRecord>();
            foreach (ClassRecord current in classRecordList)
            {
                classRecords.Add(current);
            }
            this.comboBoxClass.DataSource = classRecords;
            this.comboBoxClass.ValueMember = "ClassId";
            this.comboBoxClass.DisplayMember = "Identifier";
            this.comboBoxClass.SelectedIndex = -1;
            this.comboBoxClass.SelectedText = "--select--";
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
            this.comboBoxClassroom.DataSource = classrooms;
            this.comboBoxClassroom.ValueMember = "Id";
            this.comboBoxClassroom.DisplayMember = "Location";
            this.comboBoxClassroom.SelectedIndex = -1;
            this.comboBoxClassroom.SelectedText = "--select--";
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

        /// <summary>
        /// Handles events from the ClassRecord comboBox selection being changed.
        /// Note: this fires when UC is initialized (not just when user changes selection)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxClass.SelectedIndex != -1)
            {
                this.SelectClassroomFromClassRecordComboBoxChoice();
            }
        }
        
        /// <summary>
        /// Attempt to set the selected index of the classroom comboBox based on the selected ClassRecord in the 
        /// classRecord comboBox
        /// </summary>
        private void SelectClassroomFromClassRecordComboBoxChoice()
        {
            int selectedClassroomId;
            try
            {
                selectedClassroomId = Int32.Parse(this.comboBoxClass.SelectedValue.ToString());
                this.comboBoxClassroom.SelectedValue = this.classRecordController.GetClassRecord(selectedClassroomId).Classroom.Id;
            }
            catch (Exception)
            {
                this.comboBoxClassroom.SelectedIndex = -1;
            }
        }

        private void ButtonNewClass_Click(object sender, EventArgs e)
        {
            AddNewClassRecordForm addNewClassRecordForm = new AddNewClassRecordForm(this);
            addNewClassRecordForm.Show();
        }
    }
}
