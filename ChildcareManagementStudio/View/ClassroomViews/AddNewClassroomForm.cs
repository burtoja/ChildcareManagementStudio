using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
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
        /// Handles the submit button clicks to attempt to create new classroom entry in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.UserInputFormIsValid())
            {
                try
                {
                    Classroom newClassroom = new Classroom
                    {
                        Location = this.textBoxLocation.Text,
                        Capacity = Convert.ToInt32(Math.Round(this.numericUpDownCapacity.Value))
                    };
                    this.classroomController.CreateNewClassroom(newClassroom);
                    string title = "Classroom Created";
                    string message = "The classroom has been created in the system. Click 'Okay' to continue.";
                    DialogResult dialogeResult = MessageBox.Show(message, title);
                    if (dialogeResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string title = "Error Message";
                    string message = "An error was found:/n" +
                        ex.Message +
                        "/n/nThe classroom was NOT created. Click 'Okay' to continue.";
                    MessageBox.Show(message, title);
                }
            }
        }

        /// <summary>
        /// Verifies that the user has typed some text in the location text box.  Note that
        /// the number UpDown box is set to not allow for negative numbers to be submitted 
        /// even if they are typed in manually by the user
        /// </summary>
        /// <returns>true if length of text in textbox > 0</returns>
        private bool UserInputFormIsValid()
        {
            if (this.textBoxLocation.Text.Length < 1)
            {
                string title = "Location Not Entered";
                string message = "The classroom requires a description of the location.  " +
                    "Please click 'Okay' and add a location description and resubmit.";
                MessageBox.Show(message, title);
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Handles cancel button clicks to close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Listener for when form is closed.  This will execute operations to re-enable 
        /// the referring UC and update the data displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewClassroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
            this.referringUserControl.RefreshClassroomListView();
        }
    }
}
