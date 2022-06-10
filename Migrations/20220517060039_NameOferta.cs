using Microsoft.EntityFrameworkCore.Migrations;

namespace booking.Migrations
{
    public partial class NameOferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Oferte",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Oferte");
        }
    }
}
