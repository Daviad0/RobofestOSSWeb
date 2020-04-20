using Microsoft.EntityFrameworkCore.Migrations;

namespace RobofestWTECore.Migrations
{
    public partial class RoundNum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoundNum",
                table: "TeamMatches",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoundNum",
                table: "TeamMatches");
        }
    }
}
