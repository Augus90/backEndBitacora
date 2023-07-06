using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backEndBitacora.Migrations
{
    public partial class AgregolatabladeRegistroyalcontexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    numero = table.Column<int>(type: "INTEGER", nullable: false),
                    E4 = table.Column<int>(type: "INTEGER", nullable: false),
                    E4T = table.Column<int>(type: "INTEGER", nullable: false),
                    GPS = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx860 = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx700 = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx840 = table.Column<int>(type: "INTEGER", nullable: false),
                    MRD = table.Column<int>(type: "INTEGER", nullable: false),
                    accesorios = table.Column<string>(type: "TEXT", nullable: true),
                    createdAt = table.Column<string>(type: "TEXT", nullable: true),
                    recivedAt = table.Column<string>(type: "TEXT", nullable: true),
                    compromisedAt = table.Column<string>(type: "TEXT", nullable: true),
                    completedAt = table.Column<string>(type: "TEXT", nullable: true),
                    estado = table.Column<string>(type: "TEXT", nullable: true),
                    agencia = table.Column<string>(type: "TEXT", nullable: true),
                    detalle = table.Column<string>(type: "TEXT", nullable: true),
                    retira = table.Column<string>(type: "TEXT", nullable: true),
                    active = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro");
        }
    }
}
