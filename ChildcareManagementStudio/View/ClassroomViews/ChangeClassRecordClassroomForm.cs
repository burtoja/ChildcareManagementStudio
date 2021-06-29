using ChildcareManagementStudio.Controller;
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
        private readonly ClassroomController classroomController;
        private readonly ClassRecord classRecord;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl"></param>
        public ChangeClassRecordClassroomForm(SetupClassUserControl referringUserControl, ClassRecord classRecord)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
            this.classroomController = new ClassroomController();
            this.classRecord = classRecord;
            this.PopulateClassroomComboBox();
        }

        /// <summary>
        /// Populates the classroom comboBox from the DB
        /// </summary>
        private void PopulateClassroomComboBox()
        {
            BindingList<Classroom> classrooms = new BindingList<Classroom>();
            this.comboBoxClassroom.DataSource = classrooms;
            this.comboBoxClassroom.ValueMember = "Id";
            this.comboBoxClassroom.DisplayMember = "Location";
            foreach (Classroom current in this.classroomController.GetAllClassrooms())
            {
                classrooms.Add(current);
            }
            this.comboBoxClassroom.SelectedValue = this.classRecord.Classroom.Id;
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
