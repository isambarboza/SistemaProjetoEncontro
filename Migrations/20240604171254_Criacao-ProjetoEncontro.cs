using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoEncontro.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoProjetoEncontro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioSenha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    AnimaisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalRaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalTipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalCor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalObservacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalDtDesaparecimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnimalDtEncontro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AnimalStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.AnimaisId);
                    table.ForeignKey(
                        name: "FK_Animais_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateTable(
                name: "Observacoes",
                columns: table => new
                {
                    ObservacoesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacoesDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacoesLocal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObservacoesData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnimaisId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacoes", x => x.ObservacoesId);
                    table.ForeignKey(
                        name: "FK_Observacoes_Animais_AnimaisId",
                        column: x => x.AnimaisId,
                        principalTable: "Animais",
                        principalColumn: "AnimaisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Observacoes_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_UsuarioId",
                table: "Animais",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_AnimaisId",
                table: "Observacoes",
                column: "AnimaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_UsuarioId",
                table: "Observacoes",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observacoes");

            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
