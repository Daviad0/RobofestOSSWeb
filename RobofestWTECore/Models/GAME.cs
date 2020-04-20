using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class GAME
    {
        [Key]
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
        public virtual ICollection<ScoreMethod> ScoreMethods { get; set; }
    }
}