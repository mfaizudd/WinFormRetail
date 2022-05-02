using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormRetail.Model;
using WinFormRetail.Data;

namespace WinFormRetail
{
    public partial class ProductMaster : Form
    {
        CashireDbContext db = new CashireDbContext();
        private int Id;
        private string ClickedId = "";

        public ProductMaster()
        {
            InitializeComponent();
            SetProductGroupBoxFalse();
            Refresh();

            Id = GetLastId();
        }

        #region KeyDown

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PriceTextBox.Focus();
            }
        }

        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StockTextBox.Focus();
            }
        }

        #endregion
        
        #region Button Method

        private void AddButton_Click(object sender, EventArgs e)
        {
            SetProductGroupBoxTrue();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGrid.SelectedRows[0].DataBoundItem as Product;
            ClickedId = selectedRow.ID.ToString();
            NameTextBox.Text = selectedRow.Name.ToString();
            PriceTextBox.Text = selectedRow.Price.ToString();
            StockTextBox.Text = selectedRow.Stock.ToString();
            SetProductGroupBoxTrue();
            SetDataGridEnableFalse();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGrid.SelectedRows[0].DataBoundItem as Product;
            ClickedId = selectedRow.ID.ToString();
            var productName = selectedRow.Name;
            if (MessageBox.Show(
                $"Are you sure you want to delete product {productName} with the ID of {ClickedId}",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteProduct();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ClickedId == "")
            {
                AddProduct();
            } 
            else
            {
                EditProduct();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.NameTextBox.Text = "";
            this.PriceTextBox.Text = "";
            this.StockTextBox.Text = "";
            Refresh();
        }

        #endregion

        #region Operation Method

        /// <summary>
        /// Add Product to Database
        /// </summary>
        private void AddProduct()
        {
            Id += 1;

            db.Products.Add(new Product
            {
                ID = Id,
                ProductId = GetFormatedId(Id),
                Name = this.NameTextBox.Text,
                Price = Convert.ToInt32(this.PriceTextBox.Text),
                Stock = Convert.ToInt32(this.StockTextBox.Text),
            });
            db.SaveChanges();

            Refresh();
        }

        /// <summary>
        /// Edit the selected product
        /// </summary>
        private void EditProduct()
        {

            var product = db.Products
                .Where(x => x.ID == Convert.ToInt32(ClickedId))
                .First();
            product.Name = NameTextBox.Text;
            product.Price = Convert.ToInt32(PriceTextBox.Text);
            product.Stock = Convert.ToInt32(StockTextBox.Text);
            db.SaveChanges();

            Refresh();
        }

        /// <summary>
        /// Delete the product in database
        /// </summary>
        private void DeleteProduct()
        {
            var temporaryId = Id;

            var count = db.Products
                .OrderBy(x => x.ID)
                .Select(x => x.ID)
                .Count();

            var product = db.Products
                .Where(x => x.ID == Convert.ToInt32(ClickedId))
                .First();

            if (product.ID == temporaryId)
            {
                temporaryId -= count;
                Id -= temporaryId + 1;
            }
                

            db.Products.Remove(product);
            db.SaveChanges();

            Refresh();
        }

        #endregion

        #region Helper Method

        /// <summary>
        /// GET the last index / id in the database
        /// </summary>
        private int GetLastId()
        {
            try
            {
                var id = db.Products
                .OrderBy(x => x.ID)
                .Select(x => x.ID)
                .Last();

                return id;
            } 
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// Get formated id for product id
        /// </summary>
        private string GetFormatedId(int id)
        {
            if (id < 10)
                return $"P000{id}";
            if(id >= 10 & id < 100)
                return $"P00{id}";
            if (id >= 100 & id < 1000)
                return $"P0{id}";
            return $"P{id}";
        }


        /// <summary>
        /// Set group box's enable to false
        /// </summary>
        private void SetProductGroupBoxFalse()
        {
            this.ProductGroupBox.Enabled = false;
        }

        /// <summary>
        /// Set group box's enable to true
        /// </summary>
        private void SetProductGroupBoxTrue()
        {
            this.ProductGroupBox.Enabled = true;
        }

        /// <summary>
        /// Refresh the DataGrid
        /// </summary>
        private new void Refresh()
        {
            var product = db.Products
                .OrderBy(x => x.ID)
                .ToList();
            DataGrid.DataSource = product;
            DataGrid.Columns["ID"].Visible = false;
            ClickedId = "";
            SetProductGroupBoxFalse();
            SetDataGridEnableTrue();
            ClearTextBox();
        }

        /// <summary>
        /// Clear all text box in group box
        /// </summary>
        private void ClearTextBox()
        {
            this.NameTextBox.Text = "";
            this.PriceTextBox.Text = "";
            this.StockTextBox.Text = "";
        }

        /// <summary>
        /// Set DataGrid enable to true
        /// </summary>
        private void SetDataGridEnableTrue()
        {
            this.DataGrid.Enabled = true;
        }

        /// <summary>
        /// Set DataGrid enable to false
        /// </summary>
        private void SetDataGridEnableFalse()
        {
            this.DataGrid.Enabled = false;
        }

        #endregion

    }
}
