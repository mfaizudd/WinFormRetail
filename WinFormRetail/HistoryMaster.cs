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
    public partial class HistoryMaster : Form
    {
        private CashireDbContext _db;

        private User _user;
        public HistoryMaster(CashireDbContext db, User user)
        {
            InitializeComponent();
            _db = db;
            _user = user;
            Refresh();
        }

        #region UI Component

        private DataGridViewButtonColumn AddButton()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Detail";
            btn.Text = "Detail";
            btn.UseColumnTextForButtonValue = true;
            return btn;
        }

        private void HistoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = GetFormatedId(e.RowIndex + 1);

            DetailMaster detail = new DetailMaster(_db, id);
            detail.Show();
        }

        #endregion

        #region Helper Method

        /// <summary>
        /// Load Data
        /// </summary>
        private new void Refresh()
        {

            var transaction = _db.Transactions
                .Where(a => a.Users.ID == _user.ID)
                .Select(x => new
                {
                    ID = x.ID,
                    Date = x.Date,
                    Employee = x.Users.Name,
                    Total = _db.TransactionProducts
                        .Where(y => y.Transaction.Date == x.Date)
                        .Sum(z => z.Price * z.Quantity)
                }).ToList();

            var btn = AddButton();

            HistoryDataGrid.DataSource = transaction;
            HistoryDataGrid.Columns.Add(btn);
            HistoryDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
