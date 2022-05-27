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
    public partial class MainMenuMaster : Form
    {
        private CashireDbContext _db;

        private User _user;
        public MainMenuMaster(CashireDbContext db)
        {
            InitializeComponent();
            _db = db;
            _user = GetUser();
        }

        private void LogoutMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductMenu_Click(object sender, EventArgs e)
        {
            var product = new ProductMaster(_db);
            product.Show(); 
        }

        private void EmployeeMenu_Click(object sender, EventArgs e)
        {
            var employee = new EmployeeMaster(_db);
            employee.Show();
        }

        private void NewTransactionMenu_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User Not Found");
                return;
            }

            var transaction = new NewTransactionMaster(_db, _user);
            transaction.Show();
        }

        private void HistoryMenu_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("User Not Found");
                return;
            }

            var history = new HistoryMaster(_db, _user);
            history.Show();
        }

        /// <summary>
        /// Get logged in user
        /// </summary>
        /// <returns></returns>
        private User GetUser()
        {
            var user = _db.Users
                .Where(x => x.Email == UserSession.Email && x.Password == UserSession.Password)
                .FirstOrDefault();
            return user;
        }

        private void ProfileMenu_Click(object sender, EventArgs e)
        {
            var profile = new ProfileMaster(_user);
            profile.Show();
        }
    }
}
