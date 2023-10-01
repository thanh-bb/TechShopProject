using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    [PrimaryKey (nameof(MaKH), nameof(MaSP))]
    public class GioHang
    {
        public Guid? MaKH { get; set; }

        [ForeignKey("Id")]
        public KhachHang KhachHang { get; set; }

        public string? MaSP { get; set; }

        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }

        public int SoLuong { get; set; }

        public long GiaBan { get; set; }



    }
}
