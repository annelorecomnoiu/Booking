using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace booking.Migrations
{
    public partial class Oferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oferte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeletedAt = table.Column<bool>(nullable: true),
                    CameraId = table.Column<int>(nullable: false),
                    ServiciuId = table.Column<int>(nullable: false),
                    Pret = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oferte_Camere_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Camere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oferte_Servicii_ServiciuId",
                        column: x => x.ServiciuId,
                        principalTable: "Servicii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_CameraId",
                table: "Oferte",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_ServiciuId",
                table: "Oferte",
                column: "ServiciuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oferte");
        }
    }
}
