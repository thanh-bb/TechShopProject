using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechShop.API.Entities
{
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }

        public string TenNV { get; set; }

        public string EmailNV { get; set; }

        public string DiaChiNV { get; set; }

        public string DienThoaiNV { get; set; }

        public string HashPasswdNV { get; set; }

        public Guid? MaQuyen { get; set; }

        [ForeignKey("Id")] 
        public Quyen Quyen { get; set; }

        public virtual ICollection<BangTin> BangTins { get; set; }

    }
}
