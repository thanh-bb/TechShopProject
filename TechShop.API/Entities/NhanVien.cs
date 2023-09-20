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

        public int? MaQuyen { get; set; }

        [ForeignKey("MaQuyen")] 
        public Quyen Quyen { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
