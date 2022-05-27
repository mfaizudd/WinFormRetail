namespace WinFormRetail
{
    partial class BrowseMaster
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
            this.BrowseDataGrid = new System.Windows.Forms.DataGridView();
            this.SelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseDataGrid
            // 
            this.BrowseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrowseDataGrid.Location = new System.Drawing.Point(12, 12);
            this.BrowseDataGrid.Name = "BrowseDataGrid";
            this.BrowseDataGrid.RowTemplate.Height = 25;
            this.BrowseDataGrid.Size = new System.Drawing.Size(775, 447);
            this.BrowseDataGrid.TabIndex = 0;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(590, 474);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(197, 39);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BrowseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 525);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.BrowseDataGrid);
            this.MaximumSize = new System.Drawing.Size(815, 564);
            this.Name = "BrowseMaster";
            this.Text = "BrowseMaster";
            ((System.ComponentModel.ISupportInitialize)(this.BrowseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView BrowseDataGrid;
        private Button SelectButton;
    }
}