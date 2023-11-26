using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    [PrimaryKey (nameof(MaDH), nameof(MaSP))]
    public class ChiTietDonHang
    {
        public int? MaDH { get; set; }

        [ForeignKey("MaDH")]
        public DonHang DonHang { get; set; }

        public int? MaSP { get; set; }

        [ForeignKey("MaSP")]
        public SanPham SanPham { get; set; }

        public long GiaBan {  get; set; }

    }
}
