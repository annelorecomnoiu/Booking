using Microsoft.EntityFrameworkCore.Migrations;

namespace booking.Migrations
{
    public partial class ModifyNumeDotareToNume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeDotare",
                table: "Dotari");

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Dotari",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Dotari");

            migrationBuilder.AddColumn<string>(
                name: "NumeDotare",
                table: "Dotari",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
