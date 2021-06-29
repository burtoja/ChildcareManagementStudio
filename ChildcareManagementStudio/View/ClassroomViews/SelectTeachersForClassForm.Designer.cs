
namespace ChildcareManagementStudio.View.ClassroomViews
{
    partial class SelectTeachersForClassForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInstructions = new System.Windows.Forms.Label();
            this.listViewTeacherChoices = new System.Windows.Forms.ListView();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelClassIdentifier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Location = new System.Drawing.Point(12, 20);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(380, 49);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Choose the teacher(s) in the list below to be associated with this class:";
            // 
            // listViewTeacherChoices
            // 
            this.listViewTeacherChoices.CheckBoxes = true;
            this.listViewTeacherChoices.HideSelection = false;
            this.listViewTeacherChoices.Location = new System.Drawing.Point(16, 108);
            this.listViewTeacherChoices.Name = "listViewTeacherChoices";
            this.listViewTeacherChoices.Size = new System.Drawing.Size(376, 281);
            this.listViewTeacherChoices.TabIndex = 1;
            this.listViewTeacherChoices.UseCompatibleStateImageBehavior = false;
            this.listViewTeacherChoices.View = System.Windows.Forms.View.List;
            this.listViewTeacherChoices.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewTeacherChoices_ItemChecked);
            this.listViewTeacherChoices.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewTeacherChoices_ItemSelectionChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(16, 410);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(171, 29);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Update Class";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(221, 410);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 29);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelClassIdentifier
            // 
            this.labelClassIdentifier.AutoSize = true;
            this.labelClassIdentifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassIdentifier.ForeColor = System.Drawing.Color.Maroon;
            this.labelClassIdentifier.Location = new System.Drawing.Point(16, 73);
            this.labelClassIdentifier.Name = "labelClassIdentifier";
            this.labelClassIdentifier.Size = new System.Drawing.Size(0, 19);
            this.labelClassIdentifier.TabIndex = 4;
            // 
            // SelectTeachersForClassForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(410, 453);
            this.Controls.Add(this.labelClassIdentifier);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.listViewTeacherChoices);
            this.Controls.Add(this.labelInstructions);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTeachersForClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Teachers For Class Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectTeachersForClassForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.ListView listViewTeacherChoices;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelClassIdentifier;
    }
}