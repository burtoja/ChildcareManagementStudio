using ChildcareManagementStudio.View.ClassroomViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    public partial class ViewClassroomListUserControl : UserControl
    {
        public ViewClassroomListUserControl()
        {
            InitializeComponent();
        }

        private void ButtonAddNewClassroom_Click(object sender, EventArgs e)
        {
            AddNewClassroomForm addNewClassroomForm = new AddNewClassroomForm(this);
            addNewClassroomForm.Show();
            this.Enabled = false;
        }
    }
}
