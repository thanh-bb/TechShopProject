using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class HinhAnh
    {
        [Key]
        public string MaHinh { get; set; }

        public string URL { get; set; }

        public string TenAnh { get; set; }

        public int? MaSP { get; set; }

        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }
    }
}
