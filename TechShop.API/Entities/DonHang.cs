using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class DonHang
    {
        [Key]
        public int MaDH { get; set; }

        public Guid? Id { get; set; }

        [ForeignKey("Id")]
        public KhachHang KhachHang { get; set; }

        public DateTime NgayDat { get; set; }

        public int? MaTT { get; set; }

        [ForeignKey("MaTT")]
        public TrangThaiDH TrangThaiDH { get; set; }

        public long TongTien { get; set; }
       

    }
}
