using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class BangTin
    {

        [Key]
        public string MaBangTin {  get; set; }

        public string NoiDung { get; set; }

        public DateTime NgayDang { get; set; }

        public string? MaKH { get; set; }

        [ForeignKey("MaKH")]
        public KhachHang KhachHang { get; set; }

        public string? MaSP { get; set; }

        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }
    }
}
