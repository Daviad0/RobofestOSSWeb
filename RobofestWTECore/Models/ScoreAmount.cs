using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class ScoreAmount
    {
        [Key]
        public int AmountID { get; set; }
        public int MethodID { get; set; }
        public string AmountName { get; set; }
        public int Amount { get; set; }

        [ForeignKey("MethodID")]
        public virtual ScoreMethod ScoreMethod { get; set; }
    }
}