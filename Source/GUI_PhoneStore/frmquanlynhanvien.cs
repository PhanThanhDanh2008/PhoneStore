using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace GUI_PhoneStore
{
    public partial class frmquanlynhanvien : Form
    {
        public frmquanlynhanvien()
        {
            InitializeComponent();

        }
        // Trong frmquanlynhanvien.cs, trong hàm khởi tạo hoặc sự kiện Load của form
        private void SetupListViewColumns()
        {
            dgvNhanVien.Columns.Add("MaNV", 120, System.Windows.Forms.HorizontalAlignment.Left);
            dgvNhanVien.Columns.Add("HoTen", 120, System.Windows.Forms.HorizontalAlignment.Left);
            dgvNhanVien.Columns.Add("Email", 120, System.Windows.Forms.HorizontalAlignment.Left);
            dgvNhanVien.Columns.Add("MatKhau", 120, System.Windows.Forms.HorizontalAlignment.Left); // Thường không hiển thị mật khẩu
            dgvNhanVien.Columns.Add("VaiTro", 120, System.Windows.Forms.HorizontalAlignment.Center);
            dgvNhanVien.Columns.Add("TrangThai", 120, System.Windows.Forms.HorizontalAlignment.Center);
        }
        private void frmquanlynhanvien_Load(object sender, EventArgs e)
        {
            SetupListViewColumns();
        }
    }
}
