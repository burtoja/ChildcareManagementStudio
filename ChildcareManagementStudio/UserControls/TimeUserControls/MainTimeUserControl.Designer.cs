
namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    partial class MainTimeUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMainTime = new System.Windows.Forms.TabControl();
            this.tabPageTimeClock = new System.Windows.Forms.TabPage();
            this.tabPageTimeSheet = new System.Windows.Forms.TabPage();
            this.tabControlMainTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainTime
            // 
            this.tabControlMainTime.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMainTime.Controls.Add(this.tabPageTimeClock);
            this.tabControlMainTime.Controls.Add(this.tabPageTimeSheet);
            this.tabControlMainTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainTime.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainTime.Name = "tabControlMainTime";
            this.tabControlMainTime.SelectedIndex = 0;
            this.tabControlMainTime.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainTime.TabIndex = 2;
            // 
            // tabPageTimeClock
            // 
            this.tabPageTimeClock.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTimeClock.Location = new System.Drawing.Point(4, 33);
            this.tabPageTimeClock.Name = "tabPageTimeClock";
            this.tabPageTimeClock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimeClock.Size = new System.Drawing.Size(752, 478);
            this.tabPageTimeClock.TabIndex = 1;
            this.tabPageTimeClock.Text = "Time Clock";
            // 
            // tabPageTimeSheet
            // 
            this.tabPageTimeSheet.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTimeSheet.Location = new System.Drawing.Point(4, 33);
            this.tabPageTimeSheet.Name = "tabPageTimeSheet";
            this.tabPageTimeSheet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimeSheet.Size = new System.Drawing.Size(752, 478);
            this.tabPageTimeSheet.TabIndex = 0;
            this.tabPageTimeSheet.Text = "Time Sheet";
            // 
            // MainTimeUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControlMainTime);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainTimeUserControl";
            this.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainTime;
        private System.Windows.Forms.TabPage tabPageTimeClock;
        private System.Windows.Forms.TabPage tabPageTimeSheet;
    }
}
