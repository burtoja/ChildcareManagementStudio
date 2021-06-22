using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using ChildcareManagementStudio.View.StudentViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    /// <summary>
    /// This class will create and manage the student detail user control
    /// </summary>
    public partial class ViewStudentDetailUserControl : UserControl
    {
        private readonly StudentController studentController;
        //private readonly VaccineRecordController vaccineRecordController;     //TODO: Uncomment when controllers created
        //private readonly PhysicalExamController physicalExamController;       //TODO: Uncomment when controllers created
        private List<Student> studentList;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public ViewStudentDetailUserControl()
        {
            this.studentController = new StudentController();
            //this.vaccineRecordController = new VaccineRecordController();   //TODO: Uncomment when controllers created
            //this.physicalExamController = new PhysicalExamController();     //TODO: Uncomment when controllers created
            InitializeComponent();
        }

        /// <summary>
        /// Fills the Name combobox with names of students stored in DB
        /// </summary>
        public void FillDropDownList()
        {
            this.studentList = this.studentController.GetAllStudents();
            BindingList<Student> students = new BindingList<Student>();
            foreach (Student current in this.studentList)
            {
                students.Add(current);
            }
            this.comboBoxName.DataSource = students;
            this.comboBoxName.ValueMember = "StudentId";
            this.comboBoxName.DisplayMember = "FullName";
            this.comboBoxName.SelectedIndex = -1;
            this.comboBoxName.SelectedText = "--select--";
            this.ResetFormValues();
        }

        /// <summary>
        /// Fills comboboxes with names of students in DB and preselects the indicated student
        /// </summary>
        /// <param name="presetStudentId"></param>
        public void FillDropDownList(int presetStudentId)
        {
            this.FillDropDownList();
            this.comboBoxName.SelectedValue = presetStudentId;
        }

        /// <summary>
        /// Resets student details to empty
        /// </summary>
        private void ResetFormValues()
        {
            this.labelValueDOB.Text = "";
            this.labelValueSSN.Text = "";
            this.labelValuePhone.Text = "";
            this.labelValueGender.Text = "";
            this.labelValueAddress1.Text = "";
            this.labelValueAddress2.Text = "";
            this.labelValueCity.Text = "";
            this.labelValueState.Text = "";
            this.labelValueZipCode.Text = "";
            this.listViewVaccinationRecords.Items.Clear();
            this.listViewPhysicalExamRecords.Items.Clear();           
        }

        /// <summary>
        /// Display the student details from the DB
        /// </summary>
        /// <param name="studentId"></param>
        private void FillFormValues(int studentId)
        {
            Student student = this.studentController.GetStudent(studentId);
            this.labelValueDOB.Text = student.DateOfBirth.ToString("d");
            this.labelValueSSN.Text = student.SocialSecurityNumber;
            this.labelValuePhone.Text = student.PhoneNumber;
            this.labelValueGender.Text = student.Gender;
            this.labelValueAddress1.Text = student.AddressLine1;
            this.labelValueAddress2.Text = student.AddressLine2 ?? "n/a";
            this.labelValueCity.Text = student.City;
            this.labelValueState.Text = student.State;
            this.labelValueZipCode.Text = student.ZipCode;
        }

        ///// <summary>
        ///// Populate the listview with the students's vaccination records.
        ///// </summary>
        ///// <param name="studentId"></param>
        //private void PopulateVaccinationRecordsListView(int studentId)
        //{
        //    this.listViewVaccinationRecords.Items.Clear();
        //    List<VaccinationRecord> vaccinationList = this.vaccinationRecordController.GetVaccinationRecords(studentId);
        //    foreach (VaccinationRecord current in vaccinationList)
        //    {
        //        ListViewItem item = new ListViewItem(current.Type);
        //        item.SubItems.Add(current.SchoolYear);                  //TODO: Correct this field
        //        this.listViewVaccinationRecords.Items.Add(item);
        //    }
        //}

        ///// <summary>
        ///// Populate the listview with the students's physical exam records.
        ///// </summary>
        ///// <param name="studentId"></param>
        //private void PopulatePhysicalExamRecordsListView(int studentId)
        //{
        //    this.listViewVaccinationRecords.Items.Clear();
        //    List<PhysicalExamRecord> physicalExamList = this.physicalExamRecordController.GetPhysicalExamRecords(studentId);
        //    foreach (PhysicalExamRecord current in physicalExamList)
        //    {
        //        ListViewItem item = new ListViewItem(current.Type);
        //        item.SubItems.Add(current.SchoolYear);                  //TODO: correct this field
        //        this.listViewVaccinationRecords.Items.Add(item);
        //    }
        //}

        /// <summary>
        /// When new value chosen in combobox the displayed student details update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.UpdateFormValues();
        }

        /// <summary>
        /// Updates form values based on selected student
        /// </summary>
        private void UpdateFormValues()
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int studentId);
                    this.FillFormValues(studentId);
                    //this.PopulateVaccinationRecordsListView(studentId);        //TODO: Uncomment when controllers created
                    //this.PopulatePhysicalExamRecordsListView(studentId);       //TODO: Uncomment when controllers created
                }
                catch
                {
                    this.ResetFormValues();
                }
            }
        }

        /// <summary>
        /// Displays a message box for not choosing a student when needed
        /// </summary>
        private void DisplayChooseStudentErrorBox()
        {
            string title = "No Student Chosen";
            string message = "Please choose a student to edit.";
            MessageBox.Show(message, title);
        }

        /// <summary>
        /// Handles events needed to open the edit student form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEditStudent_Click(object sender, EventArgs e)
        {
            if (this.comboBoxName.SelectedIndex != -1)
            {
                try
                {
                    Int32.TryParse(this.comboBoxName.SelectedValue.ToString(), out int studentId);
                    Student student = this.studentController.GetStudent(studentId);
                    EditStudentForm editStudentForm = new EditStudentForm(student, this);        //TODO: Uncomment when edit student form created
                    editStudentForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }
            }
            else
            {
                this.DisplayChooseStudentErrorBox();
            }
        }





    }
}
