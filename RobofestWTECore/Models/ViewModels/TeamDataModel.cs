using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class TeamDataModel
    {
        public string TeamName;
        public int TeamNumberBranch;
        public int TeamNumberSpecific;
        public int TeamID;
        public int Round1Score;
        public int Round2Score;
        public int Round1Time;
        public int Round2Time;
        public double RoundAverage;
        public int Rank;
        public bool ReadyR1;
        public bool ReadyR2;
    }
}