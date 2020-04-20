using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class StudentTeam
    {
        [Key]
        public int TeamID { get; set; }
        public int CompID { get; set; }
        [Required(ErrorMessage = "This team needs a name. Please use the location + number after the dash in the team number for a name if it was not specified")]
        public string TeamName { get; set; }
        [Required]
        public int TeamNumberBranch { get; set; }
        public int TeamNumberSpecific { get; set; }
        public string Location { get; set; }
        [Required]
        public string Coach { get; set; }
        public int FieldR1 { get; set; }
        public int FieldR2 { get; set; }

        [ForeignKey("CompID")]
        public virtual Competition Competition { get; set; }
        public virtual ICollection<RoundEntry> RoundEntries { get; set; }
    }
}