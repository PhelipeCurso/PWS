using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWS.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacaotodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instituicao_Alunos_AlunosId",
                table: "Instituicao");

            migrationBuilder.DropForeignKey(
                name: "FK_Instituicao_Docentes_DocentesID",
                table: "Instituicao");

            migrationBuilder.DropIndex(
                name: "IX_Instituicao_AlunosId",
                table: "Instituicao");

            migrationBuilder.DropIndex(
                name: "IX_Instituicao_DocentesID",
                table: "Instituicao");

            migrationBuilder.DropColumn(
                name: "AlunosId",
                table: "Instituicao");

            migrationBuilder.DropColumn(
                name: "DocentesID",
                table: "Instituicao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunosId",
                table: "Instituicao",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocentesID",
                table: "Instituicao",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instituicao_AlunosId",
                table: "Instituicao",
                column: "AlunosId");

            migrationBuilder.CreateIndex(
                name: "IX_Instituicao_DocentesID",
                table: "Instituicao",
                column: "DocentesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicao_Alunos_AlunosId",
                table: "Instituicao",
                column: "AlunosId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instituicao_Docentes_DocentesID",
                table: "Instituicao",
                column: "DocentesID",
                principalTable: "Docentes",
                principalColumn: "Id");
        }
    }
}
