using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PhoneStore;
using DTO_PhoneStore;

namespace BLL_PhoneStore
{
    public class BusNhanVien
    {
        DALNhanVien dalNhanVien = new DALNhanVien();

        public NhanVien DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            return dalNhanVien.getNhanVien1(username, password);
        }

        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }

                // Kiểm tra độ dài mật khẩu tối thiểu
                if (mk.Length < 6)
                {
                    return false;
                }

                dalNhanVien.ResetMatKhau(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<NhanVien> GetNhanVienList()
        {
            return dalNhanVien.selectAll();
        }

        public List<NhanVien> GetActiveNhanVienList()
        {
            return dalNhanVien.selectActive();
        }

        public NhanVien GetNhanVienById(string maNV)
        {
            if (string.IsNullOrEmpty(maNV))
            {
                return null;
            }
            return dalNhanVien.selectById(maNV);
        }

        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                // Validate dữ liệu đầu vào
                string validateResult = ValidateNhanVien(nv, true);
                if (!string.IsNullOrEmpty(validateResult))
                {
                    return validateResult;
                }

                // Tự động sinh mã nhân viên
                nv.MaNV = dalNhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNV))
                {
                    return "Không thể tạo mã nhân viên.";
                }

                // Kiểm tra email đã tồn tại
                if (dalNhanVien.checkEmailExists(nv.Email))
                {
                    return "Email đã tồn tại trong hệ thống.";
                }

                // Mặc định trạng thái active
                nv.TrangThai = true;

                dalNhanVien.insertNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi thêm nhân viên: " + ex.Message;
            }
        }

        public string UpdateNhanVien(NhanVien nv)
        {
            try
            {
                // Validate dữ liệu đầu vào
                string validateResult = ValidateNhanVien(nv, false);
                if (!string.IsNullOrEmpty(validateResult))
                {
                    return validateResult;
                }

                // Kiểm tra mã nhân viên có tồn tại
                if (string.IsNullOrEmpty(nv.MaNV))
                {
                    return "Mã nhân viên không được để trống.";
                }

                // Kiểm tra email đã tồn tại cho nhân viên khác
                if (dalNhanVien.checkEmailExistsForUpdate(nv.Email, nv.MaNV))
                {
                    return "Email đã được sử dụng bởi nhân viên khác.";
                }

                dalNhanVien.updateNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi cập nhật nhân viên: " + ex.Message;
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không được để trống.";
                }

                // Kiểm tra nhân viên có tồn tại
                NhanVien nv = dalNhanVien.selectById(maNV);
                if (nv == null)
                {
                    return "Không tìm thấy nhân viên.";
                }

                dalNhanVien.deleteNhanVien(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa nhân viên: " + ex.Message;
            }
        }

        public string HardDeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không được để trống.";
                }

                dalNhanVien.hardDeleteNhanVien(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi xóa vĩnh viễn nhân viên: " + ex.Message;
            }
        }

        public List<NhanVien> SearchNhanVien(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return GetActiveNhanVienList();
            }
            return dalNhanVien.searchNhanVien(keyword.Trim());
        }

        public List<NhanVien> GetNhanVienByRole(bool isAdmin)
        {
            return dalNhanVien.getNhanVienByRole(isAdmin);
        }

        public List<NhanVien> GetAdminList()
        {
            return GetNhanVienByRole(true);
        }

        public List<NhanVien> GetStaffList()
        {
            return GetNhanVienByRole(false);
        }

        public bool CheckEmailExists(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            return dalNhanVien.checkEmailExists(email);
        }

        public string ChangePassword(string maNV, string oldPassword, string newPassword)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
                {
                    return "Thông tin không được để trống.";
                }

                if (newPassword.Length < 6)
                {
                    return "Mật khẩu mới phải có ít nhất 6 ký tự.";
                }

                // Lấy thông tin nhân viên
                NhanVien nv = dalNhanVien.selectById(maNV);
                if (nv == null)
                {
                    return "Không tìm thấy nhân viên.";
                }

                // Kiểm tra mật khẩu cũ
                if (nv.MatKhau != oldPassword)
                {
                    return "Mật khẩu cũ không đúng.";
                }

                // Cập nhật mật khẩu mới
                nv.MatKhau = newPassword;
                dalNhanVien.updateNhanVien(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi khi đổi mật khẩu: " + ex.Message;
            }
        }

        // Phương thức validate dữ liệu
        private string ValidateNhanVien(NhanVien nv, bool isInsert)
        {
            if (nv == null)
            {
                return "Thông tin nhân viên không được để trống.";
            }

            if (string.IsNullOrEmpty(nv.HoTen?.Trim()))
            {
                return "Họ tên không được để trống.";
            }

            if (nv.HoTen.Trim().Length > 100)
            {
                return "Họ tên không được vượt quá 100 ký tự.";
            }

            if (string.IsNullOrEmpty(nv.Email?.Trim()))
            {
                return "Email không được để trống.";
            }

            if (!IsValidEmail(nv.Email))
            {
                return "Email không đúng định dạng.";
            }

            if (nv.Email.Length > 255)
            {
                return "Email không được vượt quá 255 ký tự.";
            }

            if (string.IsNullOrEmpty(nv.MatKhau))
            {
                return "Mật khẩu không được để trống.";
            }

            if (nv.MatKhau.Length < 6)
            {
                return "Mật khẩu phải có ít nhất 6 ký tự.";
            }

            if (nv.MatKhau.Length > 255)
            {
                return "Mật khẩu không được vượt quá 255 ký tự.";
            }

            return string.Empty;
        }

        // Kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
