namespace WinFormRetail
{
    partial class MainMenuMaster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTransactionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileMenu,
            this.LogoutMenu,
            this.ExitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ProfileMenu
            // 
            this.ProfileMenu.Name = "ProfileMenu";
            this.ProfileMenu.Size = new System.Drawing.Size(112, 22);
            this.ProfileMenu.Text = "Profile";
            // 
            // LogoutMenu
            // 
            this.LogoutMenu.Name = "LogoutMenu";
            this.LogoutMenu.Size = new System.Drawing.Size(112, 22);
            this.LogoutMenu.Text = "Logout";
            this.LogoutMenu.Click += new System.EventHandler(this.LogoutMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(112, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductMenu,
            this.EmployeeMenu});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // ProductMenu
            // 
            this.ProductMenu.Name = "ProductMenu";
            this.ProductMenu.Size = new System.Drawing.Size(180, 22);
            this.ProductMenu.Text = "Product";
            this.ProductMenu.Click += new System.EventHandler(this.ProductMenu_Click);
            // 
            // EmployeeMenu
            // 
            this.EmployeeMenu.Name = "EmployeeMenu";
            this.EmployeeMenu.Size = new System.Drawing.Size(180, 22);
            this.EmployeeMenu.Text = "Employee";
            this.EmployeeMenu.Click += new System.EventHandler(this.EmployeeMenu_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTransactionMenu,
            this.HistoryMenu});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // NewTransactionMenu
            // 
            this.NewTransactionMenu.Name = "NewTransactionMenu";
            this.NewTransactionMenu.Size = new System.Drawing.Size(161, 22);
            this.NewTransactionMenu.Text = "New Transaction";
            // 
            // HistoryMenu
            // 
            this.HistoryMenu.Name = "HistoryMenu";
            this.HistoryMenu.Size = new System.Drawing.Size(161, 22);
            this.HistoryMenu.Text = "History";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // MainMenuMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 297);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(487, 336);
            this.Name = "MainMenuMaster";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ProfileMenu;
        private ToolStripMenuItem LogoutMenu;
        private ToolStripMenuItem ExitMenu;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem ProductMenu;
        private ToolStripMenuItem EmployeeMenu;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem NewTransactionMenu;
        private ToolStripMenuItem HistoryMenu;
        private ToolStripMenuItem reportToolStripMenuItem;
    }
}