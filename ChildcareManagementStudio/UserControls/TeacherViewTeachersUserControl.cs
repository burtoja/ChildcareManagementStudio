using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    public partial class TeacherViewTeachersUserControl : UserControl
    {

        private readonly EmployeeController employeeController;

        public TeacherViewTeachersUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
        }

        private void TeacherViewTeachersUserControl_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList = this.employeeController.GetAllEmployees();
            foreach(Employee current in employeeList)
            {
                ListViewItem item = new ListViewItem(current.EmployeeId.ToString());
                item.SubItems.Add("Placeholder Name for Testing");
                this.listViewAllTeachers.Items.Add(item);
            }
        }
    }
}
