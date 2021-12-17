using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UsuarioXPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerfilID",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilID",
                table: "Usuario",
                column: "PerfilID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Perfil_PerfilID",
                table: "Usuario",
                column: "PerfilID",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Perfil_PerfilID",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PerfilID",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PerfilID",
                table: "Usuario");
        }
    }
}
