using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_EF_06_Migrazioni.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaCodice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codice",
                table: "Proiezioni",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Proiezioni_Codice",
                table: "Proiezioni",
                column: "Codice",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Proiezioni_Codice",
                table: "Proiezioni");

            migrationBuilder.DropColumn(
                name: "Codice",
                table: "Proiezioni");
        }
    }
}
