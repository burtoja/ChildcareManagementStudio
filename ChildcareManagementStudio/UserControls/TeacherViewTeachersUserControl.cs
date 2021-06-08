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
            this.PopulateListView();
        }

        private void PopulateListView()
        {
            List<Employee> employeeList = this.employeeController.GetAllEmployees();
            foreach (Employee current in employeeList)
            {
                ListViewItem item = new ListViewItem(current.EmployeeId.ToString());
                item.SubItems.Add("Placeholder Name for Testing");
                this.listViewAllTeachers.Items.Add(item);
            }
        }

    }
}
