using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("703125e5-ed44-4c8f-85e1-1e26e20ac699"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d028086b-07c7-426f-8552-3d694797e508"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("3b68b178-6da1-4f4d-9d4e-106e14a8184b"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("613998ed-da4b-49ae-b907-bac96c089272"), 0, "1921e9fc-8c80-4ff1-b5ef-cd11a63476ce", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 19, 13, 50, 28, 433, DateTimeKind.Local).AddTicks(8908), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "a30e13a0-a7d7-40c4-a9ec-10669207c91d", "Trần Văn Man", false, "admin" });

            migrationBuilder.UpdateData(
                table: "SanPham",
                keyColumn: "MaSP",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "SanPham",
                keyColumn: "MaSP",
                keyValue: 2,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "SanPham",
                keyColumn: "MaSP",
                keyValue: 3,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "SanPham",
                keyColumn: "MaSP",
                keyValue: 4,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "SanPham",
                keyColumn: "MaSP",
                keyValue: 5,
                column: "Image",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b68b178-6da1-4f4d-9d4e-106e14a8184b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("613998ed-da4b-49ae-b907-bac96c089272"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "SanPham");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("703125e5-ed44-4c8f-85e1-1e26e20ac699"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d028086b-07c7-426f-8552-3d694797e508"), 0, "d777896e-41b9-4f5b-b363-8aa12fae48a9", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 18, 22, 28, 20, 188, DateTimeKind.Local).AddTicks(9468), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "0f696d14-a4eb-415b-ae64-c81cce26dc3f", "Trần Văn Man", false, "admin" });
        }
    }
}
