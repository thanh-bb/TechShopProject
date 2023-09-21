using Microsoft.EntityFrameworkCore;
using TechShop.API.Entities;

namespace TechShop.API.Data
{
    public class TechShopDbContext : DbContext
    {
        public TechShopDbContext(DbContextOptions<TechShopDbContext> options) : base(options)
        {

        }

        #region
        public DbSet<BangTin> BangTin { get; set; }

        public DbSet<HinhAnh> HinhAnh { get; set; }

        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<LoaiSP> LoaiSP { get; set; }

        public DbSet<NhanVien> NhanVien { get; set; }

        public DbSet<Quyen> Quyen { get; set; }

        public DbSet<SanPham> SanPham { get; set; }

        public DbSet<TinhTrangHang> TinhTrangHang { get; set; }

        public DbSet<GioHang> GioHang { get; set; }

        public DbSet<TrangThaiDH> TrangThaiDH { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }

        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }


        #endregion

    }
}
