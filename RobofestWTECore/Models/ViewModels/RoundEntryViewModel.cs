using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class RoundEntryViewModel
    {
        public string UserName;
        public string TopUserRole;
        public RoundEntry RoundEntryCreated = new RoundEntry();
    }
}