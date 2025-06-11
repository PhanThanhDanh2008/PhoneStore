namespace GUI_PhoneStore
{
    partial class mainform
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
            panel1 = new Panel();
            LBlblMenuTitle = new Label();
            pnlContent = new Panel();
            panel2 = new Panel();
            btnQuanLyNhanVien = new MaterialSkin.Controls.MaterialButton();
            btnHeThong = new MaterialSkin.Controls.MaterialButton();
            btnBaoCao = new MaterialSkin.Controls.MaterialButton();
            btnQuanLyDonHang = new MaterialSkin.Controls.MaterialButton();
            btnBanHang = new MaterialSkin.Controls.MaterialButton();
            btnKhachHang = new MaterialSkin.Controls.MaterialButton();
            btnSanPham = new MaterialSkin.Controls.MaterialButton();
            btnLoaiSanPham = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(LBlblMenuTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1497, 58);
            panel1.TabIndex = 0;
            // 
            // LBlblMenuTitle
            // 
            LBlblMenuTitle.AutoSize = true;
            LBlblMenuTitle.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBlblMenuTitle.ForeColor = Color.White;
            LBlblMenuTitle.Location = new Point(48, 9);
            LBlblMenuTitle.Name = "LBlblMenuTitle";
            LBlblMenuTitle.Size = new Size(117, 42);
            LBlblMenuTitle.TabIndex = 0;
            LBlblMenuTitle.Text = "MENU";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.Location = new Point(210, 59);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1287, 754);
            pnlContent.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnQuanLyNhanVien);
            panel2.Controls.Add(btnHeThong);
            panel2.Controls.Add(btnBaoCao);
            panel2.Controls.Add(btnQuanLyDonHang);
            panel2.Controls.Add(btnBanHang);
            panel2.Controls.Add(btnKhachHang);
            panel2.Controls.Add(btnSanPham);
            panel2.Controls.Add(btnLoaiSanPham);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 755);
            panel2.TabIndex = 10;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuanLyNhanVien.BackColor = SystemColors.ActiveCaptionText;
            btnQuanLyNhanVien.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnQuanLyNhanVien.Depth = 0;
            btnQuanLyNhanVien.HighEmphasis = false;
            btnQuanLyNhanVien.Icon = null;
            btnQuanLyNhanVien.Location = new Point(4, 268);
            btnQuanLyNhanVien.Margin = new Padding(4, 6, 4, 6);
            btnQuanLyNhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.NoAccentTextColor = Color.White;
            btnQuanLyNhanVien.Size = new Size(163, 36);
            btnQuanLyNhanVien.TabIndex = 24;
            btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            btnQuanLyNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyNhanVien.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnQuanLyNhanVien.UseAccentColor = false;
            btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            btnQuanLyNhanVien.Click += btnQuanLyNhanVien_Click;
            // 
            // btnHeThong
            // 
            btnHeThong.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHeThong.BackColor = SystemColors.ActiveCaptionText;
            btnHeThong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnHeThong.Depth = 0;
            btnHeThong.HighEmphasis = false;
            btnHeThong.Icon = null;
            btnHeThong.Location = new Point(30, 455);
            btnHeThong.Margin = new Padding(4, 6, 4, 6);
            btnHeThong.MouseState = MaterialSkin.MouseState.HOVER;
            btnHeThong.Name = "btnHeThong";
            btnHeThong.NoAccentTextColor = Color.White;
            btnHeThong.Size = new Size(94, 36);
            btnHeThong.TabIndex = 23;
            btnHeThong.Text = "Hệ thống";
            btnHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnHeThong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnHeThong.UseAccentColor = false;
            btnHeThong.UseVisualStyleBackColor = false;
            // 
            // btnBaoCao
            // 
            btnBaoCao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBaoCao.BackColor = SystemColors.ActiveCaptionText;
            btnBaoCao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBaoCao.Depth = 0;
            btnBaoCao.HighEmphasis = false;
            btnBaoCao.Icon = null;
            btnBaoCao.Location = new Point(30, 385);
            btnBaoCao.Margin = new Padding(4, 6, 4, 6);
            btnBaoCao.MouseState = MaterialSkin.MouseState.HOVER;
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.NoAccentTextColor = Color.White;
            btnBaoCao.Size = new Size(83, 36);
            btnBaoCao.TabIndex = 22;
            btnBaoCao.Text = "Báo cáo";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnBaoCao.UseAccentColor = false;
            btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyDonHang
            // 
            btnQuanLyDonHang.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuanLyDonHang.BackColor = SystemColors.ActiveCaptionText;
            btnQuanLyDonHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnQuanLyDonHang.Depth = 0;
            btnQuanLyDonHang.HighEmphasis = false;
            btnQuanLyDonHang.Icon = null;
            btnQuanLyDonHang.Location = new Point(13, 316);
            btnQuanLyDonHang.Margin = new Padding(4, 6, 4, 6);
            btnQuanLyDonHang.MouseState = MaterialSkin.MouseState.HOVER;
            btnQuanLyDonHang.Name = "btnQuanLyDonHang";
            btnQuanLyDonHang.NoAccentTextColor = Color.White;
            btnQuanLyDonHang.Size = new Size(161, 36);
            btnQuanLyDonHang.TabIndex = 21;
            btnQuanLyDonHang.Text = "Quản lý đơn hàng";
            btnQuanLyDonHang.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLyDonHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnQuanLyDonHang.UseAccentColor = false;
            btnQuanLyDonHang.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            btnBanHang.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBanHang.BackColor = SystemColors.ActiveCaptionText;
            btnBanHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBanHang.Depth = 0;
            btnBanHang.HighEmphasis = false;
            btnBanHang.Icon = null;
            btnBanHang.Location = new Point(30, 23);
            btnBanHang.Margin = new Padding(4, 6, 4, 6);
            btnBanHang.MouseState = MaterialSkin.MouseState.HOVER;
            btnBanHang.Name = "btnBanHang";
            btnBanHang.NoAccentTextColor = Color.White;
            btnBanHang.Size = new Size(95, 36);
            btnBanHang.TabIndex = 20;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnBanHang.UseAccentColor = false;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKhachHang.BackColor = SystemColors.ActiveCaptionText;
            btnKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnKhachHang.Depth = 0;
            btnKhachHang.HighEmphasis = false;
            btnKhachHang.Icon = null;
            btnKhachHang.Location = new Point(4, 211);
            btnKhachHang.Margin = new Padding(4, 6, 4, 6);
            btnKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.NoAccentTextColor = Color.White;
            btnKhachHang.Size = new Size(180, 36);
            btnKhachHang.TabIndex = 19;
            btnKhachHang.Text = "Quản lý khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnKhachHang.UseAccentColor = false;
            btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            btnSanPham.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSanPham.BackColor = SystemColors.ActiveCaptionText;
            btnSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSanPham.Depth = 0;
            btnSanPham.HighEmphasis = false;
            btnSanPham.Icon = null;
            btnSanPham.Location = new Point(4, 141);
            btnSanPham.Margin = new Padding(4, 6, 4, 6);
            btnSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            btnSanPham.Name = "btnSanPham";
            btnSanPham.NoAccentTextColor = Color.White;
            btnSanPham.Size = new Size(161, 36);
            btnSanPham.TabIndex = 18;
            btnSanPham.Text = "Quản lý sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnSanPham.UseAccentColor = false;
            btnSanPham.UseVisualStyleBackColor = false;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoaiSanPham.BackColor = SystemColors.ActiveCaptionText;
            btnLoaiSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLoaiSanPham.Depth = 0;
            btnLoaiSanPham.HighEmphasis = false;
            btnLoaiSanPham.Icon = null;
            btnLoaiSanPham.Location = new Point(4, 71);
            btnLoaiSanPham.Margin = new Padding(4, 6, 4, 6);
            btnLoaiSanPham.MouseState = MaterialSkin.MouseState.HOVER;
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.NoAccentTextColor = Color.White;
            btnLoaiSanPham.Size = new Size(196, 36);
            btnLoaiSanPham.TabIndex = 17;
            btnLoaiSanPham.Text = "Quản lý loại sản phẩm";
            btnLoaiSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnLoaiSanPham.UseAccentColor = false;
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 813);
            Controls.Add(panel2);
            Controls.Add(pnlContent);
            Controls.Add(panel1);
            Name = "mainform";
            Text = "Hệ thống Quản lý Bán hàng";
            Load += mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlContent;
        private MaterialSkin.Controls.MaterialLabel lblMenuTitle;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnHeThong;
        private MaterialSkin.Controls.MaterialButton btnBaoCao;
        private MaterialSkin.Controls.MaterialButton btnQuanLyDonHang;
        private MaterialSkin.Controls.MaterialButton btnBanHang;
        private MaterialSkin.Controls.MaterialButton btnKhachHang;
        private MaterialSkin.Controls.MaterialButton btnSanPham;
        private MaterialSkin.Controls.MaterialButton btnLoaiSanPham;
        private Label LBlblMenuTitle;
        private MaterialSkin.Controls.MaterialButton btnQuanLyNhanVien;
    }
}
