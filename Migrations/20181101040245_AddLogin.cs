using Microsoft.EntityFrameworkCore.Migrations;

namespace CampanhaInfopharma.Migrations
{
    public partial class AddLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Funcionario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Funcionario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Funcionario");
        }
    }
}
