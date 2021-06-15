using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View
{
    /// <summary>
    /// Manages tha ctions on the main dashboard form
    /// </summary>
    public partial class MainDashboard : Form
    {
        private LoginForm theLoginForm;
        private PlaceholderUserControl placeholderUserControl;
        private readonly CredentialController theCredentialController;
        private string username;

        /// <summary>
        /// Constructor for the main dashboard form
        /// </summary>
        /// <param name="theInputLoginForm">reference to the referring login form</param>
        public MainDashboard(LoginForm theInputLoginForm)
        {
            InitializeComponent();
            this.SetTheLoginForm(theInputLoginForm);
            this.InitializePlaceholder();
            theCredentialController = new CredentialController();
            this.username = "";          
        }

        /// <summary>
        /// Initializes the placeholder UC for unimplemented tabs
        /// </summary>
        private void InitializePlaceholder()
        {
            this.placeholderUserControl = new PlaceholderUserControl();
            this.Controls.Add(this.placeholderUserControl);
            this.placeholderUserControl.Location = new System.Drawing.Point(266, 81);
        }

        /// <summary>
        /// The method sets username(nurse or admin) for the form and displays it along 
        /// with the full name of the user in upper right corner of the form
        /// </summary>
        /// <param name="inputUuserName"> The inputted user name </param>
        public void SetActiveUsername(String inputUserName)
        {
            this.username = inputUserName;
            //String realName = this.theCredentialController.GetUser(this.username).FullName;
            //this.activeUsernameLabel.Text = realName + " (" + this.username + ")";
        }

        /// <summary>
        /// Sets the Login form
        /// </summary>
        /// <param name="theInputLoginForm"> Inputted loginform </param>
        public void SetTheLoginForm(LoginForm theInputLoginForm)
        {
            this.theLoginForm = theInputLoginForm;
        }

        /// <summary>
        /// When logout link is clicked disable the dashboard and bring up the login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.theLoginForm.SetMainDashboard(this);
            this.theLoginForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Actions to perform when teacher tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTeacherTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 0);
            this.UpdateTabAppearance(this.buttonTeacherTab);
            this.teacherMainUserControl1.Show();
            this.placeholderUserControl.Hide();
        }

        /// <summary>
        /// Actions to perform when student tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStudentsTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 140);
            this.UpdateTabAppearance(this.buttonStudentsTab);
            this.teacherMainUserControl1.Hide();
            this.placeholderUserControl.Show();
            this.placeholderUserControl.setDescription(
                "This tab will provide the ability to manage the student \n" +
                "and parent information at the childcare facility. The ability \n" +
                "will be provided to view, add, and edit student information."
                );
        }

        /// <summary>
        /// Actions to perform when classroom tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClassroomsTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 280);
            this.UpdateTabAppearance(this.buttonClassroomsTab);
            this.teacherMainUserControl1.Hide();
            this.placeholderUserControl.Show();
            this.placeholderUserControl.setDescription(
                "This tab will provide the ability to manage the classrooms \n" +
                "at the facility. The ability will be provided for creating new \n" +
                "classes, assining students and teachers to those classes, \n" +
                "assigning the class to a room/location, etc. " 
                );
        }

        /// <summary>
        /// Actions to perform when financial tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        private void ButtonFinancialTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 420);
            this.UpdateTabAppearance(this.buttonFinancialTab);
            this.teacherMainUserControl1.Hide();
            this.placeholderUserControl.Show();
            this.placeholderUserControl.setDescription(
                "This tab will provide the ability to manage the financial \n" +
                "aspects of the facility. The ability will be provided to view \n" +
                "payments, record payments, view balances."
                );
        }

        /// <summary>
        /// Update the tabs to visually reflect the active tab
        /// </summary>
        /// <param name="activeButton">the active tab (most recently clicked)</param>
        private void UpdateTabAppearance(Button activeButton)
        {
            activeButton.BackColor = SystemColors.Control;
            activeButton.ForeColor = Color.Black;
            activeButton.FlatAppearance.BorderColor = SystemColors.Control;
            if (activeButton != this.buttonTeacherTab)
            {
                this.buttonTeacherTab.BackColor = Color.FromArgb(64, 64, 64);
                this.buttonTeacherTab.ForeColor = SystemColors.Control;
                this.buttonTeacherTab.FlatAppearance.BorderColor = Color.Black;
            } 
            if (activeButton != this.buttonStudentsTab)
            {
                this.buttonStudentsTab.BackColor = Color.FromArgb(64, 64, 64);
                this.buttonStudentsTab.ForeColor = SystemColors.Control;
                this.buttonStudentsTab.FlatAppearance.BorderColor = Color.Black;
            }
            if (activeButton != this.buttonClassroomsTab)
            {
                this.buttonClassroomsTab.BackColor = Color.FromArgb(64, 64, 64);
                this.buttonClassroomsTab.ForeColor = SystemColors.Control;
                this.buttonClassroomsTab.FlatAppearance.BorderColor = Color.Black;
            }
            if (activeButton != this.buttonFinancialTab)
            {
                this.buttonFinancialTab.BackColor = Color.FromArgb(64, 64, 64);
                this.buttonFinancialTab.ForeColor = SystemColors.Control;
                this.buttonFinancialTab.FlatAppearance.BorderColor = Color.Black;
            }

        }

    }
}
