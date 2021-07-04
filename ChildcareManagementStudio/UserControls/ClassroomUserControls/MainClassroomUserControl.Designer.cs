
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
            this.tabPageGenerateDocuments = new System.Windows.Forms.TabPage();
            this.tabControlMainClassroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainClassroom
            // 
            this.tabControlMainClassroom.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMainClassroom.Controls.Add(this.tabPageListClassrooms);
            this.tabControlMainClassroom.Controls.Add(this.tabPageEditClass);
            this.tabControlMainClassroom.Controls.Add(this.tabPageGenerateDocuments);
            this.tabControlMainClassroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainClassroom.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainClassroom.Name = "tabControlMainClassroom";
            this.tabControlMainClassroom.SelectedIndex = 0;
            this.tabControlMainClassroom.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainClassroom.TabIndex = 0;
            this.tabControlMainClassroom.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlMainClassroom_Selected);
            // 
            // tabPageListClassrooms
            // 
            this.tabPageListClassrooms.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageListClassrooms.Location = new System.Drawing.Point(4, 33);
            this.tabPageListClassrooms.Name = "tabPageListClassrooms";
            this.tabPageListClassrooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListClassrooms.Size = new System.Drawing.Size(752, 478);
            this.tabPageListClassrooms.TabIndex = 1;
            this.tabPageListClassrooms.Text = "List Classrooms";
            // 
            // tabPageEditClass
            // 
            this.tabPageEditClass.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageEditClass.Location = new System.Drawing.Point(4, 33);
            this.tabPageEditClass.Name = "tabPageEditClass";
            this.tabPageEditClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditClass.Size = new System.Drawing.Size(752, 478);
            this.tabPageEditClass.TabIndex = 0;
            this.tabPageEditClass.Text = "Edit Class";
            // 
            // tabPageGenerateDocuments
            // 
            this.tabPageGenerateDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGenerateDocuments.Location = new System.Drawing.Point(4, 33);
            this.tabPageGenerateDocuments.Name = "tabPageGenerateDocuments";
            this.tabPageGenerateDocuments.Size = new System.Drawing.Size(752, 478);
            this.tabPageGenerateDocuments.TabIndex = 2;
            this.tabPageGenerateDocuments.Text = "Generate Documents";
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
        private System.Windows.Forms.TabPage tabPageEditClass;
        private System.Windows.Forms.TabPage tabPageListClassrooms;
        private System.Windows.Forms.TabPage tabPageGenerateDocuments;
    }
}
