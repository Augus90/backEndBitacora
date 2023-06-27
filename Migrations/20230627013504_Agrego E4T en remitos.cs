using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backEndBitacora.Migrations
{
    public partial class AgregoE4Tenremitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "E4T",
                table: "Remitos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "E4T",
                table: "Remitos");
        }
    }
}
