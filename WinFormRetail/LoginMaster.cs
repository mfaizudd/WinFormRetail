using WinFormRetail.Model;
using WinFormRetail.Data;
using WinFormRetail.Session;

namespace WinFormRetail
{
    public partial class LoginMaster : Form
    {
        private ViewModel viewModel = new ViewModel();
        private CashireDbContext _db;
        private List<string>? _email;
        private List<string>? _password;

        public LoginMaster()
        {
            InitializeComponent();
            StartPicture.ImageLocation = @"C:\Users\mikha\Downloads\NicePng_shree-ganeshay-namah-png_2696347.png";
            StartPicture.SizeMode = PictureBoxSizeMode.StretchImage;


            _db = viewModel.db;
            _email = _db.Users
                .Select(x => x.Email)
                .ToList();
            _password = _db.Users
                .Select(x => x.Password)
                .ToList();
        }

        #region TextBox

        private void Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.Focus();
            }
        }

        #endregion

        #region Button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            CheckInput();
            this.Email.Text = "";
            this.Password.Text = "";
        }
        #endregion

        #region Helper Method

        private void CheckInput()
        {
            if ( _email.Contains(Email.Text) && _password.Contains(Password.Text) ||
                Email.Text.Contains("admin@admin") && Password.Text.Contains("admin"))
            {
                UserSession.SetUser(this.Email.Text, this.Password.Text);
                MainMenuMaster mainMenu = new MainMenuMaster(_db);
                mainMenu.Show();
                return;
            }

            MessageBox.Show("Invalid");
        }

        #endregion
    }
}