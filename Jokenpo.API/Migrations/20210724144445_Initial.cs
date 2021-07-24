using Microsoft.EntityFrameworkCore.Migrations;

namespace Jokenpo.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vencedor = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    EscolhaJogador = table.Column<int>(type: "INTEGER", nullable: false),
                    DscEscolhaJogador = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    EscolhaMaquina = table.Column<int>(type: "INTEGER", nullable: false),
                    DscEscolhaMaquina = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rankings");
        }
    }
}
