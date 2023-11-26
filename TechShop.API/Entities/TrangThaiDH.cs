using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class TrangThaiDH
    {
        [Key]
        public int MaTT { get; set; }

        [MaxLength(100)]
        public string TenTT { get; set; }

        public virtual ICollection<DonHang> HoaDons { get; set; }

    }
}
