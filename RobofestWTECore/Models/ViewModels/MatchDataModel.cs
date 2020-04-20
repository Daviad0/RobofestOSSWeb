using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class MatchDataModel
    {
        public List<StudentTeam> R1List = new List<StudentTeam>();
        public List<StudentTeam> R2List = new List<StudentTeam>();
        public int RunningFields;
        public Competition Competition;
        public int Matches;
    }
}