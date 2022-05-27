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

namespace WinFormRetail
{
    public partial class EmployeeMaster : Form
    {
        private CashireDbContext _db;
        private int Id;
        private string ClickedId = "";

        public EmployeeMaster(CashireDbContext db)
        {
            InitializeComponent();
            _db = db;

            SetEmployeeGroupBoxFalse();
            Refresh();
            Id = Convert.ToInt32(GetLastId());
        }


        #region KeyDown

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailTextBox.Focus();
            }
        }

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PhoneTextBox.Focus();
            }
        }

        private void PhoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTextBox.Focus();
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveButton.Focus();
            }
        }

        #endregion

        #region Button Method

        private void AddButton_Click(object sender, EventArgs e)
        {
            SetEmployeeGroupBoxTrue();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGrid.SelectedRows[0].DataBoundItem as User;
            ClickedId = selectedRow.ID;
            NameTextBox.Text = selectedRow.Name.ToString();
            EmailTextBox.Text = selectedRow.Email.ToString();
            PhoneTextBox.Text = selectedRow.Phone.ToString();
            PasswordTextBox.Text = selectedRow.Password.ToString();
            SetEmployeeGroupBoxTrue();
            SetDataGridEnableFalse();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = DataGrid.SelectedRows[0].DataBoundItem as User;
            ClickedId = selectedRow.ID.ToString();
            var userName = selectedRow.Name;
            if (MessageBox.Show(
                $"Are you sure you want to delete product {userName} with the ID of {ClickedId}",
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
            this.EmailTextBox.Text = "";
            this.PhoneTextBox.Text = "";
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

            _db.Users.Add(new User
            {
                ID = GetFormatedId(Id),
                Name = NameTextBox.Text,
                Email = EmailTextBox.Text,
                Phone = PhoneTextBox.Text.ToString(),
                Password = PasswordTextBox.Text,
            });
            _db.SaveChanges();

            Refresh();
        }

        /// <summary>
        /// Edit the selected product
        /// </summary>
        private void EditProduct()
        {

            var user = _db.Users
                .Where(x => x.ID == ClickedId)
                .First();
            user.Name = NameTextBox.Text;
            user.Email = EmailTextBox.Text;
            user.Phone = PhoneTextBox.Text.ToString();
            user.Password = PasswordTextBox.Text;
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

            var amount = _db.Users
                .OrderBy(x => x.ID)
                .Select(x => x.ID)
                .Count();

            var user = _db.Users
                .Where(x => x.ID == ClickedId)
                .First();

            var subUser = _db.Users
                .Where(x => x.ID == subStringId)
                .FirstOrDefault();

            if (stringId == Id)
            {
                if (subUser == null)
                {
                    temporaryId -= amount;
                    Id -= temporaryId + 1;
                    return;
                }

                Id -= 1;
            }


            _db.Users.Remove(user);
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
                var id = _db.Products
                    .OrderBy(x => x.ID)
                    .Select(x => x.ID)
                    .Last();
                return id.Substring(1);
            }
            catch (Exception ex)
            {
                return "0";
            }
        }

        /// <summary>
        /// Get formated id for product id
        /// </summary>
        private string GetFormatedId(int id)
        {
            if (id < 10)
                return $"E000{id}";
            if (id >= 10 & id < 100)
                return $"E00{id}";
            if (id >= 100 & id < 1000)
                return $"E0{id}";
            return $"E{id}";
        }


        /// <summary>
        /// Set group box's enable to false
        /// </summary>
        private void SetEmployeeGroupBoxFalse()
        {
            this.EmployeeGroupBox.Enabled = false;
        }

        /// <summary>
        /// Set group box's enable to true
        /// </summary>
        private void SetEmployeeGroupBoxTrue()
        {
            this.EmployeeGroupBox.Enabled = true;
        }

        /// <summary>
        /// Refresh the DataGrid
        /// </summary>
        private new void Refresh()
        {
            var user = _db.Users
                .OrderBy(x => x.ID)
                .ToList();
            DataGrid.DataSource = user;
            ClickedId = "";
            SetEmployeeGroupBoxFalse();
            SetDataGridEnableTrue();
            ClearTextBox();
        }

        /// <summary>
        /// Clear all text box in group box
        /// </summary>
        private void ClearTextBox()
        {
            this.NameTextBox.Text = "";
            this.EmailTextBox.Text = "";
            this.PhoneTextBox.Text = "";
            this.PasswordTextBox.Text = "";
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
