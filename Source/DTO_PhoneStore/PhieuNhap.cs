using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PhoneStore
{
    public class PhieuNhap
    {
        public string MaPN { get; set; }
        public string? MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }
        public string? GhiChu { get; set; }
    }

}
