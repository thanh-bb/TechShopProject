using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class test309 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("acc57f0f-8258-41c2-bcf4-a66880c47dd1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dc52455-73d5-48b1-a211-c5bc7d1f48e3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("86186240-41b5-4243-b258-aedcaf029166"), null, null, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("86186240-41b5-4243-b258-aedcaf029166"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("acc57f0f-8258-41c2-bcf4-a66880c47dd1"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8dc52455-73d5-48b1-a211-c5bc7d1f48e3"), 0, "5c15cc50-8b38-4d87-a501-3e73849498dc", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 9, 29, 23, 32, 6, 799, DateTimeKind.Local).AddTicks(8561), "ADMIN1@GMAIL.COM", "ADMIN", "Admin@123$", "032132131", false, "97dc47ec-4ea5-4219-a2a7-50edc2d1f443", "Trần Văn Man", false, "admin" });
        }
    }
}
