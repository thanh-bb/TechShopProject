using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class TrangThaiDH
    {
        [Key]
        public string MaTT { get; set; }

        public string TenTT { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
