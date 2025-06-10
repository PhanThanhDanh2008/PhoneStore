using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PhoneStore
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaHang { get; set; }
        public string MaLoai { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string? MoTa { get; set; }
        public string? ThongSoKyThuat { get; set; }
        public string? HinhAnh { get; set; }
        public bool TrangThai { get; set; }
    }

}
