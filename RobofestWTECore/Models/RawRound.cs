using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models
{
    public class RawRound
    {
        public int RoundNum { get; set; }
        public int Score { get; set; }
        public bool Usable { get; set; }
        public int Time { get; set; }
    }
}
