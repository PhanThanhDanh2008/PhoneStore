using System;
using System.Collections.Generic;
using DTO_PhoneStore;

namespace BLL_PhoneStore
{
    public class BusKhachhang
    {
        private readonly DAL_PhoneStore.DALKhachhang _dalKhachHang = new DAL_PhoneStore.DALKhachhang();

        public List<KhachHang> GetAllKhachHang()
        {
            try
            {
                return _dalKhachHang.GetAllKhachHang();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong nghiệp vụ: " + ex.Message);
            }
        }

        public string AddKhachHang(KhachHang kh)
        {
            try
            {
                if (string.IsNullOrEmpty(kh.HoTen) || string.IsNullOrEmpty(kh.SoDienThoai))
                    return "Họ tên và Số điện thoại không được để trống.";

                // Tự động sinh mã khách hàng
                kh.MaKH = _dalKhachHang.GenerateMaKhachHang();

                if (_dalKhachHang.GetKhachHangByMaKH(kh.MaKH) != null)
                    return "Mã khách hàng đã tồn tại (lỗi hệ thống).";

                _dalKhachHang.AddKhachHang(kh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm khách hàng: " + ex.Message;
            }
        }

        public string UpdateKhachHang(KhachHang kh)
        {
            try
            {
                if (string.IsNullOrEmpty(kh.MaKH))
                    return "Mã khách hàng không được để trống.";

                if (_dalKhachHang.GetKhachHangByMaKH(kh.MaKH) == null)
                    return "Không tìm thấy khách hàng để cập nhật.";

                _dalKhachHang.UpdateKhachHang(kh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật khách hàng: " + ex.Message;
            }
        }

        public string DeleteKhachHang(string maKH)
        {
            try
            {
                if (string.IsNullOrEmpty(maKH))
                    return "Mã khách hàng không được để trống.";

                if (_dalKhachHang.GetKhachHangByMaKH(maKH) == null)
                    return "Không tìm thấy khách hàng để xóa.";

                _dalKhachHang.DeleteKhachHang(maKH);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa khách hàng: " + ex.Message;
            }
        }
    }
}