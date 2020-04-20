using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RobofestWTE.Models;
using RobofestWTECore.Data;

namespace RobofestWTECore.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameContext db;

        public HomeController(GameContext db)
        {
            this.db = db;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Setup(int id)
        {
            SetupPageModel pageModel = new SetupPageModel();
            
            var Competition = (from c in db.Competitions where c.CompID == id select c).FirstOrDefault();
            pageModel.SetupCompleted = Competition.setup;
            if(Competition.setup == true)
            {
                var Accounts = (from a in db.PresetAccounts where a.CompID == id select a);
                foreach(var account in Accounts)
                {
                    pageModel.Accounts.Add(account);
                }
            }
            return View(pageModel);
        }
        public ActionResult Landing()
        {
            return View();
        }



        public ActionResult MatchManager()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}