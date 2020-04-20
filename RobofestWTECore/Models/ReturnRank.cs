using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models
{
    public class ReturnRank
    {
        public int Rank { get; set; }
        public string TeamNumber { get; set; }
        public float AverageScore { get; set; }
        public int Round1Score { get; set; }
        public int Round2Score { get; set; }
    }
}
