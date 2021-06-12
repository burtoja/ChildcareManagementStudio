using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.TeacherViews
{
    public partial class AddPositionForm : Form
    {
        private readonly int employeeId;

        public AddPositionForm(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }
    }
}
