using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backEndBitacora.Migrations
{
    public partial class Herenciaderemitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Remitos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "Remitos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "completedAt",
                table: "Remitos",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Remitos");

            migrationBuilder.DropColumn(
                name: "active",
                table: "Remitos");

            migrationBuilder.DropColumn(
                name: "completedAt",
                table: "Remitos");

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    E4 = table.Column<int>(type: "INTEGER", nullable: false),
                    E4T = table.Column<int>(type: "INTEGER", nullable: false),
                    GPS = table.Column<int>(type: "INTEGER", nullable: false),
                    MRD = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx700 = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx840 = table.Column<int>(type: "INTEGER", nullable: false),
                    Tx860 = table.Column<int>(type: "INTEGER", nullable: false),
                    accesorios = table.Column<string>(type: "TEXT", nullable: true),
                    active = table.Column<bool>(type: "INTEGER", nullable: false),
                    agencia = table.Column<string>(type: "TEXT", nullable: true),
                    completedAt = table.Column<string>(type: "TEXT", nullable: true),
                    compromisedAt = table.Column<string>(type: "TEXT", nullable: true),
                    createdAt = table.Column<string>(type: "TEXT", nullable: true),
                    detalle = table.Column<string>(type: "TEXT", nullable: true),
                    estado = table.Column<string>(type: "TEXT", nullable: true),
                    numero = table.Column<int>(type: "INTEGER", nullable: true),
                    recivedAt = table.Column<string>(type: "TEXT", nullable: true),
                    retira = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                });
        }
    }
}
