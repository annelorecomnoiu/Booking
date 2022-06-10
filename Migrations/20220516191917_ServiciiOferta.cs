using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace booking.Migrations
{
    public partial class ServiciiOferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oferte_Servicii_IdServiciu",
                table: "Oferte");

            migrationBuilder.DropIndex(
                name: "IX_Oferte_IdServiciu",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "IdServiciu",
                table: "Oferte");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEnd",
                table: "Oferte",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataStart",
                table: "Oferte",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataEnd",
                table: "Oferte");

            migrationBuilder.DropColumn(
                name: "DataStart",
                table: "Oferte");

            migrationBuilder.AddColumn<int>(
                name: "IdServiciu",
                table: "Oferte",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_IdServiciu",
                table: "Oferte",
                column: "IdServiciu");

            migrationBuilder.AddForeignKey(
                name: "FK_Oferte_Servicii_IdServiciu",
                table: "Oferte",
                column: "IdServiciu",
                principalTable: "Servicii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
