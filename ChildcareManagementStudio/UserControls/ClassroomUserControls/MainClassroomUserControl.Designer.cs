
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class MainClassroomUserControl
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
            this.tabControlMainClassroom = new System.Windows.Forms.TabControl();
            this.tabPageEditClassroom = new System.Windows.Forms.TabPage();
            this.tabPageListClassrooms = new System.Windows.Forms.TabPage();
            this.tabPageAttendanceSheet = new System.Windows.Forms.TabPage();
            this.tabControlMainClassroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainClassroom
            // 
            this.tabControlMainClassroom.Controls.Add(this.tabPageListClassrooms);
            this.tabControlMainClassroom.Controls.Add(this.tabPageEditClassroom);
            this.tabControlMainClassroom.Controls.Add(this.tabPageAttendanceSheet);
            this.tabControlMainClassroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainClassroom.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainClassroom.Name = "tabControlMainClassroom";
            this.tabControlMainClassroom.SelectedIndex = 0;
            this.tabControlMainClassroom.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainClassroom.TabIndex = 0;
            // 
            // tabPageEditClassroom
            // 
            this.tabPageEditClassroom.Location = new System.Drawing.Point(4, 30);
            this.tabPageEditClassroom.Name = "tabPageEditClassroom";
            this.tabPageEditClassroom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditClassroom.Size = new System.Drawing.Size(752, 481);
            this.tabPageEditClassroom.TabIndex = 0;
            this.tabPageEditClassroom.Text = "Edit Classroom";
            this.tabPageEditClassroom.UseVisualStyleBackColor = true;
            // 
            // tabPageListClassrooms
            // 
            this.tabPageListClassrooms.Location = new System.Drawing.Point(4, 30);
            this.tabPageListClassrooms.Name = "tabPageListClassrooms";
            this.tabPageListClassrooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListClassrooms.Size = new System.Drawing.Size(752, 481);
            this.tabPageListClassrooms.TabIndex = 1;
            this.tabPageListClassrooms.Text = "List Classrooms";
            this.tabPageListClassrooms.UseVisualStyleBackColor = true;
            // 
            // tabPageAttendanceSheet
            // 
            this.tabPageAttendanceSheet.Location = new System.Drawing.Point(4, 30);
            this.tabPageAttendanceSheet.Name = "tabPageAttendanceSheet";
            this.tabPageAttendanceSheet.Size = new System.Drawing.Size(752, 481);
            this.tabPageAttendanceSheet.TabIndex = 2;
            this.tabPageAttendanceSheet.Text = "Generate Attendance Sheet";
            this.tabPageAttendanceSheet.UseVisualStyleBackColor = true;
            // 
            // MainClassroomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMainClassroom);
            this.Name = "MainClassroomUserControl";
            this.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainClassroom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainClassroom;
        private System.Windows.Forms.TabPage tabPageEditClassroom;
        private System.Windows.Forms.TabPage tabPageListClassrooms;
        private System.Windows.Forms.TabPage tabPageAttendanceSheet;
    }
}
