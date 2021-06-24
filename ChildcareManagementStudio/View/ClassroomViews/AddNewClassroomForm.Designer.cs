
namespace ChildcareManagementStudio.View.ClassroomViews
{
    partial class AddNewClassroomForm
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
            this.labelClassroomLocation = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.labelCapcityUnits = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClassroomLocation
            // 
            this.labelClassroomLocation.AutoSize = true;
            this.labelClassroomLocation.Location = new System.Drawing.Point(12, 19);
            this.labelClassroomLocation.Name = "labelClassroomLocation";
            this.labelClassroomLocation.Size = new System.Drawing.Size(165, 21);
            this.labelClassroomLocation.TabIndex = 1;
            this.labelClassroomLocation.Text = "Classroom Location:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(28, 108);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(161, 33);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Create Class";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(223, 108);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 33);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(89, 63);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(88, 21);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity:";
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.Location = new System.Drawing.Point(183, 63);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(58, 27);
            this.numericUpDownCapacity.TabIndex = 3;
            this.numericUpDownCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCapcityUnits
            // 
            this.labelCapcityUnits.AutoSize = true;
            this.labelCapcityUnits.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapcityUnits.Location = new System.Drawing.Point(247, 69);
            this.labelCapcityUnits.Name = "labelCapcityUnits";
            this.labelCapcityUnits.Size = new System.Drawing.Size(61, 16);
            this.labelCapcityUnits.TabIndex = 8;
            this.labelCapcityUnits.Text = "students";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(183, 19);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(240, 27);
            this.textBoxLocation.TabIndex = 9;
            // 
            // AddNewClassroomForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(435, 161);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelCapcityUnits);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelClassroomLocation);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewClassroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Classroom Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClassroomLocation;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Label labelCapcityUnits;
        private System.Windows.Forms.TextBox textBoxLocation;
    }
}