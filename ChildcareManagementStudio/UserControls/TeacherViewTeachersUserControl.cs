using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    /// <summary>
    /// This class will serve to build and manage the user control which displays all teachers (employees)
    /// and allows for selecting a teacher (row) to view details
    /// </summary>
    public partial class TeacherViewTeachersUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private readonly PersonController personController;

        /// <summary>
        /// Constructor for the user control
        /// </summary>
        public TeacherViewTeachersUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.personController = new PersonController();
            this.PopulateListView();
        }

        /// <summary>
        /// Gets list of all emplyees and finds their associated Person to build information
        /// items and adds them to the list view
        /// </summary>
        private void PopulateListView()
        {
            List<Employee> employeeList = this.employeeController.GetAllEmployees();
            foreach (Employee current in employeeList)
            {
                Person person = this.GetPerson(current);
                ListViewItem item = new ListViewItem(person.LastName.ToString());
                item.SubItems.Add(person.FirstName.ToString());
                item.SubItems.Add(person.DateOfBirth.ToString("d"));
                item.SubItems.Add(person.PhoneNumber.ToString());
                this.listViewAllTeachers.Items.Add(item);
            }
        }

        /// <summary>
        /// Gets the Person associated with the Employee
        /// </summary>
        /// <param name="theEmployee">The Employee to retrieve information for</param>
        /// <returns></returns>
        private  Person GetPerson(Employee theEmployee)
        {
            return this.personController.GetPerson(theEmployee.PersonId);
        }

        //TODO: Implement button action when view teacher details user control complete

        public void ResetEmployeeListResults()
        {
            this.listViewAllTeachers.Items.Clear();
            this.PopulateListView();
        }

        /// <summary>
        /// Event handler for when view has visibility changed (when tab is selected).  It 
        /// causes the list to be refreshed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherViewTeachersUserControl_VisibleChanged(object sender, System.EventArgs e)
        {
            this.ResetEmployeeListResults();
        }
    }
}
