using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Generador_de_poses.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuerpos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    RutaImagen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuerpos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expresions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    RutaImagen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expresions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    RutaImagen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cuerpos",
                columns: new[] { "Id", "Nombre", "RutaImagen" },
                values: new object[,]
                {
                    { 1, "Musculoso", "muscles.png" },
                    { 2, "Delgado", "slim.png" }
                });

            migrationBuilder.InsertData(
                table: "Expresions",
                columns: new[] { "Id", "Nombre", "RutaImagen" },
                values: new object[,]
                {
                    { 1, "Normal", "normal.png" },
                    { 2, "Alegre", "alegre.png" }
                });

            migrationBuilder.InsertData(
                table: "Poses",
                columns: new[] { "Id", "Nombre", "RutaImagen" },
                values: new object[,]
                {
                    { 1, "Parado", "parado.png" },
                    { 2, "Agachado", "agachado.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuerpos");

            migrationBuilder.DropTable(
                name: "Expresions");

            migrationBuilder.DropTable(
                name: "Poses");
        }
    }
}
