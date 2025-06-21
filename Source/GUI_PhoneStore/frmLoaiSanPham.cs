using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PhoneStore
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            SetupListViewColumns();
        }
        private void SetupListViewColumns()
        {
            dgvLoaiSanPham.Columns.Clear();
            dgvLoaiSanPham.Columns.Add("MaLoai", "Mã Loại");
            dgvLoaiSanPham.Columns.Add("TenLoai", "Tên Loại");
            dgvLoaiSanPham.Columns.Add("GhiChu", "Ghi Chú");
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiSanPham.AllowUserToAddRows = false; // Không cho phép thêm dòng mới
            dgvLoaiSanPham.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
            dgvLoaiSanPham.RowHeadersVisible = false; // Ẩn tiêu đề dòng
        }   
    }
}
