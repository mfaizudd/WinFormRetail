namespace WinFormRetail
{
    partial class LoginMaster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.StartPicture = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(239, 119);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(157, 23);
            this.Email.TabIndex = 0;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_KeyDown);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(239, 163);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(157, 23);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // StartPicture
            // 
            this.StartPicture.Enabled = false;
            this.StartPicture.ImageLocation = "";
            this.StartPicture.Location = new System.Drawing.Point(78, 81);
            this.StartPicture.Name = "StartPicture";
            this.StartPicture.Size = new System.Drawing.Size(131, 118);
            this.StartPicture.TabIndex = 2;
            this.StartPicture.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(158, 221);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(135, 33);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(239, 101);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(36, 15);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(239, 145);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 297);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.StartPicture);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.MaximumSize = new System.Drawing.Size(487, 336);
            this.Name = "LoginMaster";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.StartPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Email;
        private TextBox Password;
        private PictureBox StartPicture;
        private Button LoginButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
    }
}