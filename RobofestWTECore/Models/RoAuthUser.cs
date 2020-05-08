using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models
{
    public class RoAuthUser
    {
        public string Username { get; set; }
        public List<IdentityRole> Roles { get; set; } = new List<IdentityRole>();
        public string LastSeen { get; set; }
        public int CompID { get; set; }
    }
}
