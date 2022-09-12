using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmes.Migrations
{
    public partial class adicionandorelaçãoentreGerenteeCinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GerenteId",
                table: "Cinemas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_GerenteId",
                table: "Cinemas",
                column: "GerenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Gerentes_GerenteId",
                table: "Cinemas",
                column: "GerenteId",
                principalTable: "Gerentes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Gerentes_GerenteId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_GerenteId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "GerenteId",
                table: "Cinemas");
        }
    }
}
