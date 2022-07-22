using Microsoft.EntityFrameworkCore.Migrations;

namespace NasaAPI.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meteoritos",
                columns: table => new
                {
                    _nombre = table.Column<string>(nullable: false),
                    _diametro = table.Column<float>(nullable: false),
                    _velocidad = table.Column<string>(nullable: true),
                    _fecha = table.Column<string>(nullable: true),
                    _planeta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meteoritos", x => x._nombre);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meteoritos");
        }
    }
}
