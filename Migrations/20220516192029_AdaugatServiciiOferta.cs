using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace booking.Migrations
{
    public partial class AdaugatServiciiOferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiciiOferte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeletedAt = table.Column<bool>(nullable: false),
                    IdServiciu = table.Column<int>(nullable: false),
                    IdOferta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciiOferte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiciiOferte_Oferte_IdOferta",
                        column: x => x.IdOferta,
                        principalTable: "Oferte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiciiOferte_Servicii_IdServiciu",
                        column: x => x.IdServiciu,
                        principalTable: "Servicii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiciiOferte_IdOferta",
                table: "ServiciiOferte",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciiOferte_IdServiciu",
                table: "ServiciiOferte",
                column: "IdServiciu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiciiOferte");
        }
    }
}
