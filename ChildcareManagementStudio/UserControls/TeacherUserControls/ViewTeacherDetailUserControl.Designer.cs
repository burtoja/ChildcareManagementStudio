
namespace ChildcareManagementStudio.UserControls
{
    partial class ViewTeacherDetailUserControl
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.labelValueDOB = new System.Windows.Forms.Label();
            this.labelValueSSN = new System.Windows.Forms.Label();
            this.labelValuePhone = new System.Windows.Forms.Label();
            this.labelValueGender = new System.Windows.Forms.Label();
            this.labelValueAddress1 = new System.Windows.Forms.Label();
            this.labelValueAddress2 = new System.Windows.Forms.Label();
            this.labelValueCity = new System.Windows.Forms.Label();
            this.labelValueState = new System.Windows.Forms.Label();
            this.labelValueZipCode = new System.Windows.Forms.Label();
            this.labelValueStartDate = new System.Windows.Forms.Label();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewCredentialHistory = new System.Windows.Forms.ListView();
            this.columnHeaderCredential = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPayHistory = new System.Windows.Forms.ListView();
            this.columnHeaderPayRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEffectiveDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCredentialHistory = new System.Windows.Forms.Label();
            this.labelPayHistory = new System.Windows.Forms.Label();
            this.labelPositionHistory = new System.Windows.Forms.Label();
            this.buttonChangePosition = new System.Windows.Forms.Button();
            this.buttonChangePayRate = new System.Windows.Forms.Button();
            this.buttonAddNewCredential = new System.Windows.Forms.Button();
            this.listViewPositionHistory = new System.Windows.Forms.ListView();
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(14, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Teacher Name:";
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(33, 49);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(111, 21);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress1.Location = new System.Drawing.Point(55, 119);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(89, 21);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "Address 1:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress2.Location = new System.Drawing.Point(55, 154);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(89, 21);
            this.labelAddress2.TabIndex = 5;
            this.labelAddress2.Text = "Address 2:";
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(99, 189);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(45, 21);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "City:";
            // 
            // labelState
            // 
            this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(381, 189);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(57, 21);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "State:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.Location = new System.Drawing.Point(60, 224);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(84, 21);
            this.labelZipCode.TabIndex = 8;
            this.labelZipCode.Text = "Zip Code:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(342, 224);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(96, 21);
            this.labelStartDate.TabIndex = 21;
            this.labelStartDate.Text = "Start Date:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(14, 84);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(130, 21);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelSSN
            // 
            this.labelSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSSN.AutoSize = true;
            this.labelSSN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.Location = new System.Drawing.Point(396, 49);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(42, 21);
            this.labelSSN.TabIndex = 23;
            this.labelSSN.Text = "SSN:";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(364, 84);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(74, 21);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "Gender:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDOB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCity, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelState, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelZipCode, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelStartDate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSSN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelValueDOB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValueSSN, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValuePhone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueGender, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueAddress1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelValueAddress2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelValueCity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelValueState, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelValueZipCode, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelValueStartDate, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditTeacher, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 283);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxName, 2);
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(150, 11);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(288, 29);
            this.comboBoxName.TabIndex = 25;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxName_SelectedIndexChanged);
            // 
            // labelValueDOB
            // 
            this.labelValueDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueDOB.AutoSize = true;
            this.labelValueDOB.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueDOB.Location = new System.Drawing.Point(150, 49);
            this.labelValueDOB.Name = "labelValueDOB";
            this.labelValueDOB.Size = new System.Drawing.Size(0, 21);
            this.labelValueDOB.TabIndex = 27;
            // 
            // labelValueSSN
            // 
            this.labelValueSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueSSN.AutoSize = true;
            this.labelValueSSN.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueSSN.Location = new System.Drawing.Point(444, 49);
            this.labelValueSSN.Name = "labelValueSSN";
            this.labelValueSSN.Size = new System.Drawing.Size(0, 21);
            this.labelValueSSN.TabIndex = 28;
            // 
            // labelValuePhone
            // 
            this.labelValuePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValuePhone.AutoSize = true;
            this.labelValuePhone.ForeColor = System.Drawing.Color.Maroon;
            this.labelValuePhone.Location = new System.Drawing.Point(150, 84);
            this.labelValuePhone.Name = "labelValuePhone";
            this.labelValuePhone.Size = new System.Drawing.Size(0, 21);
            this.labelValuePhone.TabIndex = 29;
            // 
            // labelValueGender
            // 
            this.labelValueGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueGender.AutoSize = true;
            this.labelValueGender.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueGender.Location = new System.Drawing.Point(444, 84);
            this.labelValueGender.Name = "labelValueGender";
            this.labelValueGender.Size = new System.Drawing.Size(0, 21);
            this.labelValueGender.TabIndex = 30;
            // 
            // labelValueAddress1
            // 
            this.labelValueAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueAddress1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelValueAddress1, 3);
            this.labelValueAddress1.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueAddress1.Location = new System.Drawing.Point(150, 119);
            this.labelValueAddress1.Name = "labelValueAddress1";
            this.labelValueAddress1.Size = new System.Drawing.Size(0, 21);
            this.labelValueAddress1.TabIndex = 31;
            // 
            // labelValueAddress2
            // 
            this.labelValueAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueAddress2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelValueAddress2, 3);
            this.labelValueAddress2.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueAddress2.Location = new System.Drawing.Point(150, 154);
            this.labelValueAddress2.Name = "labelValueAddress2";
            this.labelValueAddress2.Size = new System.Drawing.Size(0, 21);
            this.labelValueAddress2.TabIndex = 32;
            // 
            // labelValueCity
            // 
            this.labelValueCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueCity.AutoSize = true;
            this.labelValueCity.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueCity.Location = new System.Drawing.Point(150, 189);
            this.labelValueCity.Name = "labelValueCity";
            this.labelValueCity.Size = new System.Drawing.Size(0, 21);
            this.labelValueCity.TabIndex = 33;
            // 
            // labelValueState
            // 
            this.labelValueState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueState.AutoSize = true;
            this.labelValueState.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueState.Location = new System.Drawing.Point(444, 189);
            this.labelValueState.Name = "labelValueState";
            this.labelValueState.Size = new System.Drawing.Size(0, 21);
            this.labelValueState.TabIndex = 34;
            // 
            // labelValueZipCode
            // 
            this.labelValueZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueZipCode.AutoSize = true;
            this.labelValueZipCode.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueZipCode.Location = new System.Drawing.Point(150, 224);
            this.labelValueZipCode.Name = "labelValueZipCode";
            this.labelValueZipCode.Size = new System.Drawing.Size(0, 21);
            this.labelValueZipCode.TabIndex = 35;
            // 
            // labelValueStartDate
            // 
            this.labelValueStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValueStartDate.AutoSize = true;
            this.labelValueStartDate.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueStartDate.Location = new System.Drawing.Point(444, 224);
            this.labelValueStartDate.Name = "labelValueStartDate";
            this.labelValueStartDate.Size = new System.Drawing.Size(0, 21);
            this.labelValueStartDate.TabIndex = 36;
            this.labelValueStartDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonEditTeacher, 5);
            this.buttonEditTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTeacher.Location = new System.Drawing.Point(113, 256);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(513, 28);
            this.buttonEditTeacher.TabIndex = 26;
            this.buttonEditTeacher.Text = "Edit Details for Selected Teacher";
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            this.buttonEditTeacher.Click += new System.EventHandler(this.ButtonEditTeacher_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.Controls.Add(this.listViewCredentialHistory, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.listViewPayHistory, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCredentialHistory, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPayHistory, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPositionHistory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangePosition, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangePayRate, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddNewCredential, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.listViewPositionHistory, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 305);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 162);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // listViewCredentialHistory
            // 
            this.listViewCredentialHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCredential,
            this.columnHeaderExpiration});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewCredentialHistory, 2);
            this.listViewCredentialHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCredentialHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCredentialHistory.HideSelection = false;
            this.listViewCredentialHistory.Location = new System.Drawing.Point(491, 38);
            this.listViewCredentialHistory.Name = "listViewCredentialHistory";
            this.listViewCredentialHistory.Size = new System.Drawing.Size(245, 86);
            this.listViewCredentialHistory.TabIndex = 8;
            this.listViewCredentialHistory.UseCompatibleStateImageBehavior = false;
            this.listViewCredentialHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCredential
            // 
            this.columnHeaderCredential.Text = "Description";
            this.columnHeaderCredential.Width = 119;
            // 
            // columnHeaderExpiration
            // 
            this.columnHeaderExpiration.Text = "Expiration";
            this.columnHeaderExpiration.Width = 119;
            // 
            // listViewPayHistory
            // 
            this.listViewPayHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPayRate,
            this.columnHeaderEffectiveDate});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewPayHistory, 2);
            this.listViewPayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPayHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPayHistory.HideSelection = false;
            this.listViewPayHistory.Location = new System.Drawing.Point(247, 38);
            this.listViewPayHistory.Name = "listViewPayHistory";
            this.listViewPayHistory.Size = new System.Drawing.Size(238, 86);
            this.listViewPayHistory.TabIndex = 7;
            this.listViewPayHistory.UseCompatibleStateImageBehavior = false;
            this.listViewPayHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPayRate
            // 
            this.columnHeaderPayRate.Text = "Rate";
            this.columnHeaderPayRate.Width = 115;
            // 
            // columnHeaderEffectiveDate
            // 
            this.columnHeaderEffectiveDate.Text = "StartDate";
            this.columnHeaderEffectiveDate.Width = 117;
            // 
            // labelCredentialHistory
            // 
            this.labelCredentialHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCredentialHistory.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelCredentialHistory, 2);
            this.labelCredentialHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredentialHistory.Location = new System.Drawing.Point(491, 8);
            this.labelCredentialHistory.Name = "labelCredentialHistory";
            this.labelCredentialHistory.Size = new System.Drawing.Size(245, 19);
            this.labelCredentialHistory.TabIndex = 2;
            this.labelCredentialHistory.Text = "Credential History";
            this.labelCredentialHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPayHistory
            // 
            this.labelPayHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPayHistory.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelPayHistory, 2);
            this.labelPayHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayHistory.Location = new System.Drawing.Point(247, 8);
            this.labelPayHistory.Name = "labelPayHistory";
            this.labelPayHistory.Size = new System.Drawing.Size(238, 19);
            this.labelPayHistory.TabIndex = 1;
            this.labelPayHistory.Text = "Pay History";
            this.labelPayHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPositionHistory
            // 
            this.labelPositionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPositionHistory.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelPositionHistory, 2);
            this.labelPositionHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPositionHistory.Location = new System.Drawing.Point(3, 8);
            this.labelPositionHistory.Name = "labelPositionHistory";
            this.labelPositionHistory.Size = new System.Drawing.Size(238, 19);
            this.labelPositionHistory.TabIndex = 0;
            this.labelPositionHistory.Text = "Position History";
            this.labelPositionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangePosition
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonChangePosition, 2);
            this.buttonChangePosition.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePosition.Location = new System.Drawing.Point(3, 130);
            this.buttonChangePosition.Name = "buttonChangePosition";
            this.buttonChangePosition.Size = new System.Drawing.Size(238, 29);
            this.buttonChangePosition.TabIndex = 3;
            this.buttonChangePosition.Text = "Change Position";
            this.buttonChangePosition.UseVisualStyleBackColor = true;
            this.buttonChangePosition.Click += new System.EventHandler(this.ButtonChangePosition_Click);
            // 
            // buttonChangePayRate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonChangePayRate, 2);
            this.buttonChangePayRate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePayRate.Location = new System.Drawing.Point(247, 130);
            this.buttonChangePayRate.Name = "buttonChangePayRate";
            this.buttonChangePayRate.Size = new System.Drawing.Size(238, 29);
            this.buttonChangePayRate.TabIndex = 4;
            this.buttonChangePayRate.Text = "Change Pay Rate";
            this.buttonChangePayRate.UseVisualStyleBackColor = true;
            this.buttonChangePayRate.Click += new System.EventHandler(this.ButtonChangePayRate_Click);
            // 
            // buttonAddNewCredential
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonAddNewCredential, 2);
            this.buttonAddNewCredential.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewCredential.Location = new System.Drawing.Point(491, 130);
            this.buttonAddNewCredential.Name = "buttonAddNewCredential";
            this.buttonAddNewCredential.Size = new System.Drawing.Size(245, 29);
            this.buttonAddNewCredential.TabIndex = 5;
            this.buttonAddNewCredential.Text = "Add New Credential";
            this.buttonAddNewCredential.UseVisualStyleBackColor = true;
            this.buttonAddNewCredential.Click += new System.EventHandler(this.ButtonAddNewCredential_Click);
            // 
            // listViewPositionHistory
            // 
            this.listViewPositionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPosition,
            this.columnHeaderStartDate});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewPositionHistory, 2);
            this.listViewPositionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPositionHistory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPositionHistory.HideSelection = false;
            this.listViewPositionHistory.Location = new System.Drawing.Point(3, 38);
            this.listViewPositionHistory.Name = "listViewPositionHistory";
            this.listViewPositionHistory.Size = new System.Drawing.Size(238, 86);
            this.listViewPositionHistory.TabIndex = 6;
            this.listViewPositionHistory.UseCompatibleStateImageBehavior = false;
            this.listViewPositionHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.Text = "Position";
            this.columnHeaderPosition.Width = 112;
            // 
            // columnHeaderStartDate
            // 
            this.columnHeaderStartDate.Text = "Start Date";
            this.columnHeaderStartDate.Width = 120;
            // 
            // TeacherViewTeacherDetailUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TeacherViewTeacherDetailUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.EnabledChanged += new System.EventHandler(this.TeacherViewTeacherDetailUserControl_EnabledChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelCredentialHistory;
        private System.Windows.Forms.Label labelPayHistory;
        private System.Windows.Forms.Label labelPositionHistory;
        private System.Windows.Forms.Button buttonChangePosition;
        private System.Windows.Forms.Button buttonChangePayRate;
        private System.Windows.Forms.Button buttonAddNewCredential;
        private System.Windows.Forms.ListView listViewCredentialHistory;
        private System.Windows.Forms.ListView listViewPayHistory;
        private System.Windows.Forms.ListView listViewPositionHistory;
        private System.Windows.Forms.Label labelValueDOB;
        private System.Windows.Forms.Label labelValueSSN;
        private System.Windows.Forms.Label labelValuePhone;
        private System.Windows.Forms.Label labelValueGender;
        private System.Windows.Forms.Label labelValueAddress1;
        private System.Windows.Forms.Label labelValueAddress2;
        private System.Windows.Forms.Label labelValueCity;
        private System.Windows.Forms.Label labelValueState;
        private System.Windows.Forms.Label labelValueZipCode;
        private System.Windows.Forms.Label labelValueStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ColumnHeader columnHeaderStartDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCredential;
        private System.Windows.Forms.ColumnHeader columnHeaderExpiration;
        private System.Windows.Forms.ColumnHeader columnHeaderPayRate;
        private System.Windows.Forms.ColumnHeader columnHeaderEffectiveDate;
    }
}
