using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class CompField
    {
        [Key]
        public int FieldID { get; set; }
        public int FieldNumber { get; set; }
        public int CompID { get; set; }
        public int CurrentTeamID { get; set; }
        public bool Using { get; set; }
        public bool Junior { get; set; }
        public string CurrentTeamNumber { get; set; }

        [ForeignKey("CompID")]

        public virtual Competition Competition { get; set; }
    }
}