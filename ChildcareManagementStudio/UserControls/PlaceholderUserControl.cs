using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls
{
    public partial class PlaceholderUserControl : UserControl
    {
        /// <summary>
        /// Constructor for the placeholder UC. 
        /// </summary>
        public PlaceholderUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description">The description of the upcoming feature to be displayed on the UC</param>
        public void setDescription(string description)
        {
            this.labelDescription.Text = description;
        }
    }
}
