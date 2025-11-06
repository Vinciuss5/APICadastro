using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCadastro.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToPessoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Pessoas",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Pessoas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Pessoas",
                newName: "Preco");
        }
    }
}
