using RobofestWTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models.ViewModels
{
    public class TeamMatchDataModel
    {
        public List<TeamMatch> Matches = new List<TeamMatch>();
        public int NumFields;
    }
}
