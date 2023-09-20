using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace TechShop.API.Entities
{
    public class SanPham
    {
        [Key]
        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public long GiaSP { get; set; }

        public int SoLuong { get; set; }

        public string MoTa {  get; set; }

        public string? MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public LoaiSP LoaiSP { get; set; }

        public string? MaTinhTrang { get; set; }

        [ForeignKey("MaTinhTrang")]
        public TinhTrangHang TinhTrangHang{ get; set; }

        public virtual ICollection<HinhAnh> HinhAnhs { get; set; }

        public virtual BangTin BangTin { get; set; }
    }
}
