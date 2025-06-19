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
using DAL_PhoneStore;
using DTO_PhoneStore;
using MaterialSkin;

namespace GUI_PhoneStore
{
    public partial class frmquanlynhanvien : Form
    {
        private BusNhanVien busNhanVien;
        private List<NhanVien> listNhanVien;
        private object selectedNhanVien;

        public frmquanlynhanvien()
        {
            InitializeComponent();
            busNhanVien = new BusNhanVien(); // Khởi tạo BusNhanVien

        }
        private void SetupListViewColumns()
        {
            // Xóa các cột cũ
            dgvNhanVien.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvNhanVien.Columns.Add("MaNV", "Mã NV");
            dgvNhanVien.Columns.Add("HoTen", "Họ Tên");
            dgvNhanVien.Columns.Add("Email", "Email");
            dgvNhanVien.Columns.Add("MatKhau", "Mật Khẩu");
            dgvNhanVien.Columns.Add("VaiTro", "Vai Trò");
            dgvNhanVien.Columns.Add("TrangThai", "Trạng Thái");

            // Sử dụng AutoSizeColumnsMode.Fill để cột tự động giãn
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.RowHeadersVisible = false;
        }

        private void LoadDataToListView()
        {
            try
            {
                // Xóa dữ liệu cũ
                dgvNhanVien.Rows.Clear();

                // Lấy danh sách nhân viên từ BLL
                listNhanVien = busNhanVien.GetNhanVienList();

                if (listNhanVien != null && listNhanVien.Count > 0)
                {
                    foreach (NhanVien nv in listNhanVien)
                    {
                        // Thêm dòng vào DataGridView, bao gồm Mật Khẩu
                        int rowIndex = dgvNhanVien.Rows.Add(nv.MaNV, nv.HoTen, nv.Email, nv.MatKhau, nv.VaiTroText, nv.TrangThaiText);
                        // Lưu trữ object NhanVien vào Tag của dòng
                        dgvNhanVien.Rows[rowIndex].Tag = nv;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nhân viên để hiển thị.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void frmquanlynhanvien_Load(object sender, EventArgs e)
        {
            SetupListViewColumns();
            LoadDataToListView();
        }

        private void RefreshData()
        {
            LoadDataToListView();
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = ""; // Xóa trường mật khẩu
            rbVaiTroNhanVien.Checked = true;
            rbTrangThaiActive.Checked = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                NhanVien nv = row.Tag as NhanVien;

                if (nv != null)
                {
                    txtMaNV.Text = nv.MaNV;
                    txtHoTen.Text = nv.HoTen;
                    txtEmail.Text = nv.Email;
                    txtMatKhau.Text = nv.MatKhau; // Hiển thị mật khẩu
                    rbVaiTroAdmin.Checked = nv.VaiTro;
                    rbVaiTroNhanVien.Checked = !nv.VaiTro;
                    rbTrangThaiActive.Checked = nv.TrangThai;
                    rbTrangThaiInactive.Checked = !nv.TrangThai;
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng NhanVien từ dữ liệu nhập
                NhanVien nv = new NhanVien
                {
                    HoTen = txtHoTen.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    VaiTro = rbVaiTroAdmin.Checked,
                    TrangThai = rbTrangThaiActive.Checked
                };

                // Gọi phương thức InsertNhanVien từ BusNhanVien
                string result = busNhanVien.InsertNhanVien(nv);

                // Kiểm tra kết quả
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}\nStackTrace: {ex.StackTrace}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn nhân viên để sửa chưa
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để sửa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng NhanVien từ dữ liệu nhập
                NhanVien nv = new NhanVien
                {
                    MaNV = txtMaNV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(), // Lấy mật khẩu mới nếu có
                    VaiTro = rbVaiTroAdmin.Checked,
                    TrangThai = rbTrangThaiActive.Checked
                };

                // Gọi phương thức UpdateNhanVien từ BusNhanVien
                string result = busNhanVien.UpdateNhanVien(nv);

                // Kiểm tra kết quả
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData(); // Làm mới DataGridView và xóa các ô nhập liệu
                }
                else
                {
                    MessageBox.Show(result, "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa nhân viên: {ex.Message}\nStackTrace: {ex.StackTrace}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txtMaNV.Text.Trim();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Replace BLLNHANVIEN with the correct class name
                BusNhanVien bus = new BusNhanVien();
                string result = bus.DeleteNhanVien(maNV);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadDataToListView();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2PanelInput_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

