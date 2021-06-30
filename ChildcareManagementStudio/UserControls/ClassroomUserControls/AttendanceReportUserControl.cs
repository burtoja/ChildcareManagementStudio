using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    public partial class AttendanceReportUserControl : UserControl
    {
        private readonly StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;
        private List<Student> studentsInClass;

        public AttendanceReportUserControl()
        {
            InitializeComponent();
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();
            List<StudentClassroomAssignment> assignments = studentClassroomAssignmentDAL.GetStudentsInClass(1);
            studentsInClass = new List<Student>();
            foreach (StudentClassroomAssignment assignment in assignments)
            {
                StudentBindingSource.Add(assignment.Student);
            }
            attendanceReportViewer.RefreshReport();
        }
    }
}
