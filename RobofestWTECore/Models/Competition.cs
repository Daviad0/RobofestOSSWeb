using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class Competition
    {
        [Key]
        public int CompID { get; set; }
        public int GameID { get; set; }
        public string Location { get; set; }
        public string ExtraData { get; set; }
        public DateTime Date { get; set; }
        public int RunningFields { get; set; }
        public int ScheduleNumber { get; set; }
        public int RunningState { get; set; }
        public virtual GAME GAME { get; set; }
        public virtual ICollection<StudentTeam> StudentTeams { get; set; }
        public virtual ICollection<CompField> Fields { get; set; }
        public string field1preferred { get; set; }
        public string field2preferred { get; set; }
        public string field3preferred { get; set; }
        public string field4preferred { get; set; }
        public string field5preferred { get; set; }
        public string field6preferred { get; set; }
        public bool validmatch1 { get; set; } 
        public bool validmatch2 { get; set; } 
        public bool validmatch3 { get; set; } 
        public bool validmatch4 { get; set; } 
        public bool validmatch5 { get; set; } 
        public bool validmatch6 { get; set; } 
        public bool setup { get; set; }
    }
}