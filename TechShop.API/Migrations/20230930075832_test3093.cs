using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class test3093 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c6039d80-3443-47c8-8f75-7505ee995add"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("6d8a58df-4c34-4202-85f7-8218e032c35f"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7665276e-011d-4c99-a89d-baca4b04967e"), 0, "8ad9c4f8-dbde-48b2-b381-e1376ea963d7", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 9, 30, 14, 58, 31, 982, DateTimeKind.Local).AddTicks(8792), "ADMIN1@GMAIL.COM", "ADMIN", "Admin@123$", "032132131", false, "92b9937c-e7d9-4ea5-8430-c34fca579147", "Trần Văn Man", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d8a58df-4c34-4202-85f7-8218e032c35f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7665276e-011d-4c99-a89d-baca4b04967e"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("c6039d80-3443-47c8-8f75-7505ee995add"), null, null, null, "admin" });
        }
    }
}
