namespace GUI_PhoneStore
{
    partial class frmquanlynhanvien
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtMaNV = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtHoTen = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtMatKhau = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            rbVaiTroAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            rbVaiTroNhanVien = new MaterialSkin.Controls.MaterialRadioButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            rbTrangThaiActive = new MaterialSkin.Controls.MaterialRadioButton();
            rbTrangThaiInactive = new MaterialSkin.Controls.MaterialRadioButton();
            btnThem = new MaterialSkin.Controls.MaterialButton();
            btnSua = new MaterialSkin.Controls.MaterialButton();
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            materialCardInput = new MaterialSkin.Controls.MaterialCard();
            materialCardVaiTro = new MaterialSkin.Controls.MaterialCard();
            materialCardTrangThai = new MaterialSkin.Controls.MaterialCard();
            materialCardActions = new MaterialSkin.Controls.MaterialCard();
            btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            materialCardDGV = new MaterialSkin.Controls.MaterialCard();
            dgvNhanVien = new MaterialSkin.Controls.MaterialListView();
            materialCardInput.SuspendLayout();
            materialCardVaiTro.SuspendLayout();
            materialCardTrangThai.SuspendLayout();
            materialCardActions.SuspendLayout();
            materialCardDGV.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 25);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(53, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.AnimateReadOnly = false;
            txtMaNV.BackgroundImageLayout = ImageLayout.None;
            txtMaNV.CharacterCasing = CharacterCasing.Normal;
            txtMaNV.Depth = 0;
            txtMaNV.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMaNV.HideSelection = true;
            txtMaNV.LeadingIcon = null;
            txtMaNV.Location = new Point(130, 15);
            txtMaNV.MaxLength = 6;
            txtMaNV.MouseState = MaterialSkin.MouseState.OUT;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PasswordChar = '\0';
            txtMaNV.PrefixSuffixText = null;
            txtMaNV.ReadOnly = true;
            txtMaNV.RightToLeft = RightToLeft.No;
            txtMaNV.SelectedText = "";
            txtMaNV.SelectionLength = 0;
            txtMaNV.SelectionStart = 0;
            txtMaNV.ShortcutsEnabled = true;
            txtMaNV.Size = new Size(250, 48);
            txtMaNV.TabIndex = 1;
            txtMaNV.TabStop = false;
            txtMaNV.TextAlign = HorizontalAlignment.Left;
            txtMaNV.TrailingIcon = null;
            txtMaNV.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 85);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.AnimateReadOnly = false;
            txtHoTen.BackgroundImageLayout = ImageLayout.None;
            txtHoTen.CharacterCasing = CharacterCasing.Normal;
            txtHoTen.Depth = 0;
            txtHoTen.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoTen.HideSelection = true;
            txtHoTen.LeadingIcon = null;
            txtHoTen.Location = new Point(130, 75);
            txtHoTen.MaxLength = 100;
            txtHoTen.MouseState = MaterialSkin.MouseState.OUT;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PasswordChar = '\0';
            txtHoTen.PrefixSuffixText = null;
            txtHoTen.ReadOnly = false;
            txtHoTen.RightToLeft = RightToLeft.No;
            txtHoTen.SelectedText = "";
            txtHoTen.SelectionLength = 0;
            txtHoTen.SelectionStart = 0;
            txtHoTen.ShortcutsEnabled = true;
            txtHoTen.Size = new Size(250, 48);
            txtHoTen.TabIndex = 3;
            txtHoTen.TabStop = false;
            txtHoTen.TextAlign = HorizontalAlignment.Left;
            txtHoTen.TrailingIcon = null;
            txtHoTen.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(20, 145);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(45, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(130, 135);
            txtEmail.MaxLength = 255;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(250, 48);
            txtEmail.TabIndex = 5;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(20, 205);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(72, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.AnimateReadOnly = false;
            txtMatKhau.BackgroundImageLayout = ImageLayout.None;
            txtMatKhau.CharacterCasing = CharacterCasing.Normal;
            txtMatKhau.Depth = 0;
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatKhau.HideSelection = true;
            txtMatKhau.LeadingIcon = null;
            txtMatKhau.Location = new Point(130, 195);
            txtMatKhau.MaxLength = 255;
            txtMatKhau.MouseState = MaterialSkin.MouseState.OUT;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PrefixSuffixText = null;
            txtMatKhau.ReadOnly = false;
            txtMatKhau.RightToLeft = RightToLeft.No;
            txtMatKhau.SelectedText = "";
            txtMatKhau.SelectionLength = 0;
            txtMatKhau.SelectionStart = 0;
            txtMatKhau.ShortcutsEnabled = true;
            txtMatKhau.Size = new Size(250, 48);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.TabStop = false;
            txtMatKhau.TextAlign = HorizontalAlignment.Left;
            txtMatKhau.TrailingIcon = null;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(20, 25);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(51, 19);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "Vai trò:";
            // 
            // rbVaiTroAdmin
            // 
            rbVaiTroAdmin.AutoSize = true;
            rbVaiTroAdmin.Depth = 0;
            rbVaiTroAdmin.Location = new Point(100, 15);
            rbVaiTroAdmin.Margin = new Padding(0);
            rbVaiTroAdmin.MouseLocation = new Point(-1, -1);
            rbVaiTroAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            rbVaiTroAdmin.Name = "rbVaiTroAdmin";
            rbVaiTroAdmin.Ripple = true;
            rbVaiTroAdmin.Size = new Size(81, 37);
            rbVaiTroAdmin.TabIndex = 1;
            rbVaiTroAdmin.TabStop = true;
            rbVaiTroAdmin.Text = "Admin";
            rbVaiTroAdmin.UseVisualStyleBackColor = true;
            // 
            // rbVaiTroNhanVien
            // 
            rbVaiTroNhanVien.AutoSize = true;
            rbVaiTroNhanVien.Depth = 0;
            rbVaiTroNhanVien.Location = new Point(230, 15);
            rbVaiTroNhanVien.Margin = new Padding(0);
            rbVaiTroNhanVien.MouseLocation = new Point(-1, -1);
            rbVaiTroNhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            rbVaiTroNhanVien.Name = "rbVaiTroNhanVien";
            rbVaiTroNhanVien.Ripple = true;
            rbVaiTroNhanVien.Size = new Size(106, 37);
            rbVaiTroNhanVien.TabIndex = 2;
            rbVaiTroNhanVien.TabStop = true;
            rbVaiTroNhanVien.Text = "Nhân viên";
            rbVaiTroNhanVien.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(20, 25);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(78, 19);
            materialLabel6.TabIndex = 0;
            materialLabel6.Text = "Trạng thái:";
            // 
            // rbTrangThaiActive
            // 
            rbTrangThaiActive.AutoSize = true;
            rbTrangThaiActive.Depth = 0;
            rbTrangThaiActive.Location = new Point(100, 15);
            rbTrangThaiActive.Margin = new Padding(0);
            rbTrangThaiActive.MouseLocation = new Point(-1, -1);
            rbTrangThaiActive.MouseState = MaterialSkin.MouseState.HOVER;
            rbTrangThaiActive.Name = "rbTrangThaiActive";
            rbTrangThaiActive.Ripple = true;
            rbTrangThaiActive.Size = new Size(110, 37);
            rbTrangThaiActive.TabIndex = 1;
            rbTrangThaiActive.TabStop = true;
            rbTrangThaiActive.Text = "Hoạt động";
            rbTrangThaiActive.UseVisualStyleBackColor = true;
            // 
            // rbTrangThaiInactive
            // 
            rbTrangThaiInactive.AutoSize = true;
            rbTrangThaiInactive.Depth = 0;
            rbTrangThaiInactive.Location = new Point(220, 14);
            rbTrangThaiInactive.Margin = new Padding(0);
            rbTrangThaiInactive.MouseLocation = new Point(-1, -1);
            rbTrangThaiInactive.MouseState = MaterialSkin.MouseState.HOVER;
            rbTrangThaiInactive.Name = "rbTrangThaiInactive";
            rbTrangThaiInactive.Ripple = true;
            rbTrangThaiInactive.Size = new Size(160, 37);
            rbTrangThaiInactive.TabIndex = 2;
            rbTrangThaiInactive.TabStop = true;
            rbTrangThaiInactive.Text = "Ngừng hoạt động";
            rbTrangThaiInactive.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnThem.Depth = 0;
            btnThem.HighEmphasis = true;
            btnThem.Icon = null;
            btnThem.Location = new Point(20, 20);
            btnThem.Margin = new Padding(4, 6, 4, 6);
            btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            btnThem.Name = "btnThem";
            btnThem.NoAccentTextColor = Color.Empty;
            btnThem.Size = new Size(64, 36);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnThem.UseAccentColor = false;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSua.Depth = 0;
            btnSua.HighEmphasis = true;
            btnSua.Icon = null;
            btnSua.Location = new Point(117, 20);
            btnSua.Margin = new Padding(4, 6, 4, 6);
            btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            btnSua.Name = "btnSua";
            btnSua.NoAccentTextColor = Color.Empty;
            btnSua.Size = new Size(64, 36);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSua.UseAccentColor = false;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnXoa.Depth = 0;
            btnXoa.HighEmphasis = true;
            btnXoa.Icon = null;
            btnXoa.Location = new Point(203, 20);
            btnXoa.Margin = new Padding(4, 6, 4, 6);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(64, 36);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // materialCardInput
            // 
            materialCardInput.BackColor = Color.FromArgb(255, 255, 255);
            materialCardInput.Controls.Add(materialLabel1);
            materialCardInput.Controls.Add(txtMaNV);
            materialCardInput.Controls.Add(materialLabel2);
            materialCardInput.Controls.Add(txtHoTen);
            materialCardInput.Controls.Add(materialLabel3);
            materialCardInput.Controls.Add(txtEmail);
            materialCardInput.Controls.Add(materialLabel4);
            materialCardInput.Controls.Add(txtMatKhau);
            materialCardInput.Depth = 0;
            materialCardInput.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardInput.Location = new Point(20, 70);
            materialCardInput.Margin = new Padding(14);
            materialCardInput.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardInput.Name = "materialCardInput";
            materialCardInput.Padding = new Padding(14);
            materialCardInput.Size = new Size(400, 260);
            materialCardInput.TabIndex = 0;
            // 
            // materialCardVaiTro
            // 
            materialCardVaiTro.BackColor = Color.FromArgb(255, 255, 255);
            materialCardVaiTro.Controls.Add(materialLabel5);
            materialCardVaiTro.Controls.Add(rbVaiTroAdmin);
            materialCardVaiTro.Controls.Add(rbVaiTroNhanVien);
            materialCardVaiTro.Depth = 0;
            materialCardVaiTro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardVaiTro.Location = new Point(20, 345);
            materialCardVaiTro.Margin = new Padding(14);
            materialCardVaiTro.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardVaiTro.Name = "materialCardVaiTro";
            materialCardVaiTro.Padding = new Padding(14);
            materialCardVaiTro.Size = new Size(400, 70);
            materialCardVaiTro.TabIndex = 1;
            // 
            // materialCardTrangThai
            // 
            materialCardTrangThai.BackColor = Color.FromArgb(255, 255, 255);
            materialCardTrangThai.Controls.Add(materialLabel6);
            materialCardTrangThai.Controls.Add(rbTrangThaiActive);
            materialCardTrangThai.Controls.Add(rbTrangThaiInactive);
            materialCardTrangThai.Depth = 0;
            materialCardTrangThai.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardTrangThai.Location = new Point(20, 430);
            materialCardTrangThai.Margin = new Padding(14);
            materialCardTrangThai.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardTrangThai.Name = "materialCardTrangThai";
            materialCardTrangThai.Padding = new Padding(14);
            materialCardTrangThai.Size = new Size(400, 70);
            materialCardTrangThai.TabIndex = 2;
            // 
            // materialCardActions
            // 
            materialCardActions.BackColor = Color.FromArgb(255, 255, 255);
            materialCardActions.Controls.Add(btnLamMoi);
            materialCardActions.Controls.Add(btnThem);
            materialCardActions.Controls.Add(btnSua);
            materialCardActions.Controls.Add(btnXoa);
            materialCardActions.Depth = 0;
            materialCardActions.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardActions.Location = new Point(20, 515);
            materialCardActions.Margin = new Padding(14);
            materialCardActions.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardActions.Name = "materialCardActions";
            materialCardActions.Padding = new Padding(14);
            materialCardActions.Size = new Size(400, 70);
            materialCardActions.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            btnLamMoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLamMoi.Depth = 0;
            btnLamMoi.HighEmphasis = true;
            btnLamMoi.Icon = null;
            btnLamMoi.Location = new Point(306, 20);
            btnLamMoi.Margin = new Padding(4, 6, 4, 6);
            btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.NoAccentTextColor = Color.Empty;
            btnLamMoi.Size = new Size(83, 36);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLamMoi.UseAccentColor = false;
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // materialCardDGV
            // 
            materialCardDGV.BackColor = Color.FromArgb(255, 255, 255);
            materialCardDGV.Controls.Add(dgvNhanVien);
            materialCardDGV.Depth = 0;
            materialCardDGV.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardDGV.Location = new Point(440, 70);
            materialCardDGV.Margin = new Padding(14);
            materialCardDGV.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardDGV.Name = "materialCardDGV";
            materialCardDGV.Padding = new Padding(14);
            materialCardDGV.Size = new Size(820, 660);
            materialCardDGV.TabIndex = 4;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeTable = false;
            dgvNhanVien.BackColor = Color.FromArgb(255, 255, 255);
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.Depth = 0;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Font = new Font("Microsoft Sans Serif", 24F);
            dgvNhanVien.FullRowSelect = true;
            dgvNhanVien.Location = new Point(14, 14);
            dgvNhanVien.MinimumSize = new Size(200, 100);
            dgvNhanVien.MouseLocation = new Point(-1, -1);
            dgvNhanVien.MouseState = MaterialSkin.MouseState.OUT;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.OwnerDraw = true;
            dgvNhanVien.Size = new Size(792, 632);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.UseCompatibleStateImageBehavior = false;
            dgvNhanVien.View = View.Details;
            // 
            // frmquanlynhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 754);
            Controls.Add(materialCardDGV);
            Controls.Add(materialCardActions);
            Controls.Add(materialCardTrangThai);
            Controls.Add(materialCardVaiTro);
            Controls.Add(materialCardInput);
            Name = "frmquanlynhanvien";
            Text = "Quản Lý Nhân Viên";
            Load += frmquanlynhanvien_Load;
            materialCardInput.ResumeLayout(false);
            materialCardInput.PerformLayout();
            materialCardVaiTro.ResumeLayout(false);
            materialCardVaiTro.PerformLayout();
            materialCardTrangThai.ResumeLayout(false);
            materialCardTrangThai.PerformLayout();
            materialCardActions.ResumeLayout(false);
            materialCardActions.PerformLayout();
            materialCardDGV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Khai báo lại tất cả các control để đảm bảo chúng được khởi tạo đúng cách
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMaNV;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtHoTen;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtMatKhau;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton rbVaiTroAdmin;
        private MaterialSkin.Controls.MaterialRadioButton rbVaiTroNhanVien;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton rbTrangThaiActive;
        private MaterialSkin.Controls.MaterialRadioButton rbTrangThaiInactive;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialCard materialCardInput;
        private MaterialSkin.Controls.MaterialCard materialCardVaiTro;
        private MaterialSkin.Controls.MaterialCard materialCardTrangThai;
        private MaterialSkin.Controls.MaterialCard materialCardActions;
        private MaterialSkin.Controls.MaterialCard materialCardDGV;
        private MaterialSkin.Controls.MaterialListView dgvNhanVien;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
    }
}