using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CampanhaInfopharma.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drogaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(nullable: false),
                    NomeFantasia = table.Column<string>(nullable: false),
                    CNPJ = table.Column<string>(maxLength: 18, nullable: false),
                    NomeResponsavel = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drogaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CorMarcacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContatoDrogaria",
                columns: table => new
                {
                    DataUltimaAlteracao = table.Column<DateTime>(nullable: false),
                    FuncionarioIdFk = table.Column<int>(nullable: false),
                    DrogariaIdFk = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatoDrogaria", x => x.DrogariaIdFk);
                    table.ForeignKey(
                        name: "FK_ContatoDrogaria_Drogaria_DrogariaIdFk",
                        column: x => x.DrogariaIdFk,
                        principalTable: "Drogaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContatoDrogaria_Funcionario_FuncionarioIdFk",
                        column: x => x.FuncionarioIdFk,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContatoDrogaria_FuncionarioIdFk",
                table: "ContatoDrogaria",
                column: "FuncionarioIdFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContatoDrogaria");

            migrationBuilder.DropTable(
                name: "Drogaria");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
