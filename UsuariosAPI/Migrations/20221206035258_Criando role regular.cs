using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosAPI.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6b1cea44-129a-49ca-bb8c-8082bb6e1881");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "c3919923-ac56-43d5-b130-ed14625dce2c", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc90584-d92c-4791-8f8b-c3b73a77a488", "AQAAAAEAACcQAAAAEFjrm/rjUv2U7plXN41sCAAifKLYJ2+6rHA+CNmQt7AQddX199lclb8uH6fhdY6NlQ==", "0b2c81e1-d18c-44ac-b9df-99bee7cd0370" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "a5e352f3-4b8d-4f27-820e-28793e67c1d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e6c5b6-fe53-4f50-ab64-5d5f83ae7535", "AQAAAAEAACcQAAAAEPRu1ONj4aoKinndxVyhaDzsWisE/Y3AbaOEo4RCyj989vWowipkzA4iqyecXxW0BA==", "74e90ad0-9e61-4977-90e9-1046b041fa09" });
        }
    }
}
