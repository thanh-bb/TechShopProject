using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class imageurl_link : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dab580ad-99f1-42a5-b5ff-40e4bba17c55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d053caac-f076-4fdf-9c9d-fef2fa0f0c90"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("2e87de46-d507-4844-ac14-8a1f0a1cbce1"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("242b4300-eb22-4975-8871-ac031162c2d8"), 0, "bedaa6b1-e594-488c-89ca-fe27311a0cb4", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 19, 21, 41, 52, 20, DateTimeKind.Local).AddTicks(4219), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "c817e2b7-7283-43d7-80c8-d60cc06efa51", "Trần Văn Man", false, "admin" });

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "01",
                column: "ImageURL",
                value: "./assets/img/categories/Laptop.png");

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "02",
                column: "ImageURL",
                value: "./assets/img/categories/Phone.png");

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "03",
                column: "ImageURL",
                value: "./assets/img/categories/Keyboard.png");

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "04",
                column: "ImageURL",
                value: "./assets/img/categories/Chuot.png");

            migrationBuilder.UpdateData(
                table: "LoaiSP",
                keyColumn: "MaLoai",
                keyValue: "05",
                column: "ImageURL",
                value: "./assets/img/categories/HeadPhone.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2e87de46-d507-4844-ac14-8a1f0a1cbce1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("242b4300-eb22-4975-8871-ac031162c2d8"));

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
    }
}
