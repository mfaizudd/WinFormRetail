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

namespace WinFormRetail
{
    public partial class ProfileMaster : Form
    {
        private User _user;
        public ProfileMaster(User user)
        {
            InitializeComponent();
            _user = user;
            LoadForm();
        }

        private void LoadForm()
        {
            ProfilePic.ImageLocation = @"C:\Users\mikha\Downloads\blank-profile-picture-g091bc1982_1280.png";
            ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            NameLabel.Text = $"Name   : {_user.Name}";
            PhoneLabel.Text = $"Phone  : {_user.Phone}";
            EmailLabel.Text = $"Email  : {_user.Email}";
        }
    }
}
