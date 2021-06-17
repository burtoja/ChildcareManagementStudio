using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    public partial class MainStudentUserControl : UserControl
    {
        public MainStudentUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to listen for tab selected events and refresh the employee list when heard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlStudent_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // View All Student tab
                    
                    break;
                case 1:
                    // View Student Details tab
                    
                    break;
                case 2:
                    // Add New Student tab

                    break;
            }
        }
    }
}
