using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    [PrimaryKey (nameof(MaHD), nameof(MaSP))]
    public class ChiTietHoaDon
    {
        public string? MaHD { get; set; }

        [ForeignKey("MaHD")]
        public HoaDon HoaDon { get; set; }

        public int? MaSP { get; set; }

        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }

        public long GiaBan {  get; set; }



    }
}
