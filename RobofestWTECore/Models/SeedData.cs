using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RobofestWTECore.Data;
using System;
using System.Linq;
using RobofestWTECore.Models;
using System.Collections.Generic;
using RobofestWTE.Models;

namespace RobofestWTECore.Models
{
    public class SeedData
    {
        public static void SeedDefault(GameContext context)
        {
            if (!context.StudentTeams.Any())
            {
                var studentteams = new List<StudentTeam>
                {
                    new RobofestWTE.Models.StudentTeam
                    {
                        TeamNumberBranch = 1001,
                        TeamNumberSpecific = 1,
                        TeamName = "Team Uno",
                        FieldR1 = 0,
                        FieldR2 = 0,
                        Location = "Plymouth"
                    },
                    new RobofestWTE.Models.StudentTeam
                    {
                        TeamNumberBranch = 1001,
                        TeamNumberSpecific = 2,
                        TeamName = "Team Dos",
                        FieldR1 = 0,
                        FieldR2 = 0,
                        Location = "Plymouth"
                    }
                };
                    context.AddRange(studentteams);
                    context.SaveChanges();
            }
        }
        
    }
}