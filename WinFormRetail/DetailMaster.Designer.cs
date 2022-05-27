namespace WinFormRetail
{
    partial class DetailMaster
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
            this.TransactionIdLabel = new System.Windows.Forms.Label();
            this.DetailDataGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionIdLabel
            // 
            this.TransactionIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransactionIdLabel.Location = new System.Drawing.Point(12, 26);
            this.TransactionIdLabel.Name = "TransactionIdLabel";
            this.TransactionIdLabel.Size = new System.Drawing.Size(775, 25);
            this.TransactionIdLabel.TabIndex = 6;
            this.TransactionIdLabel.Text = "Transaction ID";
            // 
            // DetailDataGrid
            // 
            this.DetailDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailDataGrid.Location = new System.Drawing.Point(12, 179);
            this.DetailDataGrid.Name = "DetailDataGrid";
            this.DetailDataGrid.RowTemplate.Height = 25;
            this.DetailDataGrid.Size = new System.Drawing.Size(775, 334);
            this.DetailDataGrid.TabIndex = 2;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeLabel.Location = new System.Drawing.Point(12, 62);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(775, 25);
            this.EmployeeLabel.TabIndex = 7;
            this.EmployeeLabel.Text = "Employee";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(12, 99);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(775, 25);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total";
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(12, 133);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(775, 25);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Date";
            // 
            // DetailMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 525);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.TransactionIdLabel);
            this.Controls.Add(this.DetailDataGrid);
            this.MaximumSize = new System.Drawing.Size(815, 564);
            this.Name = "DetailMaster";
            this.Text = "DetailMaster";
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label TransactionIdLabel;
        private DataGridView DetailDataGrid;
        private Label EmployeeLabel;
        private Label TotalLabel;
        private Label DateLabel;
    }
}