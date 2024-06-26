using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoNutriGenius.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "materia_prima",
                columns: table => new
                {
                    nome_materia_prima = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_energetico = table.Column<int>(type: "int", nullable: true),
                    carboidratos = table.Column<float>(type: "float", nullable: true),
                    acucares_totais = table.Column<float>(type: "float", nullable: true),
                    acucares_adicionados = table.Column<float>(type: "float", nullable: true),
                    proteinas = table.Column<float>(type: "float", nullable: true),
                    gorduras_totais = table.Column<float>(type: "float", nullable: true),
                    gorduras_saturadas = table.Column<float>(type: "float", nullable: true),
                    gorduras_trans = table.Column<float>(type: "float", nullable: true),
                    fibra_alimentar = table.Column<float>(type: "float", nullable: true),
                    sodio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materia_prima", x => x.nome_materia_prima);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cadastro_nacional = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    razao_social = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome_usuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome_completo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    celular = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    confirme_senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cep = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bairro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rua = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.email);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    nome_produto = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_produto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.nome_produto);
                    table.ForeignKey(
                        name: "FK_produto_usuario_email",
                        column: x => x.email,
                        principalTable: "usuario",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "produto_materia_prima",
                columns: table => new
                {
                    NomeMateriaPrima = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeProduto = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantidade = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto_materia_prima", x => new { x.NomeProduto, x.NomeMateriaPrima });
                    table.ForeignKey(
                        name: "FK_produto_materia_prima_materia_prima_NomeMateriaPrima",
                        column: x => x.NomeMateriaPrima,
                        principalTable: "materia_prima",
                        principalColumn: "nome_materia_prima",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_materia_prima_produto_NomeProduto",
                        column: x => x.NomeProduto,
                        principalTable: "produto",
                        principalColumn: "nome_produto",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_produto_email",
                table: "produto",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "IX_produto_materia_prima_NomeMateriaPrima",
                table: "produto_materia_prima",
                column: "NomeMateriaPrima");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto_materia_prima");

            migrationBuilder.DropTable(
                name: "materia_prima");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
