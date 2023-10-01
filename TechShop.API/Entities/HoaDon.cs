using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }

        public Guid? MaKH { get; set; }

        [ForeignKey("Id")]
        public KhachHang KhachHang { get; set; }

        public DateTime NgayDat { get; set; }

        public string? MaTT { get; set; }

        [ForeignKey("MaTT")]
        public TrangThaiDH TrangThaiDH { get; set; }

        public long TongTien { get; set; }

       

    }
}
