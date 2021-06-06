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
    }
}
