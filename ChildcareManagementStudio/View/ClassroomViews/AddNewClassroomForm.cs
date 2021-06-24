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


        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl">the userControl creating this form</param>
        public AddNewClassroomForm(ViewClassroomListUserControl referringUserControl)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
        }

        /// <summary>
        /// handles cance button clicks to close form and re-enable the referring UC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.Close();
        }
    }
}
