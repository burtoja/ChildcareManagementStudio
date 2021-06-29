using ChildcareManagementStudio.Model;
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
    public partial class ChangeClassRecordClassroomForm : Form
    {
        private readonly SetupClassUserControl referringUserControl;
        private readonly ClassRecord classRecord;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl"></param>
        public ChangeClassRecordClassroomForm(SetupClassUserControl referringUserControl, ClassRecord classRecord)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.classRecord = classRecord;
        }

        /// <summary>
        /// Handles cancel button click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// HAndles form close events.  SHoudl re-enable referring UC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeClassRecordClassroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.referringUserControl.Enabled = true;
        }
    }
}
