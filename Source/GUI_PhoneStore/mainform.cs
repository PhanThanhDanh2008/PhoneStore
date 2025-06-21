namespace GUI_PhoneStore
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void LoadChildForm(Form childForm)
        {
            // Đóng form hiện tại nếu có
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose(); // Giải phóng tài nguyên
            }

            activeForm = childForm;
            childForm.TopLevel = false; // Đặt form con không phải là form độc lập
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền form con
            childForm.Dock = DockStyle.Fill; // Đặt form con lấp đầy panel
            this.pnlContent.Controls.Add(childForm); // Thêm form con vào panel
            this.pnlContent.Tag = childForm; // Gán tag để quản lý form con
            childForm.BringToFront(); // Đưa form con lên trên cùng
            childForm.Show(); // Hiển thị form con
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmBanHang());
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmquanlynhanvien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmKhachHang());
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            LoadChildForm(new frmLoaiSanPham());
        }
    }
}