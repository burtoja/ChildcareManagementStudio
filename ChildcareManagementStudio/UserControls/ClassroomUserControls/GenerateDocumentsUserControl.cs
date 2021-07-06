using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// User control for selecting and viewing the weekly attendance report.
    /// </summary>
    public partial class GenerateDocumentsUserControl : UserControl
    {
        private readonly SchoolYearDAL schoolYearDAL;
        private readonly ClassroomDAL classroomDAL;
        private readonly ClassRecordDAL classRecordDAL;
        private readonly StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        /// <summary>
        /// Constructor for the attendance report user control.
        /// </summary>
        public GenerateDocumentsUserControl()
        {
            InitializeComponent();

            schoolYearDAL = new SchoolYearDAL();
            classroomDAL = new ClassroomDAL();
            classRecordDAL = new ClassRecordDAL();
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();

            this.UpdateComboBoxes();
        }

        /// <summary>
        /// Populates (or updates) the values in both combo boxes based on current data in database
        /// </summary>
        public void UpdateComboBoxes()
        {
            List<string> schoolYears = schoolYearDAL.GetAllSchoolYears();
            List<Classroom> classrooms = classroomDAL.GetAllClassrooms();

            comboBoxSchoolYear.DataSource = schoolYears;
            comboBoxClass.DataSource = classrooms;

            comboBoxSchoolYear.SelectedIndex = schoolYears.Count - 1;
        }

        /// <summary>
        /// Handles button clicks for the generate report button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateReport_Click(object sender, System.EventArgs e)
        {
            int classId;
            try
            {
                int classroomId = (int)comboBoxClass.SelectedValue;
                string schoolYear = comboBoxSchoolYear.Text;
                classId = classRecordDAL.GetClassId(classroomId, schoolYear);
            }
            catch
            {
                MessageBox.Show("The selected combination of class and school year does not exist in the database.", "Invalid Class");
                return;
            }

            List<StudentClassroomAssignment> assignments = studentClassroomAssignmentDAL.GetStudentsInClass(classId);
            ReportWriter reportWriter = new ReportWriter(assignments);
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Attendance Sheet - " + comboBoxClass.Text + " - " + comboBoxSchoolYear.Text;
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                reportWriter.WriteAttendanceSheet(saveFileDialog.FileName);
                MessageBox.Show("The attendance sheet was successfully saved.");
            }
        }

        private void GenerateSignInSheetButton_Click(object sender, EventArgs e)
        {
            int classId;
            try
            {
                int classroomId = (int)comboBoxClass.SelectedValue;
                string schoolYear = comboBoxSchoolYear.Text;
                classId = classRecordDAL.GetClassId(classroomId, schoolYear);
            }
            catch
            {
                MessageBox.Show("The selected combination of class and school year does not exist in the database.", "Invalid Class");
                return;
            }

            List<StudentClassroomAssignment> assignments = studentClassroomAssignmentDAL.GetStudentsInClass(classId);
            ReportWriter reportWriter = new ReportWriter(assignments);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Sign In Sheet - " + comboBoxClass.Text + " - " + comboBoxSchoolYear.Text;
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                reportWriter.WriteSignInSheet(saveFileDialog.FileName);
                MessageBox.Show("The sign-in sheet was successfully saved.");
            }
        }
    }
}