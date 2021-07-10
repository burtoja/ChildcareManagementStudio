using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    /// <summary>
    /// Creates and manages the main UC for this section
    /// </summary>
    public partial class MainTimeUserControl : UserControl
    {
        private readonly TimeClockUserControl timeClockUserControl;
        private readonly TimeSheetUserControl timeSheetUserControl;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public MainTimeUserControl()
        {
            InitializeComponent();
            this.timeClockUserControl = new TimeClockUserControl();
            this.timeSheetUserControl = new TimeSheetUserControl();
            this.AddUserControls();
        }

        /// <summary>
        /// Add the user controls to the proper tab pages
        /// </summary>
        private void AddUserControls()
        {
            this.tabPageTimeClock.Controls.Add(this.timeClockUserControl);
            this.tabPageTimeSheet.Controls.Add(this.timeSheetUserControl);
        }

        /// <summary>
        /// Event handler for selecting tabs within this section of the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlMainClassroom_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // View Tiem Clock tab

                    break;
                case 1:
                    // Edit Tiem Sheet tab

                    break;
            }
        }

        private void MainTimeUserControl_VisibleChanged(object sender, System.EventArgs e)
        {
            this.timeClockUserControl.PopulateDropDownList();
            this.timeSheetUserControl.PopulateDropDownList();
        }
    }
}
