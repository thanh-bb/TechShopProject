using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
   // [PrimaryKey (nameof(Id), nameof(MaSP))]
    public class GioHang
    {
        [Key]
        public int ID_Cart { get; set; }

        public Guid? Id { get; set; }

        [ForeignKey("Id")]
        public KhachHang KhachHang { get; set; }

        //public int? MaSP { get; set; }

        //[ForeignKey("MaSP")]
        //public SanPham SanPham { get; set; }

        //public int SoLuong { get; set; }

        //public long GiaBan { get; set; }



    }
}
