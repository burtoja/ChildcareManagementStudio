
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
            this.tabPageListClassrooms = new System.Windows.Forms.TabPage();
            this.tabPageEditClass = new System.Windows.Forms.TabPage();
            this.tabPageAttendanceSheet = new System.Windows.Forms.TabPage();
            this.attendanceReportUserControl1 = new ChildcareManagementStudio.UserControls.ClassroomUserControls.AttendanceReportUserControl();
            this.tabPageSignInSheet = new System.Windows.Forms.TabPage();
            this.tabControlMainClassroom.SuspendLayout();
            this.tabPageAttendanceSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainClassroom
            // 
            this.tabControlMainClassroom.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMainClassroom.Controls.Add(this.tabPageListClassrooms);
            this.tabControlMainClassroom.Controls.Add(this.tabPageEditClass);
            this.tabControlMainClassroom.Controls.Add(this.tabPageAttendanceSheet);
            this.tabControlMainClassroom.Controls.Add(this.tabPageSignInSheet);
            this.tabControlMainClassroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainClassroom.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainClassroom.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMainClassroom.Name = "tabControlMainClassroom";
            this.tabControlMainClassroom.SelectedIndex = 0;
            this.tabControlMainClassroom.Size = new System.Drawing.Size(1013, 634);
            this.tabControlMainClassroom.TabIndex = 0;
            // 
            // tabPageListClassrooms
            // 
            this.tabPageListClassrooms.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageListClassrooms.Location = new System.Drawing.Point(4, 35);
            this.tabPageListClassrooms.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageListClassrooms.Name = "tabPageListClassrooms";
            this.tabPageListClassrooms.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageListClassrooms.Size = new System.Drawing.Size(1005, 595);
            this.tabPageListClassrooms.TabIndex = 1;
            this.tabPageListClassrooms.Text = "List Classrooms";
            // 
            // tabPageEditClass
            // 
            this.tabPageEditClass.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageEditClass.Location = new System.Drawing.Point(4, 35);
            this.tabPageEditClass.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEditClass.Name = "tabPageEditClass";
            this.tabPageEditClass.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEditClass.Size = new System.Drawing.Size(1005, 595);
            this.tabPageEditClass.TabIndex = 0;
            this.tabPageEditClass.Text = "Edit Class";
            // 
            // tabPageAttendanceSheet
            // 
            this.tabPageAttendanceSheet.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAttendanceSheet.Controls.Add(this.attendanceReportUserControl1);
            this.tabPageAttendanceSheet.Location = new System.Drawing.Point(4, 35);
            this.tabPageAttendanceSheet.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAttendanceSheet.Name = "tabPageAttendanceSheet";
            this.tabPageAttendanceSheet.Size = new System.Drawing.Size(1005, 595);
            this.tabPageAttendanceSheet.TabIndex = 2;
            this.tabPageAttendanceSheet.Text = "Generate Attendance Sheet";
            // 
            // attendanceReportUserControl1
            // 
            this.attendanceReportUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceReportUserControl1.Location = new System.Drawing.Point(0, 0);
            this.attendanceReportUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.attendanceReportUserControl1.Name = "attendanceReportUserControl1";
            this.attendanceReportUserControl1.Size = new System.Drawing.Size(1256, 744);
            this.attendanceReportUserControl1.TabIndex = 0;
            // 
            // tabPageSignInSheet
            // 
            this.tabPageSignInSheet.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSignInSheet.Location = new System.Drawing.Point(4, 35);
            this.tabPageSignInSheet.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSignInSheet.Name = "tabPageSignInSheet";
            this.tabPageSignInSheet.Size = new System.Drawing.Size(1005, 595);
            this.tabPageSignInSheet.TabIndex = 3;
            this.tabPageSignInSheet.Text = "Generate Sign-in Sheet";
            // 
            // MainClassroomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMainClassroom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainClassroomUserControl";
            this.Size = new System.Drawing.Size(1013, 634);
            this.tabControlMainClassroom.ResumeLayout(false);
            this.tabPageAttendanceSheet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainClassroom;
        private System.Windows.Forms.TabPage tabPageEditClass;
        private System.Windows.Forms.TabPage tabPageListClassrooms;
        private System.Windows.Forms.TabPage tabPageAttendanceSheet;
        private System.Windows.Forms.TabPage tabPageSignInSheet;
        private AttendanceReportUserControl attendanceReportUserControl1;
    }
}
