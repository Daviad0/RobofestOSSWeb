using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class TeamDetailsModel
    {
        public string TeamName;
        public int TeamNumberBranch;
        public int TeamNumberSpecific;
        public string Location;
        public string Coach;
        public int CompID;
        public int TeamID;
        public float RoundAverage;
        public int Rank;
        public RobofestWTE.Models.RoundEntry Round1;
        public RobofestWTE.Models.RoundEntry Round2;
        public int Rerun1;
        public int Rerun2;
        public List<RobofestWTE.Models.RoundEntry> Round = new List<RoundEntry>();
    }
}