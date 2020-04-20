using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class TeamMatch
    {
        [Key]
        public int MatchID { get; set; }
        public int CompID { get; set; }
        public string TeamNumber { get; set; }
        public int RoundNum { get; set; }
        public int Order { get; set; }
        public bool Rerun { get; set; }
        public bool Test { get; set; }
        public bool Completed { get; set; }

    }
}