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
        private readonly PersonController personController;

        public TeacherViewTeachersUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.personController = new PersonController();
            this.PopulateListView();
        }

        private void PopulateListView()
        {
            List<Employee> employeeList = this.employeeController.GetAllEmployees();
            foreach (Employee current in employeeList)
            {
                Person person = this.GetPerson(current);
                ListViewItem item = new ListViewItem(person.LastName.ToString());
                item.SubItems.Add(person.FirstName.ToString());
                item.SubItems.Add(person.DateOfBirth.ToString());
                item.SubItems.Add(person.PhoneNumber.ToString());
                this.listViewAllTeachers.Items.Add(item);
            }
        }

        private  Person GetPerson(Employee theEmployee)
        {
            return this.personController.GetPerson(theEmployee.PersonId);
        }

    }
}
