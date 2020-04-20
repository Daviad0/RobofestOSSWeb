using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class JudgeIndexPageModel
    {
        public Competition Competition = new Competition();
        public List<CompField> Fields = new List<CompField>();
        public int FieldAmount;
    }
}