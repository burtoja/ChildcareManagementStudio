using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    /// <summary>
    /// This form will allow the user to choose the school year to be used in the referring form
    /// </summary>
    public partial class SelectSchoolYearForm : Form
    {
        private readonly SetupClassUserControl referringUserControl;
        private readonly SchoolYearController schoolYearController;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl"></param>
        public SelectSchoolYearForm(SetupClassUserControl referringUserControl)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.schoolYearController = new SchoolYearController();
            this.PopulateSchoolYearComboBox();
        }

        /// <summary>
        /// Populates the school year comboBox
        /// </summary>
        private void PopulateSchoolYearComboBox()
        {
            foreach (string current in this.schoolYearController.GetAllSchoolYears())
            {
                this.comboBoxSchoolYear.Items.Add(current);
            }
            this.comboBoxSchoolYear.Text = this.referringUserControl.GetSchoolYear();
        }

        /// <summary>
        /// Handler for cancel button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handler for form closing events.  Should re-enable the referring UC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSchoolYearForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.referringUserControl.SetSchoolYear(this.comboBoxSchoolYear.Text);
            this.Close();
        }
    }
}
