using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PhoneStore
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string? MaKH { get; set; }
        public string? MaNV { get; set; }
        public DateTime NgayTao { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    }

}
