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

        public DbSet<GioHang> GioHang { get; set; }

        public DbSet<TrangThaiDH> TrangThaiDH { get; set; }

        public DbSet<HoaDon> HoaDon { get; set; }

        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }

        public DbSet<TrangThaiBT> TrangThaiBT { get; set; }

        public DbSet<ChiTietGioHang> ChiTietGioHang { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
            {
                MaLoai = "01",
                TenLoai = "Laptop",
                ImageURL = "./assets/img/categories/Laptop.png"

            });
            modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
            {
                MaLoai = "02",
                TenLoai = "Điện thoại",
                ImageURL = "./assets/img/categories/Phone.png"

            });
            modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
            {
                MaLoai = "03",
                TenLoai = "Bàn phím",
                ImageURL = "./assets/img/categories/Keyboard.png"

            });
            modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
            {
                MaLoai = "04",
                TenLoai = "Chuột",
                ImageURL = "./assets/img/categories/Chuot.png"

            });

            modelBuilder.Entity<LoaiSP>().HasData(new LoaiSP
            {
                MaLoai = "05",
                TenLoai = "Tai nghe",
                ImageURL = "./assets/img/categories/HeadPhone.png"

            });

            //modelBuilder.Entity<SanPham>().HasData(new SanPham
            //{
            //	MaSP= 1,
            //             TenSP="Laptop Dell",
            //             GiaSP= 10000000,
            //             SoLuong=1,
            //             MaLoai="01",
            //             MoTa= "Hong co gi de mo ta",



            //         });
            //modelBuilder.Entity<SanPham>().HasData(new SanPham
            //{
            //	MaSP = 2,
            //	TenSP = "Samsung A51",
            //	GiaSP = 10000000,
            //	SoLuong = 1,
            //	MaLoai = "02",
            //	MoTa = "Hong co gi de mo ta",


            //         });
            //modelBuilder.Entity<SanPham>().HasData(new SanPham
            //{
            //	MaSP = 3,
            //	TenSP = "Bàn phím fuhlen",
            //	GiaSP = 10000000,
            //	SoLuong = 1,
            //	MaLoai = "03",
            //	MoTa = "Hong co gi de mo ta",


            //         });
            //modelBuilder.Entity<SanPham>().HasData(new SanPham
            //{
            //	MaSP = 4,
            //	TenSP = "Chuột Logitech",
            //	GiaSP = 10000000,
            //	SoLuong = 1,
            //	MaLoai = "04",
            //	MoTa = "Hong co gi de mo ta",


            //         });
            //modelBuilder.Entity<SanPham>().HasData(new SanPham
            //{
            //	MaSP = 5,
            //	TenSP = "Tai nghe Sony",
            //	GiaSP = 10000000,
            //	SoLuong = 1,
            //	MaLoai = "05",
            //	MoTa = "Hong co gi de mo ta",


            //         });
            modelBuilder.Entity<KhachHang>().HasData(new KhachHang
            {
                Id = Guid.NewGuid(),
                TenKH = "Trần Văn Man",
                NgaySinh = DateTime.Now,
                Gender =0,
                Email = "abc@gmail.com",
                NormalizedEmail = "ADMIN1@GMAIL.COM",
                DienThoai = "0985879105",
                PhoneNumber = "032132131",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = "123456"
            });
            modelBuilder.Entity<KhachHang>().HasData(new KhachHang
            {
                Id = Guid.NewGuid(),
                TenKH = "Trần Văn Mon",
                NgaySinh = DateTime.Now,
                Gender = 0,
                Email = "abc@gmail.com",
                NormalizedEmail = "ADMIN1@GMAIL.COM",
                DienThoai = "0985879105",
                PhoneNumber = "032132131",
                UserName = "monmon",
                NormalizedUserName = "monmon",
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = "123456"
            });
            modelBuilder.Entity<Quyen>().HasData(new Quyen
            {
                Id = Guid.NewGuid(),
                TenQuyen = "admin"

            });

        }



    }
}