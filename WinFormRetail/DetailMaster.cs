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

namespace WinFormRetail
{
    public partial class DetailMaster : Form
    {
        #region Property

        private CashireDbContext _db;

        private string _id;

        #endregion

        public DetailMaster(CashireDbContext db, string id)
        {
            InitializeComponent();
            _db = db;
            _id = id;

            LabelLoad();
            DataGridLoad();
        }

        private void LabelLoad()
        {
            var transaction = _db.Transactions
                .Where(x => x.ID == _id)
                .Select(x => new
                {
                    ID = x.ID,
                    Date = x.Date,
                    Name = x.Users.Name,
                    Total = _db.TransactionProducts
                        .Where(y => y.Transaction.Date == x.Date)
                        .Sum(z => z.Price * z.Quantity)
                }).First();

            TransactionIdLabel.Text = $"Transaction ID  : {transaction.ID}";
            EmployeeLabel.Text = $"Employee         : {transaction.Name}";
            TotalLabel.Text = $"Total                 : {transaction.Total}";
            DateLabel.Text = $"Date                 : {transaction.Date}";
        }
        private void DataGridLoad()
        {
            var transaction = _db.Transactions
                .Where(x => x.ID == _id)
                .First();

            var transactionProduct = _db.TransactionProducts
                .Where(x => x.Transaction.Date == transaction.Date)
                .Select(y => new
                {
                    ID = y.Product.ID,
                    Product = y.Product.Name,
                    Price = y.Price,
                    Quantity = y.Quantity,
                    Subtotal = y.Price * y.Quantity,
                }).ToList();
            
            DetailDataGrid.DataSource = transactionProduct;
            DetailDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
