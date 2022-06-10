using Microsoft.EntityFrameworkCore.Migrations;

namespace booking.Migrations
{
    public partial class ImplementareCamera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Camere",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Camere",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Camere",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Camere",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image5",
                table: "Camere",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image6",
                table: "Camere",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NrCamere",
                table: "Camere",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Camere",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "NrCamere",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Camere");
        }
    }
}
