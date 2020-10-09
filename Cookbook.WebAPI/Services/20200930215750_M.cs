using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.WebAPI.Migrations
{
    public partial class M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorisnikId",
                table: "Dokumenti",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dokumenti_KorisnikId",
                table: "Dokumenti",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dokumenti_Korisnik_KorisnikId",
                table: "Dokumenti",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dokumenti_Korisnik_KorisnikId",
                table: "Dokumenti");

            migrationBuilder.DropIndex(
                name: "IX_Dokumenti_KorisnikId",
                table: "Dokumenti");

            migrationBuilder.DropColumn(
                name: "KorisnikId",
                table: "Dokumenti");
        }
    }
}
