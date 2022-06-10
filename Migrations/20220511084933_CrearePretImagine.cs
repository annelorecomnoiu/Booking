using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace booking.Migrations
{
    public partial class CrearePretImagine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferte_Camere_CameraId",
                table: "Oferte");

            migrationBuilder.DropForeignKey(
                name: "FK_Oferte_Servicii_ServiciuId",
                table: "Oferte");

            migrationBuilder.DropIndex(
                name: "IX_Oferte_CameraId",
                table: "Oferte");

            migrationBuilder.DropIndex(
                name: "IX_Oferte_ServiciuId",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "CameraId",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "ServiciuId",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Image5",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Image6",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Camere");

            migrationBuilder.AddColumn<int>(
                name: "IdCamera",
                table: "Oferte",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdServiciu",
                table: "Oferte",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "DeletedAt",
                table: "DotariCamere",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Imagini",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeletedAt = table.Column<bool>(nullable: true),
                    IdCamera = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagini", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagini_Camere_IdCamera",
                        column: x => x.IdCamera,
                        principalTable: "Camere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preturi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeletedAt = table.Column<bool>(nullable: true),
                    IdCamera = table.Column<int>(nullable: false),
                    DataStart = table.Column<DateTime>(nullable: false),
                    DataEnd = table.Column<DateTime>(nullable: false),
                    Valoare = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preturi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preturi_Camere_IdCamera",
                        column: x => x.IdCamera,
                        principalTable: "Camere",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_IdCamera",
                table: "Oferte",
                column: "IdCamera");

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_IdServiciu",
                table: "Oferte",
                column: "IdServiciu");

            migrationBuilder.CreateIndex(
                name: "IX_Imagini_IdCamera",
                table: "Imagini",
                column: "IdCamera");

            migrationBuilder.CreateIndex(
                name: "IX_Preturi_IdCamera",
                table: "Preturi",
                column: "IdCamera");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferte_Camere_IdCamera",
                table: "Oferte",
                column: "IdCamera",
                principalTable: "Camere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferte_Servicii_IdServiciu",
                table: "Oferte",
                column: "IdServiciu",
                principalTable: "Servicii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferte_Camere_IdCamera",
                table: "Oferte");

            migrationBuilder.DropForeignKey(
                name: "FK_Oferte_Servicii_IdServiciu",
                table: "Oferte");

            migrationBuilder.DropTable(
                name: "Imagini");

            migrationBuilder.DropTable(
                name: "Preturi");

            migrationBuilder.DropIndex(
                name: "IX_Oferte_IdCamera",
                table: "Oferte");

            migrationBuilder.DropIndex(
                name: "IX_Oferte_IdServiciu",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "IdCamera",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "IdServiciu",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DotariCamere");

            migrationBuilder.AddColumn<int>(
                name: "CameraId",
                table: "Oferte",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiciuId",
                table: "Oferte",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Camere",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Camere",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Camere",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Camere",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image5",
                table: "Camere",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image6",
                table: "Camere",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Pret",
                table: "Camere",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_CameraId",
                table: "Oferte",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_ServiciuId",
                table: "Oferte",
                column: "ServiciuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferte_Camere_CameraId",
                table: "Oferte",
                column: "CameraId",
                principalTable: "Camere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oferte_Servicii_ServiciuId",
                table: "Oferte",
                column: "ServiciuId",
                principalTable: "Servicii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
