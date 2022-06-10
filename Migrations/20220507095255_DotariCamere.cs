using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace booking.Migrations
{
    public partial class DotariCamere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DotariCamere",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCamera = table.Column<int>(nullable: false),
                    IdDotare = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotariCamere", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DotariCamere_Camere_IdCamera",
                        column: x => x.IdCamera,
                        principalTable: "Camere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DotariCamere_Dotari_IdDotare",
                        column: x => x.IdDotare,
                        principalTable: "Dotari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DotariCamere_IdCamera",
                table: "DotariCamere",
                column: "IdCamera");

            migrationBuilder.CreateIndex(
                name: "IX_DotariCamere_IdDotare",
                table: "DotariCamere",
                column: "IdDotare");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DotariCamere");
        }
    }
}
