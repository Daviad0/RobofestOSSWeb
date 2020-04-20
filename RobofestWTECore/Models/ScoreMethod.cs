using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class ScoreMethod
    {
        [Key]
        public int MethodID { get; set; }
        public int GameID { get; set; }
        public string Name { get; set; }

        [ForeignKey("GameID")]
        public virtual GAME GAME { get; set; }
        public ICollection<ScoreAmount> ScoreAmounts { get; set; }
    }
}