using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangTins_KhachHangs_MaKH",
                table: "BangTins");

            migrationBuilder.DropForeignKey(
                name: "FK_BangTins_SanPhams_MaSP",
                table: "BangTins");

            migrationBuilder.DropForeignKey(
                name: "FK_HinhAnhs_SanPhams_MaSP",
                table: "HinhAnhs");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_Quyens_MaQuyen",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_LoaiSPs_MaLoai",
                table: "SanPhams");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_TinhTrangHangs_MaTinhTrang",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TinhTrangHangs",
                table: "TinhTrangHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quyens",
                table: "Quyens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSPs",
                table: "LoaiSPs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HinhAnhs",
                table: "HinhAnhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BangTins",
                table: "BangTins");

            migrationBuilder.RenameTable(
                name: "TinhTrangHangs",
                newName: "TinhTrangHang");

            migrationBuilder.RenameTable(
                name: "SanPhams",
                newName: "SanPham");

            migrationBuilder.RenameTable(
                name: "Quyens",
                newName: "Quyen");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "LoaiSPs",
                newName: "LoaiSP");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "HinhAnhs",
                newName: "HinhAnh");

            migrationBuilder.RenameTable(
                name: "BangTins",
                newName: "BangTin");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhams_MaTinhTrang",
                table: "SanPham",
                newName: "IX_SanPham_MaTinhTrang");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhams_MaLoai",
                table: "SanPham",
                newName: "IX_SanPham_MaLoai");

            migrationBuilder.RenameIndex(
                name: "IX_NhanViens_MaQuyen",
                table: "NhanVien",
                newName: "IX_NhanVien_MaQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_HinhAnhs_MaSP",
                table: "HinhAnh",
                newName: "IX_HinhAnh_MaSP");

            migrationBuilder.RenameIndex(
                name: "IX_BangTins_MaSP",
                table: "BangTin",
                newName: "IX_BangTin_MaSP");

            migrationBuilder.RenameIndex(
                name: "IX_BangTins_MaKH",
                table: "BangTin",
                newName: "IX_BangTin_MaKH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TinhTrangHang",
                table: "TinhTrangHang",
                column: "MaTinhTrang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPham",
                table: "SanPham",
                column: "MaSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quyen",
                table: "Quyen",
                column: "MaQuyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "MaNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSP",
                table: "LoaiSP",
                column: "MaLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "MaKH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HinhAnh",
                table: "HinhAnh",
                column: "MaHinh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BangTin",
                table: "BangTin",
                column: "MaBangTin");

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => new { x.MaKH, x.MaSP });
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHang_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_MaSP",
                table: "GioHang",
                column: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_BangTin_KhachHang_MaKH",
                table: "BangTin",
                column: "MaKH",
                principalTable: "KhachHang",
                principalColumn: "MaKH");

            migrationBuilder.AddForeignKey(
                name: "FK_BangTin_SanPham_MaSP",
                table: "BangTin",
                column: "MaSP",
                principalTable: "SanPham",
                principalColumn: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_HinhAnh_SanPham_MaSP",
                table: "HinhAnh",
                column: "MaSP",
                principalTable: "SanPham",
                principalColumn: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_Quyen_MaQuyen",
                table: "NhanVien",
                column: "MaQuyen",
                principalTable: "Quyen",
                principalColumn: "MaQuyen");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSP_MaLoai",
                table: "SanPham",
                column: "MaLoai",
                principalTable: "LoaiSP",
                principalColumn: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_TinhTrangHang_MaTinhTrang",
                table: "SanPham",
                column: "MaTinhTrang",
                principalTable: "TinhTrangHang",
                principalColumn: "MaTinhTrang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BangTin_KhachHang_MaKH",
                table: "BangTin");

            migrationBuilder.DropForeignKey(
                name: "FK_BangTin_SanPham_MaSP",
                table: "BangTin");

            migrationBuilder.DropForeignKey(
                name: "FK_HinhAnh_SanPham_MaSP",
                table: "HinhAnh");

            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_Quyen_MaQuyen",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSP_MaLoai",
                table: "SanPham");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TinhTrangHang_MaTinhTrang",
                table: "SanPham");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TinhTrangHang",
                table: "TinhTrangHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPham",
                table: "SanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quyen",
                table: "Quyen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSP",
                table: "LoaiSP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HinhAnh",
                table: "HinhAnh");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BangTin",
                table: "BangTin");

            migrationBuilder.RenameTable(
                name: "TinhTrangHang",
                newName: "TinhTrangHangs");

            migrationBuilder.RenameTable(
                name: "SanPham",
                newName: "SanPhams");

            migrationBuilder.RenameTable(
                name: "Quyen",
                newName: "Quyens");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "LoaiSP",
                newName: "LoaiSPs");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "HinhAnh",
                newName: "HinhAnhs");

            migrationBuilder.RenameTable(
                name: "BangTin",
                newName: "BangTins");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_MaTinhTrang",
                table: "SanPhams",
                newName: "IX_SanPhams_MaTinhTrang");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_MaLoai",
                table: "SanPhams",
                newName: "IX_SanPhams_MaLoai");

            migrationBuilder.RenameIndex(
                name: "IX_NhanVien_MaQuyen",
                table: "NhanViens",
                newName: "IX_NhanViens_MaQuyen");

            migrationBuilder.RenameIndex(
                name: "IX_HinhAnh_MaSP",
                table: "HinhAnhs",
                newName: "IX_HinhAnhs_MaSP");

            migrationBuilder.RenameIndex(
                name: "IX_BangTin_MaSP",
                table: "BangTins",
                newName: "IX_BangTins_MaSP");

            migrationBuilder.RenameIndex(
                name: "IX_BangTin_MaKH",
                table: "BangTins",
                newName: "IX_BangTins_MaKH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TinhTrangHangs",
                table: "TinhTrangHangs",
                column: "MaTinhTrang");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams",
                column: "MaSP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quyens",
                table: "Quyens",
                column: "MaQuyen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "MaNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSPs",
                table: "LoaiSPs",
                column: "MaLoai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "MaKH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HinhAnhs",
                table: "HinhAnhs",
                column: "MaHinh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BangTins",
                table: "BangTins",
                column: "MaBangTin");

            migrationBuilder.AddForeignKey(
                name: "FK_BangTins_KhachHangs_MaKH",
                table: "BangTins",
                column: "MaKH",
                principalTable: "KhachHangs",
                principalColumn: "MaKH");

            migrationBuilder.AddForeignKey(
                name: "FK_BangTins_SanPhams_MaSP",
                table: "BangTins",
                column: "MaSP",
                principalTable: "SanPhams",
                principalColumn: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_HinhAnhs_SanPhams_MaSP",
                table: "HinhAnhs",
                column: "MaSP",
                principalTable: "SanPhams",
                principalColumn: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_Quyens_MaQuyen",
                table: "NhanViens",
                column: "MaQuyen",
                principalTable: "Quyens",
                principalColumn: "MaQuyen");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_LoaiSPs_MaLoai",
                table: "SanPhams",
                column: "MaLoai",
                principalTable: "LoaiSPs",
                principalColumn: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_TinhTrangHangs_MaTinhTrang",
                table: "SanPhams",
                column: "MaTinhTrang",
                principalTable: "TinhTrangHangs",
                principalColumn: "MaTinhTrang");
        }
    }
}
