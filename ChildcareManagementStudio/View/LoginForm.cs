using ChildcareManagementStudio.Controller;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View
{
    /// <summary>
    /// This class will create and manage actions for the login form
    /// </summary>
    public partial class LoginForm : Form
    {
        private MainDashboard theMainDashboard;
        private readonly CredentialController theCredentialController;

        /// <summary>
        /// Constructor for LoginForm to initialize components
        /// </summary>
        public LoginForm()
        {
            this.theMainDashboard = null;
            this.theCredentialController = new CredentialController();
            InitializeComponent();
        }

        /// <summary>
        /// Sets the mainDashboard to be manipulted by the login form
        /// </summary>
        /// <param name="currentMainDashboard"></param>
        public void SetMainDashboard(MainDashboard currentMainDashboard)
        {
            this.theMainDashboard = currentMainDashboard;
        }

        /// <summary>
        /// Executes the actions to check credentials and attempt to log in to the application.
        /// Passwords are hashed using SHA256 before being checked against the DB to prevent 
        /// passwords from being stored anywhere in the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.textBoxUsername.Text;

            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.textBoxPassword.Text));
                string passwordHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                try
                {
                    if (this.theCredentialController.CredentialsAreValid(username, passwordHash))
                    {
                        if (this.theMainDashboard == null)
                        {
                            this.theMainDashboard = new MainDashboard(this);
                        }
                        else
                        {
                            this.theMainDashboard.SetTheLoginForm(this);
                        }
                        this.theMainDashboard.SetActiveUsername(username);                      
                        this.theMainDashboard.Show();
                        this.textBoxPassword.Text = "";
                        this.Hide();
                    }
                    else
                    {
                        this.labelErrorMessage.Text = "Invalid username/password";
                    }
                }
                catch (ArgumentNullException ex)
                {
                    if (ex.ParamName == "username")
                        this.labelErrorMessage.Text = "Please enter a username";
                    else if (ex.ParamName == "password")
                        this.labelErrorMessage.Text = "Please enter a password";
                }
            }
            //TODO: Make credential controller with a CredentialsAreValid method stubbed in
            //TODO: Make SetTheLoginForm method in MainDashboard
            //TODO: Make SetActiveUsername method in MAinDashboard
        }

        /// <summary>
        /// Clear error messages when new text entered in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntryInTextbox(object sender, EventArgs e)
        {
            this.labelErrorMessage.Text = "";
        }

        /// <summary>
        /// Exit the application when exit button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
