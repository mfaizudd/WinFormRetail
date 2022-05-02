using WinFormRetail.Model;
using WinFormRetail.Data;

namespace WinFormRetail
{
    public partial class LoginMaster : Form
    {
        public List<User> User { get; set; }

        public LoginMaster()
        {
            InitializeComponent();
            User = getUser();
        }

        #region TextBox

        private void Username_KeyDown(object sender, KeyEventArgs e)
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
            var usernameText = this.Username.Text;
            var passwordText = this.Password.Text;
            if (usernameText == User[0].Username && passwordText == User[0].Password)
            {

                MainMenuMaster mainMenu = new MainMenuMaster();
                mainMenu.Show();
            }

            this.Username.Text = "";
            this.Password.Text = "";
        }
        #endregion

        #region Helper Method

        private List<User> getUser()
        {
            var users = new List<User>();
            users.Add(new User()
            {
                Username = "admin",
                Password = "12345678"
            });
            return users;
        }

        #endregion
    }
}