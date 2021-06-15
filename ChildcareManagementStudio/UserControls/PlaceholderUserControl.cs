using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    public partial class PlaceholderUserControl : UserControl
    {
        /// <summary>
        /// Constructor for the placeholder UC. 
        /// </summary>
        /// <param name="messageCode">The description of the upcoming feature to be displayed on the UC</param>
        public PlaceholderUserControl(string description)
        {
            InitializeComponent();
            this.labelDescription.Text = description;
        }
    }
}
