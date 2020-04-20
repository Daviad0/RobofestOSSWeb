using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RobofestWTE.Models;

namespace RobofestWTECore.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> context)
            : base(context)
        {
        }
        public DbSet<RoundEntry> RoundEntries { get; set; }
        public DbSet<GAME> GAMES { get; set; }
        public DbSet<TeamMatch> TeamMatches { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<StudentTeam> StudentTeams { get; set; }
        public DbSet<ScoreMethod> ScoreMethods { get; set; }
        public DbSet<ScoreAmount> ScoreAmounts { get; set; }
        public DbSet<CompField> Fields { get; set; }
        public DbSet<PresetAccount> PresetAccounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentTeam>().HasData(
                new StudentTeam
                {
                    TeamID = 1,
                    TeamNumberBranch = 1001,
                    TeamNumberSpecific = 1,
                    TeamName = "Team One",
                    FieldR1 = 0,
                    FieldR2 = 0,
                    Coach = "Robofest",
                    Location = "Robofest",
                    CompID = 1
                },
                new StudentTeam
                {
                    TeamID = 2,
                    TeamNumberBranch = 1001,
                    TeamNumberSpecific = 2,
                    TeamName = "Team Two",
                    FieldR1 = 0,
                    FieldR2 = 0,
                    Coach = "Robofest",
                    Location = "Robofest",
                    CompID = 1
                }
            );
        }
    }
}
