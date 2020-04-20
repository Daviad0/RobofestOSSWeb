using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class CompetitionPageModel
    {
        public string Location;
        public DateTime Date;
        public string ExtraData;
        public int CompID;
        public int TeamCount;
        public int GameID;
        public System.Collections.Generic.List<RobofestWTE.Models.TeamDataModel> Teams = new List<TeamDataModel>();
        public List<ScheduleDataModel> ScheduleDatas = new List<ScheduleDataModel>();
        public List<string> FieldPreferred = new List<string>();
        public bool[] validmatches = new bool[6];
    }
}