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
    public partial class frmLoaiSanPham : Form
    {
        private readonly BusLoaiSanPham _busLoaiSanPham = new BusLoaiSanPham();
        private List<LoaiSanPham> _listLoaiSanPham;

        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            SetupListViewColumns();
            LoadDataToListView();
        }

        private void SetupListViewColumns()
        {
            dgvLoaiSanPham.Columns.Clear();
            dgvLoaiSanPham.Columns.Add("MaLoai", "Mã Loại");
            dgvLoaiSanPham.Columns.Add("TenLoai", "Tên Loại");
            dgvLoaiSanPham.Columns.Add("GhiChu", "Ghi Chú");
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiSanPham.AllowUserToAddRows = false;
            dgvLoaiSanPham.ReadOnly = true;
            dgvLoaiSanPham.RowHeadersVisible = false;
        }

        private void LoadDataToListView()
        {
            try
            {
                dgvLoaiSanPham.Rows.Clear();
                _listLoaiSanPham = _busLoaiSanPham.GetLoaiSanPhamList();
                if (_listLoaiSanPham != null && _listLoaiSanPham.Count > 0)
                {
                    foreach (LoaiSanPham lsp in _listLoaiSanPham)
                    {
                        int rowIndex = dgvLoaiSanPham.Rows.Add(
                            lsp.MaLoai,
                            lsp.TenLoai,
                            lsp.GhiChu
                        );
                        dgvLoaiSanPham.Rows[rowIndex].Tag = lsp;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu loại sản phẩm để hiển thị.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại sản phẩm: " + ex.Message, "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenLoai.Text.Trim()))
                {
                    MessageBox.Show("Tên loại không được để trống!", "Lỗi",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenLoai.Focus();
                    return;
                }

                LoaiSanPham lsp = new LoaiSanPham
                {
                    TenLoai = txtTenLoai.Text.Trim(),
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };
                string result = _busLoaiSanPham.AddLoaiSanPham(lsp);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo",
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
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoaiSanPham.Rows.Count)
            {
                DataGridViewRow row = dgvLoaiSanPham.Rows[e.RowIndex];
                if (row.Tag is LoaiSanPham lsp)
                {
                    txtMaLoai.Text = lsp.MaLoai;
                    txtTenLoai.Text = lsp.TenLoai;
                    txtGhiChu.Text = lsp.GhiChu ?? "";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm để sửa!", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoaiSanPham lsp = new LoaiSanPham
                {
                    MaLoai = txtMaLoai.Text.Trim(), // Giữ nguyên MaLoai, không sửa
                    TenLoai = txtTenLoai.Text.Trim(),
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };
                string result = _busLoaiSanPham.UpdateLoaiSanPham(lsp);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo",
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
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLoai.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn một loại sản phẩm để xóa.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maLoai = txtMaLoai.Text.Trim();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này?", "Xác nhận xóa",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string result = _busLoaiSanPham.DeleteLoaiSanPham(maLoai);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Xóa loại sản phẩm thành công!", "Thông báo",
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
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}