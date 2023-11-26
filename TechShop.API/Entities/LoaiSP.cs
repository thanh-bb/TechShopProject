using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class LoaiSP
    {
        [Key]
        public string MaLoai {  get; set; }


        [MaxLength(100)]
        public string TenLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }

        public string? ImageURL { get; set; }

    }
}
