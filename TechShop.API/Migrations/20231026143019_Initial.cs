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
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "GioHang",
                columns: table => new
                {
                    ID_Cart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.ID_Cart);
                    table.ForeignKey(
                        name: "FK_GioHang_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "Id");
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
                    MaBangTin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BangTin_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                    table.ForeignKey(
                        name: "FK_BangTin_TrangThaiBT_MaTT_BT",
                        column: x => x.MaTT_BT,
                        principalTable: "TrangThaiBT",
                        principalColumn: "MaTT_BT");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaSP = table.Column<long>(type: "bigint", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoai = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaTinhTrang = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaBangTin = table.Column<int>(type: "int", nullable: true),
                    NgayDang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_SanPham_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_BangTin_MaBangTin",
                        column: x => x.MaBangTin,
                        principalTable: "BangTin",
                        principalColumn: "MaBangTin");
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
                name: "ChiTietGioHang",
                columns: table => new
                {
                    Id_CTCart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Cart = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGioHang", x => x.Id_CTCart);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_GioHang_ID_Cart",
                        column: x => x.ID_Cart,
                        principalTable: "GioHang",
                        principalColumn: "ID_Cart",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietGioHang_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HinhAnh_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("ea26fd30-b8cc-470f-9b9a-a5ff83b50dc7"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7f445d50-c51f-42f6-a3cc-d585dadfbfd7"), 0, "fa971f57-62ac-44ff-be70-2d1751ca897e", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 26, 21, 30, 19, 208, DateTimeKind.Local).AddTicks(3973), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "9d3469bb-94a7-4d9d-b011-d9decaa3fef1", "Trần Văn Man", false, "admin" },
                    { new Guid("ecb94906-9d9b-43f3-bc29-f4d6488bcd3e"), 0, "2e64dd5b-e31b-4840-813a-c4ddd432097f", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 26, 21, 30, 19, 208, DateTimeKind.Local).AddTicks(4004), "ADMIN1@GMAIL.COM", "monmon", "123456", "032132131", false, "c25b992d-01bc-4906-ba42-67ca4db5e01b", "Trần Văn Mon", false, "monmon" }
                });

            migrationBuilder.InsertData(
                table: "LoaiSP",
                columns: new[] { "MaLoai", "ImageURL", "TenLoai" },
                values: new object[,]
                {
                    { "01", "./assets/img/categories/Laptop.png", "Laptop" },
                    { "02", "./assets/img/categories/Phone.png", "Điện thoại" },
                    { "03", "./assets/img/categories/Keyboard.png", "Bàn phím" },
                    { "04", "./assets/img/categories/Chuot.png", "Chuột" },
                    { "05", "./assets/img/categories/HeadPhone.png", "Tai nghe" }
                });

            migrationBuilder.InsertData(
                table: "TinhTrangHang",
                columns: new[] { "MaTinhTrang", "TenTinhTrang" },
                values: new object[,]
                {
                    { "TT01", "New 100%" },
                    { "TT02", "LikeNew 99%" }
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
                name: "IX_BangTin_MaTT_BT",
                table: "BangTin",
                column: "MaTT_BT");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_ID_Cart",
                table: "ChiTietGioHang",
                column: "ID_Cart");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGioHang_MaSP",
                table: "ChiTietGioHang",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaSP",
                table: "ChiTietHoaDon",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_Id",
                table: "GioHang",
                column: "Id");

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
                name: "IX_SanPham_Id",
                table: "SanPham",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaBangTin",
                table: "SanPham",
                column: "MaBangTin",
                unique: true,
                filter: "[MaBangTin] IS NOT NULL");

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
                name: "ChiTietGioHang");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "TrangThaiDH");

            migrationBuilder.DropTable(
                name: "BangTin");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "TinhTrangHang");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "TrangThaiBT");

            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
