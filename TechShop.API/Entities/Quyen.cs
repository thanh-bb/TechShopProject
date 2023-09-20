using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class Quyen
    {
        [Key]
        public int MaQuyen { get; set; }

        public string TenQuyen { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }

    }
}
