using ChildcareManagementStudio.UserControls;
using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using ChildcareManagementStudio.UserControls.FinancialUserControls;
using ChildcareManagementStudio.UserControls.StudentUserControls;
using ChildcareManagementStudio.UserControls.TimeUserControls;
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
        private MainTeacherUserControl mainTeacherUserControl;
        private MainStudentUserControl mainStudentUserControl;
        private MainClassroomUserControl mainClassroomUserControl;
        private MainFinancialUserControl mainFinancialUserControl;
        private MainTimeUserControl mainTimeUserControl;
        private bool mouseDown;
        private Point lastLocation;

        /// <summary>
        /// Constructor for the main dashboard form
        /// </summary>
        /// <param name="theInputLoginForm">reference to the referring login form</param>
        public MainDashboard(LoginForm theInputLoginForm)
        {
            InitializeComponent();
            this.SetTheLoginForm(theInputLoginForm);
            this.InitializeUserControls();
        }

        /// <summary>
        /// Create instanctances of UCs, add them to the main dashboard in the appropriate locations
        /// </summary>
        private void InitializeUserControls()
        {
            this.mainTeacherUserControl = new MainTeacherUserControl();
            this.Controls.Add(this.mainTeacherUserControl);
            this.mainTeacherUserControl.Location = new System.Drawing.Point(266, 81);

            this.mainStudentUserControl = new MainStudentUserControl();
            this.Controls.Add(this.mainStudentUserControl);
            this.mainStudentUserControl.Location = new System.Drawing.Point(266, 81);
            this.mainStudentUserControl.Hide();

            this.mainClassroomUserControl = new MainClassroomUserControl();
            this.Controls.Add(this.mainClassroomUserControl);
            this.mainClassroomUserControl.Location = new System.Drawing.Point(266, 81);
            this.mainClassroomUserControl.Hide();

            this.mainFinancialUserControl = new MainFinancialUserControl();
            this.Controls.Add(this.mainFinancialUserControl);
            this.mainFinancialUserControl.Location = new System.Drawing.Point(266, 81);
            this.mainFinancialUserControl.Hide();

            this.mainTimeUserControl = new MainTimeUserControl();
            this.Controls.Add(this.mainTimeUserControl);
            this.mainTimeUserControl.Location = new System.Drawing.Point(266, 81);
            this.mainTimeUserControl.Hide();
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
            this.mainTeacherUserControl.Show();
            this.mainStudentUserControl.Hide();
            this.mainClassroomUserControl.Hide();
            this.mainFinancialUserControl.Hide();
            this.mainTimeUserControl.Hide();
        }

        /// <summary>
        /// Actions to perform when student tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStudentsTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 112);
            this.UpdateTabAppearance(this.buttonStudentsTab);
            this.mainTeacherUserControl.Hide();
            this.mainStudentUserControl.Show();
            this.mainClassroomUserControl.Hide();
            this.mainFinancialUserControl.Hide();
            this.mainTimeUserControl.Hide();
        }

        /// <summary>
        /// Actions to perform when classroom tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClassroomsTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 224);
            this.UpdateTabAppearance(this.buttonClassroomsTab);
            this.mainTeacherUserControl.Hide();
            this.mainStudentUserControl.Hide();
            this.mainClassroomUserControl.Show();
            this.mainFinancialUserControl.Hide();
            this.mainTimeUserControl.Hide();

        }

        /// <summary>
        /// Actions to perform when financial tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        private void ButtonFinancialTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 336);
            this.UpdateTabAppearance(this.buttonFinancialTab);
            this.mainTeacherUserControl.Hide();
            this.mainStudentUserControl.Hide();
            this.mainClassroomUserControl.Hide();
            this.mainFinancialUserControl.Show();
            this.mainTimeUserControl.Hide();
        }

        /// <summary>
        /// Actions to perform when time tab button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTimeTab_Click(object sender, EventArgs e)
        {
            this.panelTabIndicator.Location = new Point(3, 448);
            this.UpdateTabAppearance(this.buttonTimeTab);
            this.mainTeacherUserControl.Hide();
            this.mainStudentUserControl.Hide();
            this.mainClassroomUserControl.Hide();
            this.mainFinancialUserControl.Hide();
            this.mainTimeUserControl.Show();

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
            if (activeButton != this.buttonTimeTab)
            {
                this.buttonTimeTab.BackColor = Color.FromArgb(64, 64, 64);
                this.buttonTimeTab.ForeColor = SystemColors.Control;
                this.buttonTimeTab.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void PictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void PictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point((this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void PictureBoxLogo_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void LabelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point((this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LabelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = true;
            this.lastLocation = e.Location;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown)
            {
                this.Location = new Point((this.Location.X - this.lastLocation.X) + e.X, (this.Location.Y - this.lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDown = false;
        }
    }
}