using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormRetail.Data;
using WinFormRetail.Model;
using WinFormRetail.Session;

namespace WinFormRetail
{
    public partial class BrowseMaster : Form
    {
        private CashireDbContext _db;
        private string? _searchId;
        public BrowseMaster(CashireDbContext db, string searchId)
        {
            InitializeComponent();
            _db = db;
            _searchId = searchId;

            Refresh();
        }

        #region Button UI

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProduct = BrowseDataGrid.SelectedRows[0].DataBoundItem as Product;
                ProductSession.SetProduct(selectedProduct);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the Product");
            }
        }

        #endregion

        #region Helper Method

        /// <summary>
        /// Refresh the form
        /// </summary>
        private new void Refresh()
        {
            var products = _db.Products.ToList();
            if ( _searchId != null )
            {
                products = _db.Products
                    .Where(x => x.ID.Contains(_searchId))
                    .ToList();
            }
            BrowseDataGrid.DataSource = products;
            BrowseDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion
    }
}
