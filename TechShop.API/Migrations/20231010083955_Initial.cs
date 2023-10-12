using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HashPasswd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "TinhTrangHang",
                columns: table => new
                {
                    MaTinhTrang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhTrangHang", x => x.MaTinhTrang);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiBT",
                columns: table => new
                {
                    MaTT_BT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTT_BT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiBT", x => x.MaTT_BT);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiDH",
                columns: table => new
                {
                    MaTT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiDH", x => x.MaTT);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoaiNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashPasswdNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaQuyen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_AspNetRoles_Id",
                        column: x => x.Id,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaSP = table.Column<long>(type: "bigint", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaTinhTrang = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSP_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiSP",
                        principalColumn: "MaLoai");
                    table.ForeignKey(
                        name: "FK_SanPham_TinhTrangHang_MaTinhTrang",
                        column: x => x.MaTinhTrang,
                        principalTable: "TinhTrangHang",
                        principalColumn: "MaTinhTrang");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaTT = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TongTien = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_TrangThaiDH_MaTT",
                        column: x => x.MaTT,
                        principalTable: "TrangThaiDH",
                        principalColumn: "MaTT");
                });

            migrationBuilder.CreateTable(
                name: "BangTin",
                columns: table => new
                {
                    MaBangTin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaTT_BT = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangTin", x => x.MaBangTin);
                    table.ForeignKey(
                        name: "FK_BangTin_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BangTin_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                    table.ForeignKey(
                        name: "FK_BangTin_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                    table.ForeignKey(
                        name: "FK_BangTin_TrangThaiBT_MaTT_BT",
                        column: x => x.MaTT_BT,
                        principalTable: "TrangThaiBT",
                        principalColumn: "MaTT_BT");
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => new { x.MaKH, x.MaSP });
                    table.ForeignKey(
                        name: "FK_GioHang_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    MaHinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh", x => x.MaHinh);
                    table.ForeignKey(
                        name: "FK_HinhAnh_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiaBan = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDon", x => new { x.MaHD, x.MaSP });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("b218114d-7595-41d1-8c00-9a822196da55"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7c238433-6e09-4538-8893-f91c39c37e16"), 0, "7624a488-5ff2-4d13-8de1-1901130149e5", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 10, 15, 39, 55, 442, DateTimeKind.Local).AddTicks(1725), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "795a3235-5f34-4450-b27d-93d64551e207", "Trần Văn Man", false, "admin" });

            migrationBuilder.InsertData(
                table: "LoaiSP",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { "01", "Laptop" },
                    { "02", "Điện thoại" },
                    { "03", "Bàn phím" },
                    { "04", "Chuột" },
                    { "05", "Tai nghe" }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "MaSP", "GiaSP", "MaLoai", "MaTinhTrang", "MoTa", "SoLuong", "TenSP" },
                values: new object[,]
                {
                    { "SP01", 10000000L, "01", null, "Hong co gi de mo ta", 1, "Laptop Dell" },
                    { "SP02", 10000000L, "02", null, "Hong co gi de mo ta", 1, "Samsung A51" },
                    { "SP03", 10000000L, "03", null, "Hong co gi de mo ta", 1, "Bàn phím fuhlen" },
                    { "SP04", 10000000L, "04", null, "Hong co gi de mo ta", 1, "Chuột Logitech" },
                    { "SP05", 10000000L, "05", null, "Hong co gi de mo ta", 1, "Tai nghe Sony" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BangTin_Id",
                table: "BangTin",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BangTin_MaNV",
                table: "BangTin",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_BangTin_MaSP",
                table: "BangTin",
                column: "MaSP",
                unique: true,
                filter: "[MaSP] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BangTin_MaTT_BT",
                table: "BangTin",
                column: "MaTT_BT");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaSP",
                table: "ChiTietHoaDon",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_Id",
                table: "GioHang",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_MaSP",
                table: "GioHang",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_HinhAnh_MaSP",
                table: "HinhAnh",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_Id",
                table: "HoaDon",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaTT",
                table: "HoaDon",
                column: "MaTT");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_Id",
                table: "NhanVien",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoai",
                table: "SanPham",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaTinhTrang",
                table: "SanPham",
                column: "MaTinhTrang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BangTin");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "TrangThaiBT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TrangThaiDH");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "TinhTrangHang");
        }
    }
}
