using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models.ViewModels
{
    public class StaticCompetition
    {
        public Dictionary<int, StaticField> Fields = new Dictionary<int, StaticField>
            {
                { 1, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 2, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 3, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 4, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 5, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 6, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
            };
        public Dictionary<int, StaticField> OnDeck = new Dictionary<int, StaticField>
            {
                { 1, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 2, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 3, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 4, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 5, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
                { 6, new StaticField { TeamID = 0, TeamNumber = "EMPTY", CurrentScore = 0, Data = "", Status = 0, HelpNeeded = false} },
            };
        public int ScorekeeperStatus;
        public bool JudgesLocked = true;
    }
}
