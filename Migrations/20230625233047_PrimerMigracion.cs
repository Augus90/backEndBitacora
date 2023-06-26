using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backEndBitacora.Migrations
{
    public partial class PrimerMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    EsGenero = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Remitos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    numero = table.Column<int>(type: "INTEGER", nullable: false),
                    E4 = table.Column<int>(type: "INTEGER", nullable: false),
                    GPS = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx860 = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx700 = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx840 = table.Column<int>(type: "INTEGER", nullable: false),
                    accesorios = table.Column<string>(type: "TEXT", nullable: true),
                    createdAt = table.Column<string>(type: "TEXT", nullable: true),
                    recivedAt = table.Column<string>(type: "TEXT", nullable: true),
                    compromisedAt = table.Column<string>(type: "TEXT", nullable: true),
                    estado = table.Column<string>(type: "TEXT", nullable: true),
                    agencia = table.Column<string>(type: "TEXT", nullable: true),
                    detalle = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remitos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agencias");

            migrationBuilder.DropTable(
                name: "Remitos");
        }
    }
}
