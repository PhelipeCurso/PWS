using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWS.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoAluno01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Instituição",
                table: "Aluno",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instituição",
                table: "Aluno");
        }
    }
}
