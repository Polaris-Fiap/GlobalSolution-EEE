using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalSolution_Polaris.Migrations
{
    public partial class CriandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeEstado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SiglaEstado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadoID);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    CidadeID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeCidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SiglaCidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EstadoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.CidadeID);
                    table.ForeignKey(
                        name: "FK_Cidades_Estados_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "Estados",
                        principalColumn: "EstadoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bairros",
                columns: table => new
                {
                    BairroID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeBairro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CidadeID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairros", x => x.BairroID);
                    table.ForeignKey(
                        name: "FK_Bairros_Cidades_CidadeID",
                        column: x => x.CidadeID,
                        principalTable: "Cidades",
                        principalColumn: "CidadeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Cep = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NomeRua = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NumeroRua = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DescricaoComplemento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BairroID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoID);
                    table.ForeignKey(
                        name: "FK_Enderecos_Bairros_BairroID",
                        column: x => x.BairroID,
                        principalTable: "Bairros",
                        principalColumn: "BairroID");
                });

            migrationBuilder.CreateTable(
                name: "Mulheres",
                columns: table => new
                {
                    MulherID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Cpf = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Telefone = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EnderecoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mulheres", x => x.MulherID);
                    table.ForeignKey(
                        name: "FK_Mulheres_Enderecos_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocaisEscolhidos",
                columns: table => new
                {
                    LocalEscolhidoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Incidente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    AvaliacaoPerigo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MulherID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaisEscolhidos", x => x.LocalEscolhidoID);
                    table.ForeignKey(
                        name: "FK_LocaisEscolhidos_Mulheres_MulherID",
                        column: x => x.MulherID,
                        principalTable: "Mulheres",
                        principalColumn: "MulherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bairros_CidadeID",
                table: "Bairros",
                column: "CidadeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_EstadoID",
                table: "Cidades",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_BairroID",
                table: "Enderecos",
                column: "BairroID");

            migrationBuilder.CreateIndex(
                name: "IX_LocaisEscolhidos_MulherID",
                table: "LocaisEscolhidos",
                column: "MulherID");

            migrationBuilder.CreateIndex(
                name: "IX_Mulheres_EnderecoID",
                table: "Mulheres",
                column: "EnderecoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocaisEscolhidos");

            migrationBuilder.DropTable(
                name: "Mulheres");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Bairros");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
