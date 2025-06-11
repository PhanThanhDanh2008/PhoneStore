using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PhoneStore
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool VaiTro { get; set; } // true = Admin, false = Nhân viên
        public bool TrangThai { get; set; }
    }
}
