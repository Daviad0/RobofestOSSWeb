using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RobofestWTECore.Migrations
{
    public partial class TeamMatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMatches",
                columns: table => new
                {
                    MatchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamID = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Rerun = table.Column<bool>(nullable: false),
                    Test = table.Column<bool>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMatches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_TeamMatches_StudentTeams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "StudentTeams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StudentTeams",
                columns: new[] { "TeamID", "Coach", "CompID", "FieldR1", "FieldR2", "Location", "TeamName", "TeamNumberBranch", "TeamNumberSpecific" },
                values: new object[] { 1, "Robofest", 1, 0, 0, "Robofest", "Team One", 1001, 1 });

            migrationBuilder.InsertData(
                table: "StudentTeams",
                columns: new[] { "TeamID", "Coach", "CompID", "FieldR1", "FieldR2", "Location", "TeamName", "TeamNumberBranch", "TeamNumberSpecific" },
                values: new object[] { 2, "Robofest", 1, 0, 0, "Robofest", "Team Two", 1001, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMatches_TeamID",
                table: "TeamMatches",
                column: "TeamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMatches");

            migrationBuilder.DeleteData(
                table: "StudentTeams",
                keyColumn: "TeamID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentTeams",
                keyColumn: "TeamID",
                keyValue: 2);
        }
    }
}
