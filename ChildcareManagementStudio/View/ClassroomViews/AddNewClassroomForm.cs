using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using System;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    /// <summary>
    /// Date	Client	Activity	Start Time	End Time	Billable Hours	Rate (/hr)	Total	Balance	Notes:																
    /// </summary>
    public partial class AddNewClassroomForm : Form
    {
        private readonly ViewClassroomListUserControl referringUserControl;
        private readonly ClassroomController classroomController;


        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl">the userControl creating this form</param>
        public AddNewClassroomForm(ViewClassroomListUserControl referringUserControl)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.classroomController = new ClassroomController();
        }

        /// <summary>
        /// Handles cancel button clicks to close form and re-enable the referring UC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Handles the submit button clicks to attempt to create new classroom entry in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.classroomController.addNewClassroom(Classroom)
        }
    }
}
