using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class PresentationViewModel
    {
        public Competition CompData = new Competition();
        public int TeamCount;
        public List<PresentationScoreboardModel> Scoreboard = new List<PresentationScoreboardModel>();
    }
}