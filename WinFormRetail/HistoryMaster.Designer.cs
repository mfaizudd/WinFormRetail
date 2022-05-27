namespace WinFormRetail
{
    partial class HistoryMaster
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
            this.HistoryDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryDataGrid
            // 
            this.HistoryDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataGrid.Location = new System.Drawing.Point(12, 12);
            this.HistoryDataGrid.Name = "HistoryDataGrid";
            this.HistoryDataGrid.RowTemplate.Height = 25;
            this.HistoryDataGrid.Size = new System.Drawing.Size(775, 501);
            this.HistoryDataGrid.TabIndex = 1;
            this.HistoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryDataGrid_CellContentClick);
            // 
            // HistoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 525);
            this.Controls.Add(this.HistoryDataGrid);
            this.MaximumSize = new System.Drawing.Size(815, 564);
            this.Name = "HistoryMaster";
            this.Text = "HistoryMaster";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView HistoryDataGrid;
    }
}