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
    /// <summary>
    /// Creates and manages the add class form
    /// </summary>
    public partial class AddNewClassRecordForm : Form
    {
        private SetupClassUserControl referringUserControl;
        private readonly ClassroomController classroomController;
        private readonly SchoolYearController schoolYearController;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl"></param>
        public AddNewClassRecordForm(SetupClassUserControl referringUserControl)
        {
            InitializeComponent();
            this.classroomController = new ClassroomController();
            this.schoolYearController = new SchoolYearController();
            this.referringUserControl = referringUserControl;
            this.referringUserControl.Enabled = false;
            this.PopulateSchoolYearComboBox();
            this.PopulateClassroomComboBox();
        }

        /// <summary>
        /// Populate the school year combo box with values from dB
        /// </summary>
        private void PopulateSchoolYearComboBox()
        {
            List<string> schoolYearList = new List<string>();
            schoolYearList = this.schoolYearController.GetAllSchoolYears();
            //BindingList<string> schoolYears = new BindingList<string>();
            foreach (string current in schoolYearList)
            {
                this.comboBoxSchoolYear.Items.Add(current);
            }
        }

        /// <summary>
        /// Populate the Classroom comboBox with the available classrooms
        /// </summary>
        private void PopulateClassroomComboBox()
        {
            List<Classroom> classroomList = new List<Classroom>();
            classroomList = this.classroomController.GetAllClassrooms();
            BindingList<Classroom> classrooms = new BindingList<Classroom>();
            foreach (Classroom current in classroomList)
            {
                classrooms.Add(current);
            }
            this.comboBoxClassroom.DataSource = classrooms;
            this.comboBoxClassroom.ValueMember = "Id";
            this.comboBoxClassroom.DisplayMember = "Location";
            this.comboBoxClassroom.SelectedIndex = -1;
            this.comboBoxClassroom.SelectedText = "--select--";
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
