namespace WinFormRetail
{
    partial class NewTransactionMaster
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
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TransactionDataGrid = new System.Windows.Forms.DataGridView();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductIDLabel.Location = new System.Drawing.Point(38, 29);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(75, 19);
            this.ProductIDLabel.TabIndex = 0;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(38, 73);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(32, 19);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Qty";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(178, 28);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(407, 23);
            this.ProductIDTextBox.TabIndex = 2;
            this.ProductIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductIDTextBox_KeyDown);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Location = new System.Drawing.Point(603, 21);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(170, 34);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Location = new System.Drawing.Point(603, 65);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(170, 34);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TransactionDataGrid
            // 
            this.TransactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGrid.Location = new System.Drawing.Point(38, 122);
            this.TransactionDataGrid.Name = "TransactionDataGrid";
            this.TransactionDataGrid.RowTemplate.Height = 25;
            this.TransactionDataGrid.Size = new System.Drawing.Size(735, 349);
            this.TransactionDataGrid.TabIndex = 5;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CheckoutButton.Location = new System.Drawing.Point(603, 477);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(170, 34);
            this.CheckoutButton.TabIndex = 7;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = false;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(178, 72);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(407, 23);
            this.QuantityTextBox.TabIndex = 8;
            this.QuantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityTextBox_KeyDown);
            // 
            // TotalLabel
            // 
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(38, 484);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(257, 19);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "  Total :";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewTransactionMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 525);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TransactionDataGrid);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.MaximumSize = new System.Drawing.Size(815, 564);
            this.Name = "NewTransactionMaster";
            this.Text = "NewTransactionMaster";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ProductIDLabel;
        private Label QuantityLabel;
        private TextBox ProductIDTextBox;
        private Button BrowseButton;
        private Button AddButton;
        private DataGridView TransactionDataGrid;
        private Button CheckoutButton;
        private TextBox QuantityTextBox;
        private Label TotalLabel;
    }
}