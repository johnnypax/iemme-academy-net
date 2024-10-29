using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_EF_06_Migrazioni.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaCategorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Film_Categoria",
                columns: table => new
                {
                    FilmCategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmRIF = table.Column<int>(type: "int", nullable: false),
                    CategoriaRIF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film_Categoria", x => x.FilmCategoriaID);
                    table.ForeignKey(
                        name: "FK_Film_Categoria_Categorie_CategoriaRIF",
                        column: x => x.CategoriaRIF,
                        principalTable: "Categorie",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Categoria_Proiezioni_FilmRIF",
                        column: x => x.FilmRIF,
                        principalTable: "Proiezioni",
                        principalColumn: "FilmID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_Nome",
                table: "Categorie",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Film_Categoria_CategoriaRIF",
                table: "Film_Categoria",
                column: "CategoriaRIF");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Categoria_FilmRIF",
                table: "Film_Categoria",
                column: "FilmRIF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film_Categoria");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
