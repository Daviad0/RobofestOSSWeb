using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class ScheduleDataModel
    {
        public int ScheduleID;
        public string Name;
        public bool GameMatch;
        public string Description;
        public TimeSpan Time;
        public bool Selected;
    }
}