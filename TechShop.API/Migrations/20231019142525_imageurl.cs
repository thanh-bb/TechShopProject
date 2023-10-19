using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class imageurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b68b178-6da1-4f4d-9d4e-106e14a8184b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("613998ed-da4b-49ae-b907-bac96c089272"));

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "LoaiSP",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("dab580ad-99f1-42a5-b5ff-40e4bba17c55"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d053caac-f076-4fdf-9c9d-fef2fa0f0c90"), 0, "1894f3f9-23aa-41c1-aecd-bdd47e624da0", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 19, 21, 25, 24, 975, DateTimeKind.Local).AddTicks(62), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "f266c424-e98a-4c18-ae3a-8e5dae773700", "Trần Văn Man", false, "admin" });

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "01",
                column: "ImageURL",
                value: "~/assets/img/categories/Laptop.png");

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "02",
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "03",
                column: "ImageURL",
                value: "~/assets/img/categories/Laptop.png");

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "04",
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "05",
                column: "ImageURL",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dab580ad-99f1-42a5-b5ff-40e4bba17c55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d053caac-f076-4fdf-9c9d-fef2fa0f0c90"));

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "LoaiSP");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("3b68b178-6da1-4f4d-9d4e-106e14a8184b"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("613998ed-da4b-49ae-b907-bac96c089272"), 0, "1921e9fc-8c80-4ff1-b5ef-cd11a63476ce", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 19, 13, 50, 28, 433, DateTimeKind.Local).AddTicks(8908), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "a30e13a0-a7d7-40c4-a9ec-10669207c91d", "Trần Văn Man", false, "admin" });
        }
    }
}
