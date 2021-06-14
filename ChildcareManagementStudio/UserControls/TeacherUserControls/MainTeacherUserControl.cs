using ChildcareManagementStudio.Model;
using System.Drawing;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    /// <summary>
    /// This class will build and manage the main tab user control on the Teacher portion of the app
    /// </summary>
    public partial class TeacherMainUserControl : UserControl
    {
        /// <summary>
        /// Constructor for the control
        /// </summary>
        public TeacherMainUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to listen for tab selected events and refresh the employee list when heard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlTeacher_Selected(object sender, TabControlEventArgs e)
        {
            //this.teacherViewTeachersUserControl2.ResetEmployeeListResults();
            //this.teacherViewTeacherDetailUserControl1.FillDropDownList();
        }

    }
}
