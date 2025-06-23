namespace GUI_PhoneStore
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            chkShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Animated = true;
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderRadius = 8;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(30, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderForeColor = Color.Gray;
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(330, 40);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Animated = true;
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BorderRadius = 8;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(30, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderForeColor = Color.Gray;
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(330, 40);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Animated = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderRadius = 8;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.FillColor = Color.FromArgb(0, 120, 215);
            btnLogin.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(139, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(105, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Animated = true;
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkShowPassword.CheckedState.BorderRadius = 2;
            chkShowPassword.CheckedState.BorderThickness = 0;
            chkShowPassword.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkShowPassword.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            chkShowPassword.Location = new Point(30, 230);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(106, 18);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkShowPassword.UncheckedState.BorderRadius = 2;
            chkShowPassword.UncheckedState.BorderThickness = 0;
            chkShowPassword.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Simple_Login_Page_Mobile_Prototype__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(390, 577);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            MaximizeBox = false;
            MaximumSize = new Size(406, 616);
            MinimizeBox = false;
            MinimumSize = new Size(406, 616);
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập Hệ Thống";
            Load += frmlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowPassword;
    }
}