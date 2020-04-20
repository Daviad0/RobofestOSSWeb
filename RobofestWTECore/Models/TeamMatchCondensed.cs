using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models
{
    public class TeamMatchCondensed
    {
        public string TeamNumber { get; set; }
        public int RoundNum { get; set; }
        public bool Completed { get; set; }
        public bool Test { get; set; }
        public bool Rerun { get; set; }
        public int Validate { get; set; }
    }
}
