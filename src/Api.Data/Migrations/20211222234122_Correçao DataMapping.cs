using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CorreçaoDataMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadoDTOWrite");

            migrationBuilder.CreateTable(
                name: "DadoDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    DataMappingID = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadoDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadoDTO_DataMapping_DataMappingID",
                        column: x => x.DataMappingID,
                        principalTable: "DataMapping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadoDTO_DataMappingID",
                table: "DadoDTO",
                column: "DataMappingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadoDTO");

            migrationBuilder.CreateTable(
                name: "DadoDTOWrite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    DataMappingID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadoDTOWrite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadoDTOWrite_DataMapping_DataMappingID",
                        column: x => x.DataMappingID,
                        principalTable: "DataMapping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadoDTOWrite_DataMappingID",
                table: "DadoDTOWrite",
                column: "DataMappingID");
        }
    }
}
