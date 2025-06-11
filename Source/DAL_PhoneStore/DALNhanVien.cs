using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PhoneStore;
using Microsoft.Data.SqlClient;

namespace DAL_PhoneStore
{
    public class DALNhanVien
    {
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email=@0 AND MatKhau=@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            NhanVien nv = DBUtil.Value<NhanVien>(sql, thamSo);
            return nv;
        }

        public NhanVien? getNhanVien1(string email, string password)
        {
            string sql = "SELECT Top 1 * FROM NhanVien WHERE Email=@0 AND MatKhau=@1 AND TrangThai=1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            SqlDataReader reader = DBUtil.Query(sql, thamSo);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = reader["MaNV"].ToString();
                    nv.HoTen = reader["HoTen"].ToString();
                    nv.Email = reader["Email"].ToString();
                    nv.MatKhau = reader["MatKhau"].ToString();
                    nv.VaiTro = bool.Parse(reader["VaiTro"].ToString());
                    nv.TrangThai = bool.Parse(reader["TrangThai"].ToString());

                    return nv;
                }
            }
            return null;
        }

        public void ResetMatKhau(string mk, string email)
        {
            try
            {
                string sql = "UPDATE NhanVien SET MatKhau = @0 WHERE Email = @1";
                List<object> thamSo = new List<object>();
                thamSo.Add(mk);
                thamSo.Add(email);
                DBUtil.Update(sql, thamSo);

            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<NhanVien> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    NhanVien entity = new NhanVien();
                    entity.MaNV = reader.GetString("MaNV");
                    entity.HoTen = reader.GetString("HoTen");
                    entity.Email = reader.GetString("Email");
                    entity.MatKhau = reader.GetString("MatKhau");
                    entity.VaiTro = reader.GetBoolean("VaiTro");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<NhanVien> selectAll()
        {
            String sql = "SELECT * FROM NhanVien";
            return SelectBySql(sql, new List<object>());
        }

        public List<NhanVien> selectActive()
        {
            String sql = "SELECT * FROM NhanVien WHERE TrangThai = 1";
            return SelectBySql(sql, new List<object>());
        }

        public NhanVien selectById(string id)
        {
            String sql = "SELECT * FROM NhanVien WHERE MaNV=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<NhanVien> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertNhanVien(NhanVien nv)
        {
            try
            {
                string sql = @"INSERT INTO NhanVien (MaNV, HoTen, Email, MatKhau, VaiTro, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamSo = new List<object>();
                thamSo.Add(nv.MaNV);
                thamSo.Add(nv.HoTen);
                thamSo.Add(nv.Email);
                thamSo.Add(nv.MatKhau);
                thamSo.Add(nv.VaiTro);
                thamSo.Add(nv.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateNhanVien(NhanVien nv)
        {
            try
            {
                string sql = @"UPDATE NhanVien 
                   SET HoTen = @1, Email = @2, MatKhau = @3, VaiTro = @4, TrangThai = @5 
                   WHERE MaNV = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(nv.MaNV);
                thamSo.Add(nv.HoTen);
                thamSo.Add(nv.Email);
                thamSo.Add(nv.MatKhau);
                thamSo.Add(nv.VaiTro);
                thamSo.Add(nv.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void deleteNhanVien(string maNv)
        {
            try
            {
                // Soft delete - chỉ cập nhật trạng thái
                string sql = "UPDATE NhanVien SET TrangThai = 0 WHERE MaNV = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maNv);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void hardDeleteNhanVien(string maNv)
        {
            try
            {
                // Hard delete - xóa vĩnh viễn
                string sql = "DELETE FROM NhanVien WHERE MaNV = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maNv);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool checkEmailExists(string email)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            object result = DBUtil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }

        public bool checkEmailExistsForUpdate(string email, string maNV)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0 AND MaNV != @1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(maNV);
            object result = DBUtil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }

        public string generateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MAX(MaNV) FROM NhanVien WHERE MaNV LIKE 'NV%'";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);

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

        public List<NhanVien> searchNhanVien(string keyword)
        {
            string sql = @"SELECT * FROM NhanVien 
                          WHERE (HoTen LIKE @0 OR Email LIKE @0 OR MaNV LIKE @0)
                          AND TrangThai = 1";
            List<object> thamSo = new List<object>();
            thamSo.Add("%" + keyword + "%");
            return SelectBySql(sql, thamSo);
        }

        public List<NhanVien> getNhanVienByRole(bool vaiTro)
        {
            string sql = "SELECT * FROM NhanVien WHERE VaiTro = @0 AND TrangThai = 1";
            List<object> thamSo = new List<object>();
            thamSo.Add(vaiTro);
            return SelectBySql(sql, thamSo);
        }
    }
}
