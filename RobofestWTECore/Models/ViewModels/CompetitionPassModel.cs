using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models.ViewModels
{
    public class CompetitionPassModel
    {
        public int CompID { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int RunningState { get; set; }
        public bool SetUp { get; set; }
    }
}
