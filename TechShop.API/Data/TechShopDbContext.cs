using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TechShop.API.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security;

namespace TechShop.API.Data
{
    public class TechShopDbContext : IdentityDbContext<KhachHang, Quyen, Guid>
    {
        private readonly IPasswordHasher<KhachHang> _passwordHasher = new PasswordHasher<KhachHang>();

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

        public DbSet<TrangThaiBT> TrangThaiBT { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
            {
                MaLoai = "01",
                TenLoai = "Laptop"

            });
			modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
			{
				MaLoai = "02",
				TenLoai = "Điện thoại"

			});
			modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
			{
				MaLoai = "03",
				TenLoai = "Bàn phím"

			});
			modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
			{
				MaLoai = "04",
				TenLoai = "Chuột"

			});

			modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
			{
				MaLoai = "05",
				TenLoai = "Tai nghe"

			});
		
			modelBuilder.Entity<SanPham>().HasData(new SanPham
			{
				MaSP= 1,
                TenSP="Laptop Dell",
                GiaSP= 10000000,
                SoLuong=1,
                MaLoai="01",
                MoTa= "Hong co gi de mo ta",
				

			});
			modelBuilder.Entity<SanPham>().HasData(new SanPham
			{
				MaSP = 2,
				TenSP = "Samsung A51",
				GiaSP = 10000000,
				SoLuong = 1,
				MaLoai = "02",
				MoTa = "Hong co gi de mo ta",
				

			});
			modelBuilder.Entity<SanPham>().HasData(new SanPham
			{
				MaSP = 3,
				TenSP = "Bàn phím fuhlen",
				GiaSP = 10000000,
				SoLuong = 1,
				MaLoai = "03",
				MoTa = "Hong co gi de mo ta",
				

			});
			modelBuilder.Entity<SanPham>().HasData(new SanPham
			{
				MaSP = 4,
				TenSP = "Chuột Logitech",
				GiaSP = 10000000,
				SoLuong = 1,
				MaLoai = "04",
				MoTa = "Hong co gi de mo ta",
				

			});
			modelBuilder.Entity<SanPham>().HasData(new SanPham
			{
				MaSP = 5,
				TenSP = "Tai nghe Sony",
				GiaSP = 10000000,
				SoLuong = 1,
				MaLoai = "05",
				MoTa = "Hong co gi de mo ta",
				

			});
			modelBuilder.Entity<KhachHang>().HasData(new KhachHang
			{
				Id = Guid.NewGuid(),
				TenKH = "Trần Văn Man",
				NgaySinh = DateTime.Now,
				GioiTinh = false,
				Email = "abc@gmail.com",
				NormalizedEmail = "ADMIN1@GMAIL.COM",
				DienThoai = "0985879105",
				PhoneNumber = "032132131",
				HashPasswd = "123456",
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				SecurityStamp = Guid.NewGuid().ToString(),
				PasswordHash = "123456"
			});

			modelBuilder.Entity<Quyen>().HasData(new Quyen
			{
				Id = Guid.NewGuid(),
				TenQuyen = "admin"

			});
			modelBuilder.Entity<TinhTrangHang>().HasData(new TinhTrangHang
			{
				MaTinhTrang= "TT01",
				TenTinhTrang = "New 100%"

			});
			modelBuilder.Entity<TinhTrangHang>().HasData(new TinhTrangHang
			{
				MaTinhTrang = "TT02",
				TenTinhTrang = "LikeNew 99%"

			});
		}



	}
}