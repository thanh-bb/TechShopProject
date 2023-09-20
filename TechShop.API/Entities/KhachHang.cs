using System.ComponentModel.DataAnnotations;

namespace TechShop.API.Entities
{
    public class KhachHang
    {

        [Key]
        public string MaKH {  get; set; }

        public string TenKH { get; set; }

        public DateTime NgaySinh { get; set; }  

        public Boolean GioiTinh { get; set; }

        public string Email { get; set; }

        public string DienThoai { get; set; }

        public string HashPassed { get; set; }

        public virtual ICollection<BangTin> BangTins { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}
