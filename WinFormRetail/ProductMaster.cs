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
        private CashireDbContext _db;
        private int Id;
        private string ClickedId = "";

        public ProductMaster(CashireDbContext db)
        {
            InitializeComponent();
            _db = db;

            Id = Convert.ToInt32(GetLastId());
            SetProductGroupBoxFalse();
            Refresh();
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
            ClickedId = selectedRow.ID;
            NameTextBox.Text = selectedRow.Name.ToString();
            PriceTextBox.Text = selectedRow.Price.ToString();
            StockTextBox.Text = selectedRow.Stock.ToString();
            SetProductGroupBoxTrue();
            SetDataGridEnableFalse();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGrid.SelectedRows[0].DataBoundItem as Product;
            ClickedId = selectedRow.ID;
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

            _db.Products.Add(new Product
            {
                ID = GetFormatedId(Id),
                Name = this.NameTextBox.Text,
                Price = Convert.ToInt32(this.PriceTextBox.Text),
                Stock = Convert.ToInt32(this.StockTextBox.Text),
            });
            _db.SaveChanges();

            Refresh();
        }

        /// <summary>
        /// Edit the selected product
        /// </summary>
        private void EditProduct()
        {

            var product = _db.Products
                .Where(x => x.ID == ClickedId)
                .First();
            product.Name = NameTextBox.Text;
            product.Price = Convert.ToInt32(PriceTextBox.Text);
            product.Stock = Convert.ToInt32(StockTextBox.Text);
            _db.SaveChanges();

            Refresh();
        }

        /// <summary>
        /// Delete the product in database
        /// </summary>
        private void DeleteProduct()
        {
            var temporaryId = Id;

            var stringId = Convert.ToInt32(ClickedId.Substring(1));
            var subStringId = GetFormatedId(stringId - 1);

            var amount = _db.Products
                .OrderBy(x => x.ID)
                .Select(x => x.ID)
                .Count();

            var product = _db.Products
                .Where(x => x.ID == ClickedId)
                .First();

            var subProduct = _db.Products
                .Where(x => x.ID == subStringId)
                .FirstOrDefault();

            if ( stringId == Id )
            {
                if (subProduct == null)
                {
                    temporaryId -= amount;
                    Id -= temporaryId + 1;
                    return;
                }

                Id -= 1;
            }
                

            _db.Products.Remove(product);
            _db.SaveChanges();

            Refresh();
        }

        #endregion

        #region Helper Method

        /// <summary>
        /// GET the last index / id in the database
        /// </summary>
        private string GetLastId()
        {
            try
            {
                var productId = _db.Products
                    .OrderBy(x => x.ID)
                    .Select(x => x.ID)
                    .Last();

                return productId.Substring(1);
            }
            catch (Exception ex)
            {
                return "0000";
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
            var product = _db.Products
                .OrderBy(x => x.ID)
                .ToList();
            DataGrid.DataSource = product;
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
