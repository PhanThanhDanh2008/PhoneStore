using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PhoneStore
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string? Email { get; set; }
        public string SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public int DiemTichLuy { get; set; }
        public bool TrangThai { get; set; }
    }

}
