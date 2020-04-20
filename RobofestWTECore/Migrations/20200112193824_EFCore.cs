using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RobofestWTECore.Migrations
{
    public partial class EFCore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GAMES",
                columns: table => new
                {
                    GameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GAMES", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameID = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    ExtraData = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    RunningFields = table.Column<int>(nullable: false),
                    ScheduleNumber = table.Column<int>(nullable: false),
                    field1preferred = table.Column<int>(nullable: false),
                    field2preferred = table.Column<int>(nullable: false),
                    field3preferred = table.Column<int>(nullable: false),
                    field4preferred = table.Column<int>(nullable: false),
                    field5preferred = table.Column<int>(nullable: false),
                    field6preferred = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompID);
                    table.ForeignKey(
                        name: "FK_Competitions_GAMES_GameID",
                        column: x => x.GameID,
                        principalTable: "GAMES",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScoreMethods",
                columns: table => new
                {
                    MethodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreMethods", x => x.MethodID);
                    table.ForeignKey(
                        name: "FK_ScoreMethods_GAMES_GameID",
                        column: x => x.GameID,
                        principalTable: "GAMES",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    FieldID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FieldNumber = table.Column<int>(nullable: false),
                    CompID = table.Column<int>(nullable: false),
                    CurrentTeamID = table.Column<int>(nullable: false),
                    Using = table.Column<bool>(nullable: false),
                    Junior = table.Column<bool>(nullable: false),
                    CurrentTeamNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.FieldID);
                    table.ForeignKey(
                        name: "FK_Fields_Competitions_CompID",
                        column: x => x.CompID,
                        principalTable: "Competitions",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTeams",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompID = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: false),
                    TeamNumberBranch = table.Column<int>(nullable: false),
                    TeamNumberSpecific = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Coach = table.Column<string>(nullable: false),
                    FieldR1 = table.Column<int>(nullable: false),
                    FieldR2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_StudentTeams_Competitions_CompID",
                        column: x => x.CompID,
                        principalTable: "Competitions",
                        principalColumn: "CompID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScoreAmounts",
                columns: table => new
                {
                    AmountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MethodID = table.Column<int>(nullable: false),
                    AmountName = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreAmounts", x => x.AmountID);
                    table.ForeignKey(
                        name: "FK_ScoreAmounts_ScoreMethods_MethodID",
                        column: x => x.MethodID,
                        principalTable: "ScoreMethods",
                        principalColumn: "MethodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoundEntries",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamID = table.Column<int>(nullable: false),
                    Round = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    Rerun = table.Column<bool>(nullable: false),
                    Usable = table.Column<bool>(nullable: false),
                    JudgeConfirmNotes = table.Column<string>(nullable: true),
                    StudentInitials = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<string>(nullable: true),
                    Field = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundEntries", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_RoundEntries_StudentTeams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "StudentTeams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_GameID",
                table: "Competitions",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_CompID",
                table: "Fields",
                column: "CompID");

            migrationBuilder.CreateIndex(
                name: "IX_RoundEntries_TeamID",
                table: "RoundEntries",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreAmounts_MethodID",
                table: "ScoreAmounts",
                column: "MethodID");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreMethods_GameID",
                table: "ScoreMethods",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeams_CompID",
                table: "StudentTeams",
                column: "CompID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "RoundEntries");

            migrationBuilder.DropTable(
                name: "ScoreAmounts");

            migrationBuilder.DropTable(
                name: "StudentTeams");

            migrationBuilder.DropTable(
                name: "ScoreMethods");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "GAMES");
        }
    }
}
