﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechShop.API.Data;

#nullable disable

namespace TechShop.API.Migrations
{
    [DbContext(typeof(TechShopDbContext))]
    [Migration("20231019142525_imageurl")]
    partial class imageurl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TechShop.API.Entities.BangTin", b =>
                {
                    b.Property<int>("MaBangTin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBangTin"));

                    b.Property<Guid?>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaTT_BT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBangTin");

                    b.HasIndex("Id");

                    b.HasIndex("MaNV");

                    b.HasIndex("MaTT_BT");

                    b.ToTable("BangTin");
                });

            modelBuilder.Entity("TechShop.API.Entities.ChiTietHoaDon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MaSP")
                        .HasColumnType("int");

                    b.Property<long>("GiaBan")
                        .HasColumnType("bigint");

                    b.HasKey("MaHD", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("ChiTietHoaDon");
                });

            modelBuilder.Entity("TechShop.API.Entities.GioHang", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("MaSP")
                        .HasColumnType("int");

                    b.Property<long>("GiaBan")
                        .HasColumnType("bigint");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id", "MaSP");

                    b.HasIndex("MaSP");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("TechShop.API.Entities.HinhAnh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FileSize")
                        .HasColumnType("int");

                    b.Property<string>("Id_SanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaSP");

                    b.ToTable("HinhAnh");
                });

            modelBuilder.Entity("TechShop.API.Entities.HoaDon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayDat")
                        .HasColumnType("datetime2");

                    b.Property<long>("TongTien")
                        .HasColumnType("bigint");

                    b.HasKey("MaHD");

                    b.HasIndex("Id");

                    b.HasIndex("MaTT");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("TechShop.API.Entities.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HashPasswd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d053caac-f076-4fdf-9c9d-fef2fa0f0c90"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1894f3f9-23aa-41c1-aecd-bdd47e624da0",
                            DienThoai = "0985879105",
                            Email = "abc@gmail.com",
                            EmailConfirmed = false,
                            GioiTinh = false,
                            HashPasswd = "123456",
                            LockoutEnabled = false,
                            NgaySinh = new DateTime(2023, 10, 19, 21, 25, 24, 975, DateTimeKind.Local).AddTicks(62),
                            NormalizedEmail = "ADMIN1@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "123456",
                            PhoneNumber = "032132131",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f266c424-e98a-4c18-ae3a-8e5dae773700",
                            TenKH = "Trần Văn Man",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("TechShop.API.Entities.LoaiSP", b =>
                {
                    b.Property<string>("MaLoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiSP");

                    b.HasData(
                        new
                        {
                            MaLoai = "01",
                            ImageURL = "~/assets/img/categories/Laptop.png",
                            TenLoai = "Laptop"
                        },
                        new
                        {
                            MaLoai = "02",
                            TenLoai = "Điện thoại"
                        },
                        new
                        {
                            MaLoai = "03",
                            ImageURL = "~/assets/img/categories/Laptop.png",
                            TenLoai = "Bàn phím"
                        },
                        new
                        {
                            MaLoai = "04",
                            TenLoai = "Chuột"
                        },
                        new
                        {
                            MaLoai = "05",
                            TenLoai = "Tai nghe"
                        });
                });

            modelBuilder.Entity("TechShop.API.Entities.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChiNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoaiNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPasswdNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MaQuyen")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNV");

                    b.HasIndex("Id");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("TechShop.API.Entities.Quyen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("dab580ad-99f1-42a5-b5ff-40e4bba17c55"),
                            TenQuyen = "admin"
                        });
                });

            modelBuilder.Entity("TechShop.API.Entities.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSP"));

                    b.Property<long>("GiaSP")
                        .HasColumnType("bigint");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaBangTin")
                        .HasColumnType("int");

                    b.Property<string>("MaLoai")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaTinhTrang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NgDang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayDang")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.HasIndex("MaBangTin")
                        .IsUnique()
                        .HasFilter("[MaBangTin] IS NOT NULL");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaTinhTrang");

                    b.ToTable("SanPham");

                    b.HasData(
                        new
                        {
                            MaSP = 1,
                            GiaSP = 10000000L,
                            MaLoai = "01",
                            MoTa = "Hong co gi de mo ta",
                            NgDang = new Guid("00000000-0000-0000-0000-000000000000"),
                            NgayDang = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoLuong = 1,
                            TenSP = "Laptop Dell"
                        },
                        new
                        {
                            MaSP = 2,
                            GiaSP = 10000000L,
                            MaLoai = "02",
                            MoTa = "Hong co gi de mo ta",
                            NgDang = new Guid("00000000-0000-0000-0000-000000000000"),
                            NgayDang = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoLuong = 1,
                            TenSP = "Samsung A51"
                        },
                        new
                        {
                            MaSP = 3,
                            GiaSP = 10000000L,
                            MaLoai = "03",
                            MoTa = "Hong co gi de mo ta",
                            NgDang = new Guid("00000000-0000-0000-0000-000000000000"),
                            NgayDang = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoLuong = 1,
                            TenSP = "Bàn phím fuhlen"
                        },
                        new
                        {
                            MaSP = 4,
                            GiaSP = 10000000L,
                            MaLoai = "04",
                            MoTa = "Hong co gi de mo ta",
                            NgDang = new Guid("00000000-0000-0000-0000-000000000000"),
                            NgayDang = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoLuong = 1,
                            TenSP = "Chuột Logitech"
                        },
                        new
                        {
                            MaSP = 5,
                            GiaSP = 10000000L,
                            MaLoai = "05",
                            MoTa = "Hong co gi de mo ta",
                            NgDang = new Guid("00000000-0000-0000-0000-000000000000"),
                            NgayDang = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoLuong = 1,
                            TenSP = "Tai nghe Sony"
                        });
                });

            modelBuilder.Entity("TechShop.API.Entities.TinhTrangHang", b =>
                {
                    b.Property<string>("MaTinhTrang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTinhTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTinhTrang");

                    b.ToTable("TinhTrangHang");

                    b.HasData(
                        new
                        {
                            MaTinhTrang = "TT01",
                            TenTinhTrang = "New 100%"
                        },
                        new
                        {
                            MaTinhTrang = "TT02",
                            TenTinhTrang = "LikeNew 99%"
                        });
                });

            modelBuilder.Entity("TechShop.API.Entities.TrangThaiBT", b =>
                {
                    b.Property<string>("MaTT_BT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTT_BT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTT_BT");

                    b.ToTable("TrangThaiBT");
                });

            modelBuilder.Entity("TechShop.API.Entities.TrangThaiDH", b =>
                {
                    b.Property<string>("MaTT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTT");

                    b.ToTable("TrangThaiDH");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("TechShop.API.Entities.Quyen", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("TechShop.API.Entities.KhachHang", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("TechShop.API.Entities.KhachHang", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("TechShop.API.Entities.Quyen", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechShop.API.Entities.KhachHang", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("TechShop.API.Entities.KhachHang", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechShop.API.Entities.BangTin", b =>
                {
                    b.HasOne("TechShop.API.Entities.KhachHang", "KhachHang")
                        .WithMany("BangTins")
                        .HasForeignKey("Id");

                    b.HasOne("TechShop.API.Entities.NhanVien", "NhanVien")
                        .WithMany("BangTins")
                        .HasForeignKey("MaNV");

                    b.HasOne("TechShop.API.Entities.TrangThaiBT", "TrangThaiBT")
                        .WithMany("BangTins")
                        .HasForeignKey("MaTT_BT");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("TrangThaiBT");
                });

            modelBuilder.Entity("TechShop.API.Entities.ChiTietHoaDon", b =>
                {
                    b.HasOne("TechShop.API.Entities.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechShop.API.Entities.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("TechShop.API.Entities.GioHang", b =>
                {
                    b.HasOne("TechShop.API.Entities.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechShop.API.Entities.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("TechShop.API.Entities.HinhAnh", b =>
                {
                    b.HasOne("TechShop.API.Entities.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("TechShop.API.Entities.HoaDon", b =>
                {
                    b.HasOne("TechShop.API.Entities.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("Id");

                    b.HasOne("TechShop.API.Entities.TrangThaiDH", "TrangThaiDH")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaTT");

                    b.Navigation("KhachHang");

                    b.Navigation("TrangThaiDH");
                });

            modelBuilder.Entity("TechShop.API.Entities.NhanVien", b =>
                {
                    b.HasOne("TechShop.API.Entities.Quyen", "Quyen")
                        .WithMany("NhanViens")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quyen");
                });

            modelBuilder.Entity("TechShop.API.Entities.SanPham", b =>
                {
                    b.HasOne("TechShop.API.Entities.BangTin", "BangTin")
                        .WithOne("SanPham")
                        .HasForeignKey("TechShop.API.Entities.SanPham", "MaBangTin");

                    b.HasOne("TechShop.API.Entities.LoaiSP", "LoaiSP")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaLoai");

                    b.HasOne("TechShop.API.Entities.TinhTrangHang", "TinhTrangHang")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaTinhTrang");

                    b.Navigation("BangTin");

                    b.Navigation("LoaiSP");

                    b.Navigation("TinhTrangHang");
                });

            modelBuilder.Entity("TechShop.API.Entities.BangTin", b =>
                {
                    b.Navigation("SanPham")
                        .IsRequired();
                });

            modelBuilder.Entity("TechShop.API.Entities.KhachHang", b =>
                {
                    b.Navigation("BangTins");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("TechShop.API.Entities.LoaiSP", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("TechShop.API.Entities.NhanVien", b =>
                {
                    b.Navigation("BangTins");
                });

            modelBuilder.Entity("TechShop.API.Entities.Quyen", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("TechShop.API.Entities.TinhTrangHang", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("TechShop.API.Entities.TrangThaiBT", b =>
                {
                    b.Navigation("BangTins");
                });

            modelBuilder.Entity("TechShop.API.Entities.TrangThaiDH", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
