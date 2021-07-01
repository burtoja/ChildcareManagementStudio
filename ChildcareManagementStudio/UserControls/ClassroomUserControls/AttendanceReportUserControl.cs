using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// User control for selecting and viewing the weekly attendance report.
    /// </summary>
    public partial class AttendanceReportUserControl : UserControl
    {
        private readonly SchoolYearDAL schoolYearDAL;
        private readonly ClassroomDAL classroomDAL;
        private readonly ClassRecordDAL classRecordDAL;
        private readonly StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        /// <summary>
        /// Constructor for the attendance report user control.
        /// </summary>
        public AttendanceReportUserControl()
        {
            InitializeComponent();

            schoolYearDAL = new SchoolYearDAL();
            classroomDAL = new ClassroomDAL();
            classRecordDAL = new ClassRecordDAL();
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();

            List<string> schoolYears = schoolYearDAL.GetAllSchoolYears();
            List<Classroom> classrooms = classroomDAL.GetAllClassrooms();

            schoolYearComboBox.DataSource = schoolYears;
            classComboBox.DataSource = classrooms;

            schoolYearComboBox.SelectedIndex = schoolYears.Count - 1;
        }

        private void GenerateReportButton_Click(object sender, System.EventArgs e)
        {
            StudentBindingSource.Clear();
            int classId = 0;
            try
            {
                int classroomId = (int)classComboBox.SelectedValue;
                string schoolYear = schoolYearComboBox.Text;
                classId = classRecordDAL.GetClassId(classroomId, schoolYear);
            }
            catch
            {
                MessageBox.Show("The selected combination of class and school year does not exist in the database.", "Invalid Class");
                return;
            }
            
            List<StudentClassroomAssignment> assignments = studentClassroomAssignmentDAL.GetStudentsInClass(classId);
            foreach (StudentClassroomAssignment assignment in assignments)
            {
                StudentBindingSource.Add(assignment.Student);
            }
            attendanceReportViewer.RefreshReport();
        }
    }
}