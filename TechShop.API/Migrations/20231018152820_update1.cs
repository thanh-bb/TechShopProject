using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechShop.API.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ff075b6b-e7d4-427e-9c31-399335053703"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e20b870d-1844-4cff-b3a6-97409599359b"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "HinhAnh");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("703125e5-ed44-4c8f-85e1-1e26e20ac699"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d028086b-07c7-426f-8552-3d694797e508"), 0, "d777896e-41b9-4f5b-b363-8aa12fae48a9", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 18, 22, 28, 20, 188, DateTimeKind.Local).AddTicks(9468), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "0f696d14-a4eb-415b-ae64-c81cce26dc3f", "Trần Văn Man", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("703125e5-ed44-4c8f-85e1-1e26e20ac699"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d028086b-07c7-426f-8552-3d694797e508"));

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "HinhAnh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "TenQuyen" },
                values: new object[] { new Guid("ff075b6b-e7d4-427e-9c31-399335053703"), null, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DienThoai", "Email", "EmailConfirmed", "GioiTinh", "HashPasswd", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenKH", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e20b870d-1844-4cff-b3a6-97409599359b"), 0, "4fe67a3f-c498-44e7-8c89-a653f2077b88", "0985879105", "abc@gmail.com", false, false, "123456", false, null, new DateTime(2023, 10, 18, 22, 24, 36, 58, DateTimeKind.Local).AddTicks(1967), "ADMIN1@GMAIL.COM", "ADMIN", "123456", "032132131", false, "4da10392-6e40-451c-bc43-b420c3073c5c", "Trần Văn Man", false, "admin" });
        }
    }
}
