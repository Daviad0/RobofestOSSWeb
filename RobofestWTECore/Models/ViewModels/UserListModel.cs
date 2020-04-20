using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobofestWTE.Models
{
    public class UserListModel
    {
        public string UserName;
        public string UserID;
        public List<String> Roles = new List<String>();
    }
}