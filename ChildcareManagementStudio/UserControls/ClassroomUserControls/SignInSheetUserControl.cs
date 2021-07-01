using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    /// <summary>
    /// Class will create and manage the sign-in sheet tab in the Classrooms section of the application
    /// </summary>
    public partial class SignInSheetUserControl : UserControl
    {
        private readonly SchoolYearDAL schoolYearDAL;
        private readonly ClassroomDAL classroomDAL;
        private readonly ClassRecordDAL classRecordDAL;
        private readonly StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public SignInSheetUserControl()
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

        /// <summary>
        /// Handles the report generation button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            reportViewerSignInSheet.RefreshReport();
        }
    }
}
