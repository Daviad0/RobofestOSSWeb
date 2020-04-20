using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class GamePageModel
    {
        public string Name;
        public int Year;
        public string Desc;
        public int GameID;
        public int TeamCount;
        public System.Collections.Generic.List<RobofestWTE.Models.CompetitionPageModel> Competitions = new List<CompetitionPageModel>();
    }
}