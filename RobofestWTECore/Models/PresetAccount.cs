using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class PresetAccount
    {
        [Key]
        public string PresetAccoutID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PublicPasskey { get; set; }
        public int CompID { get; set; }

        [ForeignKey("CompID")]
        public virtual Competition Competition { get; set; }
    }
}