
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class ViewClassroomListUserControl
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
            this.listViewAllClassrooms = new System.Windows.Forms.ListView();
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCreateNewClassroom = new System.Windows.Forms.Button();
            this.buttonEditSelectedClassroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllClassrooms
            // 
            this.listViewAllClassrooms.AccessibleDescription = "List of all student";
            this.listViewAllClassrooms.AccessibleName = "Student List";
            this.listViewAllClassrooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.location,
            this.capacity});
            this.listViewAllClassrooms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAllClassrooms.FullRowSelect = true;
            this.listViewAllClassrooms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAllClassrooms.HideSelection = false;
            this.listViewAllClassrooms.Location = new System.Drawing.Point(18, 19);
            this.listViewAllClassrooms.MultiSelect = false;
            this.listViewAllClassrooms.Name = "listViewAllClassrooms";
            this.listViewAllClassrooms.Size = new System.Drawing.Size(708, 383);
            this.listViewAllClassrooms.TabIndex = 4;
            this.listViewAllClassrooms.UseCompatibleStateImageBehavior = false;
            this.listViewAllClassrooms.View = System.Windows.Forms.View.Details;
            // 
            // location
            // 
            this.location.Text = "Classroom Location";
            this.location.Width = 315;
            // 
            // capacity
            // 
            this.capacity.Text = "Capacity";
            this.capacity.Width = 244;
            // 
            // buttonCreateNewClassroom
            // 
            this.buttonCreateNewClassroom.AccessibleDescription = "";
            this.buttonCreateNewClassroom.AccessibleName = "";
            this.buttonCreateNewClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewClassroom.Location = new System.Drawing.Point(19, 408);
            this.buttonCreateNewClassroom.Name = "buttonCreateNewClassroom";
            this.buttonCreateNewClassroom.Size = new System.Drawing.Size(350, 43);
            this.buttonCreateNewClassroom.TabIndex = 5;
            this.buttonCreateNewClassroom.Text = "Create New Classroom";
            this.buttonCreateNewClassroom.UseVisualStyleBackColor = true;
            this.buttonCreateNewClassroom.Click += new System.EventHandler(this.ButtonAddNewClassroom_Click);
            // 
            // buttonEditSelectedClassroom
            // 
            this.buttonEditSelectedClassroom.AccessibleDescription = "";
            this.buttonEditSelectedClassroom.AccessibleName = "";
            this.buttonEditSelectedClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSelectedClassroom.Location = new System.Drawing.Point(376, 408);
            this.buttonEditSelectedClassroom.Name = "buttonEditSelectedClassroom";
            this.buttonEditSelectedClassroom.Size = new System.Drawing.Size(350, 43);
            this.buttonEditSelectedClassroom.TabIndex = 7;
            this.buttonEditSelectedClassroom.Text = "Edit Selected Classroom";
            this.buttonEditSelectedClassroom.UseVisualStyleBackColor = true;
            // 
            // ViewClassroomListUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonEditSelectedClassroom);
            this.Controls.Add(this.listViewAllClassrooms);
            this.Controls.Add(this.buttonCreateNewClassroom);
            this.Name = "ViewClassroomListUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllClassrooms;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.Button buttonCreateNewClassroom;
        private System.Windows.Forms.Button buttonEditSelectedClassroom;
    }
}
