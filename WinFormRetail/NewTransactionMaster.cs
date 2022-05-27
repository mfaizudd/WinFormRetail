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
    public partial class NewTransactionMaster : Form
    {
        #region Property

        private CashireDbContext _db;

        private User _user;

        private string? _searchId;

        private int _quantity;

        private int _subtotal;

        private int _total = 0;

        private List<NewTransactionSession> _newTransaction = new List<NewTransactionSession>();

        private Transaction _transaction;

        #endregion

        public NewTransactionMaster(CashireDbContext db, User user)
        {
            InitializeComponent();  
            TransactionDataGrid.Enabled = false;

            _db = db;
            _user = user;
        }

        #region Component System

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            _searchId = ProductIDTextBox.Text;
            var browse = new BrowseMaster(_db, _searchId);
            var dialogResult = browse.ShowDialog();



            if ( _db.Products.Count() == 0 )
            {
                MessageBox.Show("There is no product");
                browse.Close();
                return;
            } 

            if (dialogResult == DialogResult.OK)
            {
                ProductIDTextBox.Text = ProductSession.Product.ID;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckQuantityValidation();
            if (QuantityTextBox.Text != "")
                AddData();

            ProductIDTextBox.Text = "";
            QuantityTextBox.Text = "";
            TotalLabel.Text = $"Total : {_total}";
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            Close();
        }

        private void ProductIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                this.BrowseButton.Focus();
        }

        private void QuantityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
              this.AddButton.Focus();
        }

        #endregion

        #region Operation

        /// <summary>
        /// Add data to data grid
        /// </summary>
        private void AddData()
        {
            ProductSession.Product = _db.Products
                .Where(x => x.ID == ProductIDTextBox.Text)
                .FirstOrDefault();

            if (ProductSession.Product == null)
            {
                MessageBox.Show("Please Select the Product");
                return;
            }

            _newTransaction.Add(new NewTransactionSession
            {
                ID = ProductSession.Product.ID,
                Product = ProductSession.Product.Name,
                Price = ProductSession.Product.Price,
                Quantity = _quantity,
                Subtotal = ProductSession.Product.Price * _quantity,
            });

            Refresh();
        }


        /// <summary>
        /// Update Database TransactionProduct
        /// </summary>
        private void UpdateDatabase()
        {
            var transactionId = Convert.ToInt32(GetLastTrasactionId());
            transactionId += 1;

            _transaction = new Transaction
            {
                ID = GetFormatedId(transactionId),
                Date = DateTime.Now,
                Users = _user
            };

            foreach (var item in _newTransaction)
            {

                var transactionProduct = new TransactionProduct
                {
                    Transaction = _transaction,
                    Product = _db.Products.Where(x => x.ID == item.ID).First(),
                    Price = item.Price,
                    Quantity = item.Quantity
                };
                _db.TransactionProducts.Add(transactionProduct);
            }

            _db.Transactions.Add(_transaction);
            _db.SaveChanges();
        }

        #endregion

        #region Helper Method

        /// <summary>
        /// Make validation for quantity
        /// </summary>
        private void CheckQuantityValidation()
        {
            try
            {
                _quantity = Convert.ToInt32(this.QuantityTextBox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input number in the Quantity Text Box");
                QuantityTextBox.Text = "";
            }
        }

        /// <summary>
        /// Refresh the form
        /// </summary>
        private new void Refresh()
        {
            var listItem = _newTransaction.ToList();
            var lastItem = listItem.Last();
            _subtotal = lastItem.Subtotal;
            _total += _subtotal;

            TransactionDataGrid.DataSource = listItem;
            TransactionDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TotalLabel.Text = $"Total : {_total}";
        }

        /// <summary>
        /// GET the last index / id in the transaction database
        /// </summary>
        private string GetLastTrasactionId()
        {
            try
            {
                var productId = _db.Transactions
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
        /// Get formated id for transaction id
        /// </summary>
        private string GetFormatedId(int id)
        {
            if (id < 10)
                return $"T000{id}";
            if (id >= 10 & id < 100)
                return $"T00{id}";
            if (id >= 100 & id < 1000)
                return $"T0{id}";
            return $"T{id}";
        }

        #endregion

    }

}
