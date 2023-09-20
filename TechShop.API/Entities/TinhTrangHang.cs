using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class TinhTrangHang
    {
        [Key]
        public string MaTinhTrang { get; set; }

        public string TenTinhTrang { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }

    }
}
