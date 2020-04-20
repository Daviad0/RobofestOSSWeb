using Microsoft.EntityFrameworkCore.Migrations;

namespace RobofestWTECore.Migrations
{
    public partial class validmatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "validmatch1",
                table: "Competitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "validmatch2",
                table: "Competitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "validmatch3",
                table: "Competitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "validmatch4",
                table: "Competitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "validmatch5",
                table: "Competitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "validmatch6",
                table: "Competitions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "validmatch1",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "validmatch2",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "validmatch3",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "validmatch4",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "validmatch5",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "validmatch6",
                table: "Competitions");
        }
    }
}
