
namespace ChildcareManagementStudio.UserControls
{
    partial class TeacherMainUserControl
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
            this.tabControlTeacher = new System.Windows.Forms.TabControl();
            this.tabViewAllTeachers = new System.Windows.Forms.TabPage();
            this.tabViewTeacherDetails = new System.Windows.Forms.TabPage();
            this.tabAddTeacher = new System.Windows.Forms.TabPage();
            this.tabControlTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTeacher
            // 
            this.tabControlTeacher.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlTeacher.Controls.Add(this.tabViewAllTeachers);
            this.tabControlTeacher.Controls.Add(this.tabViewTeacherDetails);
            this.tabControlTeacher.Controls.Add(this.tabAddTeacher);
            this.tabControlTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTeacher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTeacher.Location = new System.Drawing.Point(0, 0);
            this.tabControlTeacher.Name = "tabControlTeacher";
            this.tabControlTeacher.SelectedIndex = 0;
            this.tabControlTeacher.Size = new System.Drawing.Size(760, 515);
            this.tabControlTeacher.TabIndex = 0;
            this.tabControlTeacher.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlTeacher_Selected);
            // 
            // tabViewAllTeachers
            // 
            this.tabViewAllTeachers.Location = new System.Drawing.Point(4, 34);
            this.tabViewAllTeachers.Name = "tabViewAllTeachers";
            this.tabViewAllTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAllTeachers.Size = new System.Drawing.Size(752, 477);
            this.tabViewAllTeachers.TabIndex = 0;
            this.tabViewAllTeachers.Text = "View All Teachers";
            this.tabViewAllTeachers.UseVisualStyleBackColor = true;
            // 
            // tabViewTeacherDetails
            // 
            this.tabViewTeacherDetails.Location = new System.Drawing.Point(4, 34);
            this.tabViewTeacherDetails.Name = "tabViewTeacherDetails";
            this.tabViewTeacherDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewTeacherDetails.Size = new System.Drawing.Size(752, 477);
            this.tabViewTeacherDetails.TabIndex = 3;
            this.tabViewTeacherDetails.Text = "View Teacher Details";
            this.tabViewTeacherDetails.UseVisualStyleBackColor = true;
            // 
            // tabAddTeacher
            // 
            this.tabAddTeacher.Location = new System.Drawing.Point(4, 34);
            this.tabAddTeacher.Name = "tabAddTeacher";
            this.tabAddTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddTeacher.Size = new System.Drawing.Size(752, 477);
            this.tabAddTeacher.TabIndex = 2;
            this.tabAddTeacher.Text = "Add New Teacher";
            this.tabAddTeacher.UseVisualStyleBackColor = true;
            // 
            // TeacherMainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlTeacher);
            this.Name = "TeacherMainUserControl";
            this.Size = new System.Drawing.Size(760, 515);
            this.tabControlTeacher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabViewAllTeachers;
        private System.Windows.Forms.TabPage tabAddTeacher;
        private System.Windows.Forms.TabPage tabViewTeacherDetails;
        public System.Windows.Forms.TabControl tabControlTeacher;
    }
}
