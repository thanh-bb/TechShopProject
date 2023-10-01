using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    [Table("Quyen")]
    public class Quyen : IdentityRole<Guid>
    {
        [Key]
        public Guid Id { get; set; }

        public string TenQuyen { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }

       // public virtual ICollection<KhachHang> KhachHang { get; set; }

    }
}
