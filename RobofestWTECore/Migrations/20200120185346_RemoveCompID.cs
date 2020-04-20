using Microsoft.EntityFrameworkCore.Migrations;

namespace RobofestWTECore.Migrations
{
    public partial class RemoveCompID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMatches_Competitions_CompID",
                table: "TeamMatches");

            migrationBuilder.DropIndex(
                name: "IX_TeamMatches_CompID",
                table: "TeamMatches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TeamMatches_CompID",
                table: "TeamMatches",
                column: "CompID");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMatches_Competitions_CompID",
                table: "TeamMatches",
                column: "CompID",
                principalTable: "Competitions",
                principalColumn: "CompID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
