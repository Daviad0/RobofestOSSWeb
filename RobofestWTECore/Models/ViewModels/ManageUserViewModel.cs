using RobofestWTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobofestWTECore.Models.ViewModels
{
    public class ManageUserViewModel
    {
        public List<UserListModel> roleSpecificUsers = new List<UserListModel>();
        public List<UserNameViewModel> nonUsers = new List<UserNameViewModel>();
        public bool roleSpecificPage;
    }
}
