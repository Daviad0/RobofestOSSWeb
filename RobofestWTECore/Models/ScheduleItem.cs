using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models
{
    public class ScheduleItem
    {
        public int Field { get; set; }
        public string TeamNumber { get; set; }
        public int Round { get; set; }
        public bool Rerun { get; set; }
        public bool Test { get; set; }
        public bool Valid { get; set; }
    }
}
