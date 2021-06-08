
namespace ChildcareManagementStudio.UserControls
{
    partial class TeacherViewTeachersUserControl
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
            this.listViewAllTeachers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewAllTeachers
            // 
            this.listViewAllTeachers.HideSelection = false;
            this.listViewAllTeachers.Location = new System.Drawing.Point(0, 19);
            this.listViewAllTeachers.Name = "listViewAllTeachers";
            this.listViewAllTeachers.Size = new System.Drawing.Size(742, 385);
            this.listViewAllTeachers.TabIndex = 0;
            this.listViewAllTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // TeacherViewTeachersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewAllTeachers);
            this.Name = "TeacherViewTeachersUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllTeachers;
    }
}
