using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using DTO_PhoneStore;

namespace DAL_PhoneStore
{
    public class DalLoaiSanPham
    {
        public List<LoaiSanPham> GetLoaiSanPhamList()
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            string sql = "SELECT MaLoai, TenLoai, GhiChu FROM LoaiSanPham";
            try
            {
                using (SqlDataReader reader = DBUtil.Query(sql, new List<object>(), CommandType.Text))
                {
                    while (reader.Read())
                    {
                        list.Add(new LoaiSanPham
                        {
                            MaLoai = reader["MaLoai"].ToString(),
                            TenLoai = reader["TenLoai"].ToString(),
                            GhiChu = reader["GhiChu"] as string
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại sản phẩm: " + ex.Message);
            }
            return list;
        }

        public LoaiSanPham GetLoaiSanPhamByMaLoai(string maLoai)
        {
            string sql = "SELECT MaLoai, TenLoai, GhiChu FROM LoaiSanPham WHERE MaLoai = @0";
            try
            {
                return DBUtil.Value<LoaiSanPham>(sql, new List<object> { maLoai });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin loại sản phẩm: " + ex.Message);
            }
        }

        public bool AddLoaiSanPham(LoaiSanPham lsp)
        {
            string sql = "INSERT INTO LoaiSanPham (MaLoai, TenLoai, GhiChu) VALUES (@0, @1, @2)";
            List<object> args = new List<object>
            {
                lsp.MaLoai,
                lsp.TenLoai,
                lsp.GhiChu ?? (object)DBNull.Value
            };
            try
            {
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm loại sản phẩm: " + ex.Message);
            }
        }

        public bool UpdateLoaiSanPham(LoaiSanPham lsp)
        {
            string sql = "UPDATE LoaiSanPham SET TenLoai = @1, GhiChu = @2 WHERE MaLoai = @0";
            List<object> args = new List<object>
            {
                lsp.MaLoai,
                lsp.TenLoai,
                lsp.GhiChu ?? (object)DBNull.Value
            };
            try
            {
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật loại sản phẩm: " + ex.Message);
            }
        }

        public bool DeleteLoaiSanPham(string maLoai)
        {
            string sql = "DELETE FROM LoaiSanPham WHERE MaLoai = @0";
            try
            {
                DBUtil.Update(sql, new List<object> { maLoai });
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa loại sản phẩm: " + ex.Message);
            }
        }

        public string GenerateMaLoai()
        {
            string prefix = "LSP";
            string sql = "SELECT MAX(MaLoai) FROM LoaiSanPham WHERE MaLoai LIKE 'LSP%'";
            List<object> args = new List<object>();
            try
            {
                object result = DBUtil.ScalarQuery(sql, args);
                if (result != null && result != DBNull.Value && result.ToString().StartsWith(prefix))
                {
                    string maxCode = result.ToString().Substring(prefix.Length); // Lấy phần số sau "LSP"
                    if (int.TryParse(maxCode, out int number))
                    {
                        int newNumber = number + 1;
                        return $"{prefix}{newNumber:D2}"; // Định dạng 3 chữ số
                    }
                }
                return $"{prefix}01"; // Giá trị mặc định
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo mã loại sản phẩm: " + ex.Message);
            }
        }
    }
}