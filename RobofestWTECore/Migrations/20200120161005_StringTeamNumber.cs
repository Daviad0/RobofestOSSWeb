using Microsoft.EntityFrameworkCore.Migrations;

namespace RobofestWTECore.Migrations
{
    public partial class StringTeamNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMatches_StudentTeams_TeamID",
                table: "TeamMatches");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "TeamMatches",
                newName: "CompID");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMatches_TeamID",
                table: "TeamMatches",
                newName: "IX_TeamMatches_CompID");

            migrationBuilder.AddColumn<string>(
                name: "TeamNumber",
                table: "TeamMatches",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMatches_Competitions_CompID",
                table: "TeamMatches",
                column: "CompID",
                principalTable: "Competitions",
                principalColumn: "CompID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMatches_Competitions_CompID",
                table: "TeamMatches");

            migrationBuilder.DropColumn(
                name: "TeamNumber",
                table: "TeamMatches");

            migrationBuilder.RenameColumn(
                name: "CompID",
                table: "TeamMatches",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMatches_CompID",
                table: "TeamMatches",
                newName: "IX_TeamMatches_TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMatches_StudentTeams_TeamID",
                table: "TeamMatches",
                column: "TeamID",
                principalTable: "StudentTeams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
