using ChildcareManagementStudio.UserControls.ClassroomUserControls;
using System.Windows.Forms;

namespace ChildcareManagementStudio.View.ClassroomViews
{
    /// <summary>
    /// Creates and manages the form used to select teachers to associate with the class
    /// </summary>
    public partial class SelectTeachersForClassForm : Form
    {
        private readonly SetupClassUserControl referringUserControl;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="referringUserControl">The userControl opening this form</param>
        public SelectTeachersForClassForm(SetupClassUserControl referringUserControl)
        {
            InitializeComponent();
            this.referringUserControl = referringUserControl;
        }

        private void SetClassReord()
        {
            this.labelClassIdentifier.Text = this.referringUserControl.GetSelectedClassRecord().Identifier;
        }

        private void PopulateTeacherListView()
        {

        }
    }
}
