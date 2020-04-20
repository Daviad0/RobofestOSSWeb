using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class RoundEntry
    {
        [Key]
        public int EntryID { get; set; }
        public int TeamID { get; set; }
        [Required(ErrorMessage = "The round has to be either Round 1 or Round 2")]
        [Range(1, 2, ErrorMessage = "The round has to be either Round 1 or Round 2")]
        public int Round { get; set; }
        [Required(ErrorMessage = "Please enter a possible score (-3 to 148)")]
        [Range(-3, 150, ErrorMessage = "Please enter a possible score (-3 to 148)")]
        public int Score { get; set; }
        [Required(ErrorMessage = "Please enter the time left in seconds (0 to 120). If no time is needed, please just put 0.")]
        [Range(0, 120, ErrorMessage = "Please enter the time left in seconds (0 to 120). If no time is needed, please just put 0.")]
        public int Time { get; set; }
        public string Data { get; set; }
        public bool Rerun { get; set; }
        public bool Usable { get; set; }
        public string JudgeConfirmNotes { get; set; }
        public string StudentInitials { get; set; }
        public string TimeStamp { get; set; }
        public int Field { get; set; }

        [ForeignKey("TeamID")]
        public virtual StudentTeam StudentTeam { get; set; }
    }
}