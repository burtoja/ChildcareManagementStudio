using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.View.ClassroomViews;
using System;
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
        private readonly TeacherClassroomAssignmentController teacherClassroomAssignmentController;
        private readonly StudentClassroomAssignmentController studentClassroomAssignmentController;
        private readonly StudentController studentController;
        public string schoolYear;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public SetupClassUserControl()
        {
            InitializeComponent();
            this.classRecordController = new ClassRecordController();
            this.teacherClassroomAssignmentController = new TeacherClassroomAssignmentController();
            this.studentClassroomAssignmentController = new StudentClassroomAssignmentController();
            this.studentController = new StudentController();
            this.SetSchoolYear();
            this.PopulateClassComboBox();
            this.PopulateSelectedTeacherList();
        }

        /// <summary>
        /// Sets the intial school year used for the page and sets the school year label to display it
        /// </summary>
        private void SetSchoolYear()
        {
            this.schoolYear = "2021-22";    // TODO:  Make this dynamic
            this.labelValueSchoolYear.Text = this.schoolYear;
        }

        /// <summary>
        /// Set school year to be used by the UC for populating various elements
        /// </summary>
        /// <param name="schoolYear">string representation of school year (i.e. "2020-21")</param>
        public void SetSchoolYear(string schoolYear)
        {
            this.schoolYear = schoolYear;    
            this.labelValueSchoolYear.Text = this.schoolYear;
        }

        /// <summary>
        /// Get the school year string
        /// </summary>
        /// <returns>sstring representation of school year</returns>
        public string GetSchoolYear()
        {
            return this.schoolYear;
        }

        /// <summary>
        /// Populate the class combo box with the current ClassReocrds for the set school year
        /// </summary>
        public void PopulateClassComboBox()
        {
            BindingList<ClassRecord> classRecords = new BindingList<ClassRecord>();
            this.comboBoxClass.DataSource = classRecords;
            this.comboBoxClass.ValueMember = "ClassId";
            this.comboBoxClass.DisplayMember = "Identifier";
            foreach (ClassRecord current in this.classRecordController.GetAllClassesForSchoolYear(this.schoolYear))
            {
                classRecords.Add(current);
            }           
            this.comboBoxClass.SelectedIndex = -1;
        }

        /// <summary>
        /// Populates the teacher listView with list from DB or appropriate message
        /// </summary>
        public void PopulateSelectedTeacherList()
        {
            this.listViewTeachers.Items.Clear();
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                ListViewItem item = new ListViewItem("No class chosen");
                this.listViewTeachers.Items.Add(item);
            }
            else if (this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.GetSelectedClassId()).Count == 0)
            {
                ListViewItem item = new ListViewItem("No teachers assigned");
                this.listViewTeachers.Items.Add(item);
            }
            else
            {
                foreach (TeacherClassroomAssignment current in this.teacherClassroomAssignmentController.GetTeacherClassroomAssignments(this.GetSelectedClassId()))
                {
                    ListViewItem item = new ListViewItem(current.Teacher.FullName.ToString());
                    this.listViewTeachers.Items.Add(item);
                }
            }
            this.listViewTeachers.Columns[0].Width = this.listViewTeachers.Width;
        }

        /// <summary>
        /// Populates listView with available students based on school year if class is selected
        /// </summary>
        public void PopulateAvailableStudentsListView()
        {
            this.listViewStudentsNotInClass.Items.Clear();
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                ListViewItem item = new ListViewItem("No class chosen");
                this.listViewStudentsNotInClass.Items.Add(item);
                this.listViewStudentsNotInClass.CheckBoxes = false;
            }
            else if (this.studentClassroomAssignmentController.GetAvailableStudents(this.schoolYear).Count == 0)
            {
                ListViewItem item = new ListViewItem("No students available");
                this.listViewStudentsNotInClass.Items.Add(item);
                this.listViewStudentsNotInClass.CheckBoxes = false;
            }
            else
            {
                foreach (Student current in this.studentClassroomAssignmentController.GetAvailableStudents(this.schoolYear))
                {
                    ListViewItem item = new ListViewItem(current.FullName.ToString());
                    item.SubItems.Add(current.StudentId.ToString());
                    this.listViewStudentsNotInClass.Items.Add(item);
                    this.listViewStudentsNotInClass.CheckBoxes = true;
                }
            }
            this.listViewStudentsNotInClass.Columns[0].Width = this.listViewStudentsNotInClass.Width;
        }

        /// <summary>
        /// Populates listView with assigned students if class is selected
        /// </summary>
        public void PopulateAssignedStudentsListView()
        {
            this.listViewStudentsInClass.Items.Clear();
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                ListViewItem item = new ListViewItem("No class chosen");               
                this.listViewStudentsInClass.Items.Add(item);
                this.listViewStudentsInClass.CheckBoxes = false;
            }
            else if (this.studentClassroomAssignmentController.GetStudentsInClass(this.GetSelectedClassId()).Count == 0)
            {
                ListViewItem item = new ListViewItem("No students assigned to this class");              
                this.listViewStudentsInClass.Items.Add(item);
                this.listViewStudentsInClass.CheckBoxes = false;
            }
            else
            {
                foreach (StudentClassroomAssignment current in this.studentClassroomAssignmentController.GetStudentsInClass(this.GetSelectedClassId()))
                {
                    ListViewItem item = new ListViewItem(current.Student.FullName.ToString());
                    item.SubItems.Add(current.Student.StudentId.ToString());
                    this.listViewStudentsInClass.Items.Add(item);
                    this.listViewStudentsInClass.CheckBoxes = true;
                }
            }
            this.listViewStudentsInClass.Columns[0].Width = this.listViewStudentsInClass.Width;
        }

        /// <summary>
        /// Get the classId for the selection in the comboBox
        /// </summary>
        /// <returns>ClassId for selected class (-1 if error)</returns>
        private int GetSelectedClassId()
        {
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                return -1;
            }
            else
            {
                return Int32.Parse(this.comboBoxClass.SelectedValue.ToString());
            }          
        }

        /// <summary>
        /// Set the text for the label showing the classroom of the selected class record
        /// </summary>
        public void SetClassroomValueLabel()
        {
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                this.labelValueClassroom.Text = "n/a";
            }
            else
            {
                int selectedClassroomId = Int32.Parse(this.comboBoxClass.SelectedValue.ToString());
                this.labelValueClassroom.Text = this.classRecordController.GetClassRecord(selectedClassroomId).Classroom.Location;
            }
               
        }

        /// <summary>
        /// Handles clicks of the dit teacher list button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditTeacherList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                string title = "No Class Chosen";
                string message = "Please choose a class and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                try
                {
                    ClassRecord selectedClassRecord = this.classRecordController.GetClassRecord(this.GetSelectedClassId());
                    SelectTeachersForClassForm selectTeacherForm = new SelectTeachersForClassForm(this, selectedClassRecord);
                    selectTeacherForm.Show();
                    this.Enabled = false;
                }
                catch (Exception)
                {
                    string title = "No Record of Class Found In Database";
                    string message = "Please choose a class and try again.";
                    MessageBox.Show(message, title);
                }              
            }           
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
                this.SetClassroomValueLabel();
                this.PopulateSelectedTeacherList();
                PopulateAvailableStudentsListView();
                PopulateAssignedStudentsListView();
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

        /// <summary>
        /// Handles click events from the change school year button.
        /// Opens up change school year form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeSchoolYear_Click(object sender, EventArgs e)
        {
            SelectSchoolYearForm selectSchoolYearForm = new SelectSchoolYearForm(this);
            selectSchoolYearForm.Show();
            this.Enabled = false;
        }

        /// <summary>
        /// Handles button clicks of the change classroom button which opens up the change classroom form if
        /// a valid class is selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeClassroom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                string title = "No Class Chosen";
                string message = "Please choose a class and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                try
                {
                    ChangeClassRecordClassroomForm form = new ChangeClassRecordClassroomForm(this, this.classRecordController.GetClassRecord(this.GetSelectedClassId()));
                    form.Show();
                    this.Enabled = false;
                }
                catch (Exception)
                {
                    string title = "No Record of Class Found In Database";
                    string message = "Please choose a class and try again.";
                    MessageBox.Show(message, title);
                }
            }
        }

        /// <summary>
        /// Handles the add student button click which adds selected available students to the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                string title = "No Class Chosen";
                string message = "Please choose a class and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                string errorMessage = "";
                ClassRecord classRecord = this.classRecordController.GetClassRecord(this.GetSelectedClassId());
                foreach (ListViewItem current in this.listViewStudentsNotInClass.Items)
                {
                    if (current.Checked)
                    {
                        int studentId = Int32.Parse(current.SubItems[1].Text);
                        StudentClassroomAssignment studentClassroomAssignment = new StudentClassroomAssignment()
                        {
                            Student = this.studentController.GetStudent(studentId),
                            ClassRecord = classRecord
                        };
                        try
                        {
                            this.studentClassroomAssignmentController.AddStudentClassroomAssignment(studentClassroomAssignment);
                        }
                        catch (InvalidOperationException)
                        {
                            errorMessage = "Classroom is at full capacity.";
                        }
                        catch (Exception ex)
                        {
                            errorMessage += "\r\n" + studentClassroomAssignment.Student.FullName;
                        }
                    }
                }
                if (errorMessage == "Classroom is at full capacity.")
                {
                    string title = "Classroom Capacity Reached";
                    string message = "The classroom has reached capacity and students cannot be added.";
                    MessageBox.Show(message, title);
                }
                else if (errorMessage != "")
                {
                    string title = "Error Adding Student(s)";
                    string message = "Errors were found when adding student(s). The following students were not updated:" + errorMessage;
                    MessageBox.Show(message, title);
                }
                PopulateAvailableStudentsListView();
                PopulateAssignedStudentsListView();
            }
        }

        /// <summary>
        /// Handles the remove student button click which removes selected students from the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.comboBoxClass.Text))
            {
                string title = "No Class Chosen";
                string message = "Please choose a class and try again.";
                MessageBox.Show(message, title);
            }
            else
            {
                string errorMessage = "";
                ClassRecord classRecord = this.classRecordController.GetClassRecord(this.GetSelectedClassId());
                foreach (ListViewItem current in this.listViewStudentsInClass.Items)
                {
                    if (current.Checked)
                    {
                        int studentId = Int32.Parse(current.SubItems[1].Text);
                        StudentClassroomAssignment studentClassroomAssignment = new StudentClassroomAssignment()
                        {
                            Student = this.studentController.GetStudent(studentId),
                            ClassRecord = classRecord
                        };
                        try
                        {
                            this.studentClassroomAssignmentController.DeleteStudentClassroomAssignment(studentClassroomAssignment);
                        }
                        catch (Exception ex)
                        {
                            errorMessage += "\r\n" + studentClassroomAssignment.Student.FullName;
                        }
                    }
                }
                if (errorMessage != "")
                {
                    string title = "Error Removing Student(s)";
                    string message = "Errors were found when removing student(s). The following students were not updated:" + errorMessage;
                    MessageBox.Show(message, title);
                }
                PopulateAvailableStudentsListView();
                PopulateAssignedStudentsListView();
            }
        }

    }
}
