using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class SetupPageModel
    {
        public bool SetupCompleted;
        public List<PresetAccount> Accounts = new List<PresetAccount>();
    }
}