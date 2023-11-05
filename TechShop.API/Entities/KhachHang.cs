using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{

    [Table("KhachHang")]
    public class KhachHang : IdentityUser<Guid>
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenKH { get; set; }



        [Required]
        public DateTime NgaySinh { get; set; }

        public Boolean GioiTinh { get; set; }

        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string DienThoai { get; set; }

        //[Required]
        //[MaxLength(100)]
        //public string HashPasswd { get; set; }

        public virtual ICollection<BangTin> BangTins { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

        /* public Guid? MaQuyen { get; set; }

          [ForeignKey("Id")]
          public Quyen Quyen { get; set; }*/

        public virtual ICollection<SanPham> SanPhams { get; set; }

    }
}
