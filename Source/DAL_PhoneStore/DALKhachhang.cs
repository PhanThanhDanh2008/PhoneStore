using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using DTO_PhoneStore;

namespace DAL_PhoneStore
{
    public class DALKhachhang
    {
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();
            string sql = "SELECT * FROM KhachHang";
            try
            {
                using (SqlDataReader reader = DBUtil.Query(sql, new List<object>(), CommandType.Text))
                {
                    while (reader.Read())
                    {
                        KhachHang kh = new KhachHang
                        {
                            MaKH = reader["MaKH"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader["Email"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            DiaChi = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? null : reader["DiaChi"].ToString(),
                            DiemTichLuy = Convert.ToInt32(reader["DiemTichLuy"]),
                            TrangThai = Convert.ToBoolean(reader["TrangThai"])
                        };
                        listKhachHang.Add(kh);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: " + ex.Message);
            }
            return listKhachHang;
        }

        public KhachHang GetKhachHangByMaKH(string maKH)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaKH = @0";
            try
            {
                return DBUtil.Value<KhachHang>(sql, new List<object> { maKH });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin khách hàng: " + ex.Message);
            }
        }

        public bool AddKhachHang(KhachHang kh)
        {
            string sql = "INSERT INTO KhachHang (MaKH, HoTen, Email, SoDienThoai, DiaChi, DiemTichLuy, TrangThai) " +
                         "VALUES (@0, @1, @2, @3, @4, @5, @6)";
            List<object> args = new List<object>
            {
                kh.MaKH,
                kh.HoTen,
                kh.Email ?? (object)DBNull.Value,
                kh.SoDienThoai,
                kh.DiaChi ?? (object)DBNull.Value,
                kh.DiemTichLuy,
                kh.TrangThai
            };
            try
            {
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        public bool UpdateKhachHang(KhachHang kh)
        {
            string sql = "UPDATE KhachHang SET HoTen = @1, Email = @2, SoDienThoai = @3, DiaChi = @4, DiemTichLuy = @5, TrangThai = @6 WHERE MaKH = @0";
            List<object> args = new List<object>
            {
                kh.MaKH,
                kh.HoTen,
                kh.Email ?? (object)DBNull.Value,
                kh.SoDienThoai,
                kh.DiaChi ?? (object)DBNull.Value,
                kh.DiemTichLuy,
                kh.TrangThai
            };
            try
            {
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khách hàng: " + ex.Message);
            }
        }

        public bool DeleteKhachHang(string maKH)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH = @0";
            try
            {
                DBUtil.Update(sql, new List<object> { maKH });
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        public string GenerateMaKhachHang()
        {
            string prefix = "KH";
            string sql = "SELECT MAX(MaKH) FROM KhachHang WHERE MaKH LIKE 'KH%'";
            List<object> args = new List<object>();
            try
            {
                object result = DBUtil.ScalarQuery(sql, args);
                if (result != null && result != DBNull.Value && result.ToString().StartsWith(prefix))
                {
                    string maxCode = result.ToString().Substring(2);
                    if (int.TryParse(maxCode, out int number))
                    {
                        int newNumber = number + 1;
                        return $"{prefix}{newNumber:D3}";
                    }
                }
                return $"{prefix}001";
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo mã khách hàng: " + ex.Message);
            }
        }
    }
}