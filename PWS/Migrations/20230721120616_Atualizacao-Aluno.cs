using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWS.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataMatricula",
                table: "Aluno",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataMatricula",
                table: "Aluno");
        }
    }
}
