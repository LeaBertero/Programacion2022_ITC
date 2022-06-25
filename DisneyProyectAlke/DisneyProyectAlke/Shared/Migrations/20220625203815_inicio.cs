using Microsoft.EntityFrameworkCore.Migrations;

namespace DisneyProyectAlke.Shared.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    PeliculaSerieAsociada = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pelicula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
                    Fechacreacion = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    calificacion = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    PersonajeAsociado = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pelicula", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 120, nullable: false),
                    Historia = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Pelicula = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personajes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Pasword = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Token = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Genero_Id",
                table: "generos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_PeliculaSerie_Id",
                table: "pelicula",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_Personaje_Id",
                table: "personajes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_Usuario_Id",
                table: "usuarios",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "generos");

            migrationBuilder.DropTable(
                name: "pelicula");

            migrationBuilder.DropTable(
                name: "personajes");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}

