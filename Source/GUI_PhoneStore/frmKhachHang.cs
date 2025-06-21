using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PhoneStore;
using DTO_PhoneStore;

namespace GUI_PhoneStore
{
    public partial class frmKhachHang : Form
    {
        private readonly BusKhachhang _busKhachHang = new BusKhachhang();
        private List<KhachHang> _listKhachHang;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SetupListViewColumns();
            LoadDataToListView();

        }
        private void ClearInputFields()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtDiemTichLuy.Text = "";
            rbHoatDong.Checked = true;
        }
        private void LoadDataToListView()
        {
            try
            {
                _listKhachHang = _busKhachHang.GetAllKhachHang();
                dgvKhachHang.Rows.Clear();
                if (_listKhachHang != null && _listKhachHang.Count > 0)
                {
                    foreach (var kh in _listKhachHang)
                    {
                        int rowIndex = dgvKhachHang.Rows.Add(
                            kh.MaKH,
                            kh.HoTen,
                            kh.Email ?? "",
                            kh.SoDienThoai,
                            kh.DiaChi ?? "",
                            kh.DiemTichLuy,
                            kh.TrangThaiText
                        );
                        dgvKhachHang.Rows[rowIndex].Tag = kh;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu khách hàng để hiển thị.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupListViewColumns()
        {
            // Xóa các cột cũ
            dgvKhachHang.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvKhachHang.Columns.Add("MaKH", "Mã KH");
            dgvKhachHang.Columns.Add("HoTen", "Họ Tên");
            dgvKhachHang.Columns.Add("Email", "Email");
            dgvKhachHang.Columns.Add("SoDienThoai", "Số Điện Thoại");
            dgvKhachHang.Columns.Add("DiaChi", "Địa Chỉ");
            dgvKhachHang.Columns.Add("DiemTichLuy", "Điểm Tích Lũy");
            dgvKhachHang.Columns.Add("TrangThai", "Trạng Thái");

            // Sử dụng AutoSizeColumnsMode.Fill để cột tự động giãn
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.RowHeadersVisible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //input ko đc để trông 
            if (string.IsNullOrEmpty(txtHoTen.Text.Trim()) || string.IsNullOrEmpty(txtSoDienThoai.Text.Trim()))

            {

                MessageBox.Show("Họ tên và Số điện thoại không được để trống.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Tạo đối tượng KhachHang từ dữ liệu nhập, MaKH sẽ được sinh tự động
                KhachHang kh = new KhachHang
                {
                    HoTen = txtHoTen.Text.Trim(),
                    Email = string.IsNullOrEmpty(txtEmail.Text.Trim()) ? null : txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    DiaChi = string.IsNullOrEmpty(txtDiaChi.Text.Trim()) ? null : txtDiaChi.Text.Trim(),
                    DiemTichLuy = int.Parse(txtDiemTichLuy.Text.Trim()),
                    TrangThai = rbHoatDong.Checked
                };

                // Gọi phương thức Insert từ BusKhachhang
                string result = _busKhachHang.AddKhachHang(kh);

                // Kiểm tra kết quả
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadDataToListView();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}\nStackTrace: {ex.StackTrace}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn khách hàng để sửa chưa
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng KhachHang từ dữ liệu nhập
                KhachHang kh = new KhachHang
                {
                    MaKH = txtMaKH.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    Email = string.IsNullOrEmpty(txtEmail.Text.Trim()) ? null : txtEmail.Text.Trim(),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    DiaChi = string.IsNullOrEmpty(txtDiaChi.Text.Trim()) ? null : txtDiaChi.Text.Trim(),
                    DiemTichLuy = int.Parse(txtDiemTichLuy.Text.Trim()),
                    TrangThai = rbHoatDong.Checked
                };

                // Gọi phương thức Update từ BusKhachhang
                string result = _busKhachHang.UpdateKhachHang(kh);

                // Kiểm tra kết quả
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadDataToListView();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa khách hàng: {ex.Message}\nStackTrace: {ex.StackTrace}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = txtMaKH.Text.Trim();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Gọi phương thức Delete từ BusKhachhang
                string result = _busKhachHang.DeleteKhachHang(maKH);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadDataToListView();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClearInputFields();
                LoadDataToListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                if (row.Tag is KhachHang kh)
                {
                    txtMaKH.Text = kh.MaKH;
                    txtHoTen.Text = kh.HoTen;
                    txtEmail.Text = kh.Email ?? "";
                    txtSoDienThoai.Text = kh.SoDienThoai;
                    txtDiaChi.Text = kh.DiaChi ?? "";
                    txtDiemTichLuy.Text = kh.DiemTichLuy.ToString();
                    rbHoatDong.Checked = kh.TrangThai;
                    rbTamNgung.Checked = !kh.TrangThai;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    LoadDataToListView();
                    return;
                }

                _listKhachHang = _busKhachHang.GetAllKhachHang();
                var filteredList = _listKhachHang.Where(k => k.HoTen.Contains(keyword)).ToList();
                dgvKhachHang.Rows.Clear();
                foreach (var kh in filteredList)
                {
                    int rowIndex = dgvKhachHang.Rows.Add(
                        kh.MaKH,
                        kh.HoTen,
                        kh.Email ?? "",
                        kh.SoDienThoai,
                        kh.DiaChi ?? "",
                        kh.DiemTichLuy,
                        kh.TrangThaiText
                    );
                    dgvKhachHang.Rows[rowIndex].Tag = kh;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            // chỉ cho nhập số dương 
            if (!string.IsNullOrEmpty(txtSoDienThoai.Text) && !long.TryParse(txtSoDienThoai.Text, out _))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Text = string.Empty;
            }
        }

        private void txtDiemTichLuy_TextChanged(object sender, EventArgs e)
        {
            // chỉ cho nhập số nguyên dương 
            if (!string.IsNullOrEmpty(txtDiemTichLuy.Text) && !int.TryParse(txtDiemTichLuy.Text, out _))
            {
                MessageBox.Show("Điểm tích lũy chỉ được nhập số nguyên dương.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemTichLuy.Text = string.Empty;
            }
        }
    }
}
