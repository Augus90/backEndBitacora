using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backEndBitacora.Migrations
{
    public partial class AgregolatabladeRegistroyalcontexto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Registro",
                table: "Registro");

            migrationBuilder.RenameTable(
                name: "Registro",
                newName: "Registros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registros",
                table: "Registros",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Registros",
                table: "Registros");

            migrationBuilder.RenameTable(
                name: "Registros",
                newName: "Registro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registro",
                table: "Registro",
                column: "Id");
        }
    }
}
