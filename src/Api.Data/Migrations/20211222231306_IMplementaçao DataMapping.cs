using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class IMplementaçaoDataMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataMapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Processo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DonoProcesso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Formato = table.Column<int>(type: "int", nullable: false),
                    Frequencia = table.Column<int>(type: "int", nullable: false),
                    NaturezaTitular = table.Column<int>(type: "int", nullable: false),
                    Origem = table.Column<int>(type: "int", nullable: false),
                    Tratamento = table.Column<int>(type: "int", nullable: false),
                    BaseLegal = table.Column<int>(type: "int", nullable: false),
                    DadosCriancasAdolescentes = table.Column<bool>(type: "bit", nullable: false),
                    MesReferencia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AnoReferencia = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    DataMappingID = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dado_DataMapping_DataMappingID",
                        column: x => x.DataMappingID,
                        principalTable: "DataMapping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dado_DataMappingID",
                table: "Dado",
                column: "DataMappingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dado");

            migrationBuilder.DropTable(
                name: "DataMapping");
        }
    }
}
