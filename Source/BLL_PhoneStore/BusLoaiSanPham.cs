using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PhoneStore;
using DTO_PhoneStore;

namespace BLL_PhoneStore
{
    public class BusLoaiSanPham
    {
        private readonly DalLoaiSanPham _dalLoaiSanPham = new DalLoaiSanPham();

        public List<LoaiSanPham> GetLoaiSanPhamList()
        {
            try
            {
                return _dalLoaiSanPham.GetLoaiSanPhamList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại sản phẩm: " + ex.Message);
            }
        }

        public string AddLoaiSanPham(LoaiSanPham lsp)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lsp.TenLoai))
                    return "Tên loại không được để trống.";

                // Tự động sinh mã loại sản phẩm
                lsp.MaLoai = _dalLoaiSanPham.GenerateMaLoai();

                if (_dalLoaiSanPham.GetLoaiSanPhamByMaLoai(lsp.MaLoai) != null)
                    return "Mã loại sản phẩm đã tồn tại (lỗi hệ thống).";

                _dalLoaiSanPham.AddLoaiSanPham(lsp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm loại sản phẩm: " + ex.Message;
            }
        }

        public string UpdateLoaiSanPham(LoaiSanPham lsp)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lsp.MaLoai))
                    return "Mã loại không được để trống.";
                if (_dalLoaiSanPham.GetLoaiSanPhamByMaLoai(lsp.MaLoai) == null)
                    return "Không tìm thấy loại sản phẩm để cập nhật.";

                // Không cho phép sửa MaLoai, chỉ cập nhật TenLoai và GhiChu
                LoaiSanPham existingLsp = _dalLoaiSanPham.GetLoaiSanPhamByMaLoai(lsp.MaLoai);
                if (existingLsp != null)
                {
                    existingLsp.TenLoai = lsp.TenLoai;
                    existingLsp.GhiChu = lsp.GhiChu;
                    _dalLoaiSanPham.UpdateLoaiSanPham(existingLsp);
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật loại sản phẩm: " + ex.Message;
            }
        }

        public string DeleteLoaiSanPham(string maLoai)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maLoai))
                    return "Mã loại không được để trống.";

                if (_dalLoaiSanPham.GetLoaiSanPhamByMaLoai(maLoai) == null)
                    return "Không tìm thấy loại sản phẩm để xóa.";

                _dalLoaiSanPham.DeleteLoaiSanPham(maLoai);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa loại sản phẩm: " + ex.Message;
            }
        }
    }
}