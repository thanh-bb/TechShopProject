using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using TechShop.Models.Enums;

namespace TechShop.API.Entities
{
    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        public string TenSP { get; set; }

        public long GiaSP { get; set; }

        public int SoLuong { get; set; }

        public string? MoTa {  get; set; }

        public string? MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public LoaiSP LoaiSP { get; set; } 

        //public int? MaBangTin { get; set; }

        //[ForeignKey("MaBangTin")]
        //public BangTin BangTin { get; set; }

        public DateTime NgayDang { get; set; }

        //public List<HinhAnh> HinhAnhs { get; set; }

        public string? ImageURL {  get; set; }

        public Guid Id { get; set; }

        [ForeignKey("Id")]
        public KhachHang KhachHang { get; set; }

        public Status Status { get; set; }

        public int? MaTT_Duyet { get; set; }

        [ForeignKey("MaTT_Duyet")]
        public TrangThaiDuyet TrangThaiDuyet { get; set; }
    }
}
