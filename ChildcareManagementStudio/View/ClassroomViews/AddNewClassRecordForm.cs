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
    /// Creates and manages the add class form
    /// </summary>
    public partial class AddNewClassRecordForm : Form
    {
        private SetupClassUserControl referringUserControl;
        
        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl"></param>
        public AddNewClassRecordForm(SetupClassUserControl referringUserControl)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.referringUserControl.Enabled = false;
        }

        /// <summary>
        /// Handles cancel button clicks
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
