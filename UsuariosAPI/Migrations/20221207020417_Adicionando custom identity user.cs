using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "7ebbb74f-46c9-42f1-83a3-3aa7be868a52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "3ddfc273-eb96-42ec-a9bb-3d69b078f26c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cfe90f8-8e2a-4fe2-97f2-10ff7ed3b9bc", "AQAAAAEAACcQAAAAENpst4Swh9VG9mZ9/C+/6mMYp+/AKnR9kTYEYfSk6xKVHk/xZ9ITxTkgN1TSWS67pQ==", "56b8d000-d0da-47a2-a54d-c60810868551" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "c3919923-ac56-43d5-b130-ed14625dce2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6b1cea44-129a-49ca-bb8c-8082bb6e1881");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc90584-d92c-4791-8f8b-c3b73a77a488", "AQAAAAEAACcQAAAAEFjrm/rjUv2U7plXN41sCAAifKLYJ2+6rHA+CNmQt7AQddX199lclb8uH6fhdY6NlQ==", "0b2c81e1-d18c-44ac-b9df-99bee7cd0370" });
        }
    }
}
