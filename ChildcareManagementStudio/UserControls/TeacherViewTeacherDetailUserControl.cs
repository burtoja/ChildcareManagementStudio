using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    public partial class TeacherViewTeacherDetailUserControl : UserControl
    {
        private readonly EmployeeController employeeController;

        public TeacherViewTeacherDetailUserControl()
        {
            this.employeeController = new EmployeeController();
            InitializeComponent();
            this.FillDropDownList();
        }

        public void FillDropDownList()
        {
            BindingList<Employee> employees = new BindingList<Employee>();
            foreach (Employee current in this.employeeController.GetAllEmployees())
            {
                employees.Add(current);
            }
            this.comboBoxName.DataSource = employees;
            this.comboBoxName.ValueMember = "PersonId";
            this.comboBoxName.DisplayMember = "FullName";
        }
    }
}
