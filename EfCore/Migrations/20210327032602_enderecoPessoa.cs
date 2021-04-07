using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCore.Migrations
{
    public partial class enderecoPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco_Logradouro",
                table: "Pessoas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco_Logradouro",
                table: "Pessoas");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pessoas",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
