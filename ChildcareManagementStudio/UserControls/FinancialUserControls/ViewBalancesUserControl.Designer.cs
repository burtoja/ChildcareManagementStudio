
namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    partial class ViewBalancesUserControl
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
            this.listViewBalances = new System.Windows.Forms.ListView();
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewBalances
            // 
            this.listViewBalances.AccessibleDescription = "List of all balances";
            this.listViewBalances.AccessibleName = "Balance List";
            this.listViewBalances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerName,
            this.headerBalance});
            this.listViewBalances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBalances.FullRowSelect = true;
            this.listViewBalances.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBalances.HideSelection = false;
            this.listViewBalances.Location = new System.Drawing.Point(18, 24);
            this.listViewBalances.MultiSelect = false;
            this.listViewBalances.Name = "listViewBalances";
            this.listViewBalances.Size = new System.Drawing.Size(708, 417);
            this.listViewBalances.TabIndex = 18;
            this.listViewBalances.UseCompatibleStateImageBehavior = false;
            this.listViewBalances.View = System.Windows.Forms.View.Details;
            // 
            // headerName
            // 
            this.headerName.Text = "Parent Name";
            this.headerName.Width = 315;
            // 
            // headerBalance
            // 
            this.headerBalance.Text = "Balance";
            this.headerBalance.Width = 244;
            // 
            // ViewBalancesUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.listViewBalances);
            this.Name = "ViewBalancesUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBalances;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerBalance;
    }
}
