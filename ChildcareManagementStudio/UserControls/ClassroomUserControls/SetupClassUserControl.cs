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
        private readonly TeacherClassroomAssignmentController teacherClassroomAssignmentController;
        private string schoolYear;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public SetupClassUserControl()
        {
            InitializeComponent();
            this.classRecordController = new ClassRecordController();
            this.classroomController = new ClassroomController();
            this.teacherClassroomAssignmentController = new TeacherClassroomAssignmentController();
            this.SetDefaultSchoolYear();
            this.PopulateClassComboBox();
            this.PopulateClassroomComboBox();
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
            BindingList<ClassRecord> classRecords = new BindingList<ClassRecord>();
            foreach (ClassRecord current in this.classRecordController.GetAllClassesForSchoolYear(this.schoolYear))
            {
                classRecords.Add(current);
            }
            this.comboBoxClass.DataSource = classRecords;
            this.comboBoxClass.ValueMember = "ClassId";
            this.comboBoxClass.DisplayMember = "Identifier";
            this.comboBoxClass.SelectedValue = -1;
        }

        /// <summary>
        /// Populate th Classroom comboBox with the available classrooms
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
        /// Populates the teacher listView with list from DB or appropriate message
        /// </summary>
        private void PopulateSelectedTeacherList()
        {
            this.listViewTeachers.Items.Clear();
            Console.WriteLine("Selected ClassRecord ID = " + this.GetSelectedClassId());
            if (this.GetSelectedClassId() == -1)
            {
                ListViewItem item = new ListViewItem("No class chosen");
                this.listViewTeachers.Items.Add(item);
            }
            else
            {
                try
                {
                    List<TeacherClassroomAssignment> teacherAssignmentList = this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.GetSelectedClassId());
                    foreach (TeacherClassroomAssignment current in teacherAssignmentList)
                    {
                        ListViewItem item = new ListViewItem(current.Teacher.FullName.ToString());
                        this.listViewTeachers.Items.Add(item);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("This exception is intentional (2).");
                    ListViewItem item = new ListViewItem("No teachers assigned");
                    this.listViewTeachers.Items.Add(item);
                }
            }
            this.listViewTeachers.Columns[0].Width = this.listViewTeachers.Width;
        }

        /// <summary>
        /// Get the classId for the selection in the comboBox
        /// </summary>
        /// <returns>ClassId for selected class</returns>
        private int GetSelectedClassId()
        {
            try
            {
                return Int32.Parse(this.comboBoxClass.SelectedValue.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("This exception is intentional (1).");
                return -1;
            }
        }

        public ClassRecord GetSelectedClassRecord()
        {
            return this.classRecordController.GetClassRecord(this.GetSelectedClassId());
            //TODO: Deal with exception
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

        /// <summary>
        /// Handles clicks of the dit teacher list button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditTeacherList_Click(object sender, EventArgs e)
        {
            SelectTeachersForClassForm selectTeacherForm = new SelectTeachersForClassForm(this);
            selectTeacherForm.Show();
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
                this.PopulateSelectedTeacherList();
            }
        }

        /// <summary>
        /// Handles click events of the New Class button and opens the appropriate form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewClass_Click(object sender, EventArgs e)
        {
            AddNewClassRecordForm addNewClassRecordForm = new AddNewClassRecordForm(this);
            addNewClassRecordForm.Show();
        }
    }
}
