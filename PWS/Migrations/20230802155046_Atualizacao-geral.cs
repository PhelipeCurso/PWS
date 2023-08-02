using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWS.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacaogeral : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instituicao_Aluno_AlunosId",
                table: "Instituicao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno");

            migrationBuilder.RenameTable(
                name: "Aluno",
                newName: "Alunos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicao_Alunos_AlunosId",
                table: "Instituicao",
                column: "AlunosId",
                principalTable: "Alunos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instituicao_Alunos_AlunosId",
                table: "Instituicao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "Aluno");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicao_Aluno_AlunosId",
                table: "Instituicao",
                column: "AlunosId",
                principalTable: "Aluno",
                principalColumn: "Id");
        }
    }
}
