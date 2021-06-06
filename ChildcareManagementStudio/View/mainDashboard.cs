using ChildcareManagementStudio.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View
{
    /// <summary>
    /// Manages tha ctions on the main dashboard form
    /// </summary>
    public partial class MainDashboard : Form
    {
        private LoginForm theLoginForm;
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
            theCredentialController = new CredentialController();
            this.username = "";          
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
            this.buttonTeacherTab.BackColor = SystemColors.Control;
            this.buttonStudentsTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonClassroomsTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonFinancialTab.BackColor = Color.FromArgb(64, 64, 64);

            this.buttonTeacherTab.ForeColor = Color.Black;
            this.buttonStudentsTab.ForeColor = SystemColors.Control;
            this.buttonClassroomsTab.ForeColor = SystemColors.Control;
            this.buttonFinancialTab.ForeColor = SystemColors.Control;

            this.buttonTeacherTab.FlatAppearance.BorderColor = SystemColors.Control;
            this.buttonStudentsTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonClassroomsTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonFinancialTab.FlatAppearance.BorderColor = Color.Black;

            this.teacherMainUserControl1.Show();
        }

        /// <summary>
        /// Actions to perform when student tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStudentsTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 140);
            this.buttonTeacherTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonStudentsTab.BackColor = SystemColors.Control;
            this.buttonClassroomsTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonFinancialTab.BackColor = Color.FromArgb(64, 64, 64);

            this.buttonTeacherTab.ForeColor = SystemColors.Control;
            this.buttonStudentsTab.ForeColor = Color.Black;
            this.buttonClassroomsTab.ForeColor = SystemColors.Control;
            this.buttonFinancialTab.ForeColor = SystemColors.Control;

            this.buttonTeacherTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonStudentsTab.FlatAppearance.BorderColor = SystemColors.Control;
            this.buttonClassroomsTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonFinancialTab.FlatAppearance.BorderColor = Color.Black;

            this.teacherMainUserControl1.Hide();
        }

        /// <summary>
        /// Actions to perform when classroom tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClassroomsTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 280);
            this.buttonTeacherTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonStudentsTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonClassroomsTab.BackColor = SystemColors.Control;
            this.buttonFinancialTab.BackColor = Color.FromArgb(64, 64, 64);

            this.buttonTeacherTab.ForeColor = SystemColors.Control;
            this.buttonStudentsTab.ForeColor = SystemColors.Control;
            this.buttonClassroomsTab.ForeColor = Color.Black;
            this.buttonFinancialTab.ForeColor = SystemColors.Control;

            this.buttonTeacherTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonStudentsTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonClassroomsTab.FlatAppearance.BorderColor = SystemColors.Control;
            this.buttonFinancialTab.FlatAppearance.BorderColor = Color.Black;

            this.teacherMainUserControl1.Hide();
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
            this.buttonTeacherTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonStudentsTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonClassroomsTab.BackColor = Color.FromArgb(64, 64, 64);
            this.buttonFinancialTab.BackColor = SystemColors.Control;

            this.buttonTeacherTab.ForeColor = SystemColors.Control;
            this.buttonStudentsTab.ForeColor = SystemColors.Control;
            this.buttonClassroomsTab.ForeColor = SystemColors.Control;
            this.buttonFinancialTab.ForeColor = Color.Black;

            this.buttonTeacherTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonStudentsTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonClassroomsTab.FlatAppearance.BorderColor = Color.Black;
            this.buttonFinancialTab.FlatAppearance.BorderColor = SystemColors.Control;

            this.teacherMainUserControl1.Hide();
        }

    }
}
