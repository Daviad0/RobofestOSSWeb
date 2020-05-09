using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RobofestWTE.Models;
using RobofestWTECore.Data;
using RobofestWTECore.Models;
using RobofestWTECore.Models.ViewModels;
using Serilog;

namespace RobofestWTECore.Controllers
{
    public class TeamController : Controller
    {
        private readonly GameContext db;
        //private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext context;
        private readonly IHubContext<ScoreHub> _hubContext;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;
        private readonly ILogger<TeamController> _logger;

        public TeamController(/*Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,*/ ApplicationDbContext context, GameContext db, IHubContext<ScoreHub> hubContext, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager2, ILogger<TeamController> logger)
        {
            //this.userManager = userManager;
            this.context = context;
            this.db = db;
            _hubContext = hubContext;
            userManager = userManager2;
            _logger = logger;
        }


        public void UpdateTopTen()
        {
            List<PresentationScoreboardModel> Scoreboard = new List<PresentationScoreboardModel>();
            foreach (var t in db.StudentTeams.Where(a => a.CompID == 1).OrderByDescending(a => a.RoundEntries.Where(b => b.Usable == true).Average(b => b.Score)).ThenBy(a => a.TeamNumberBranch).ThenBy(a => a.TeamNumberSpecific))
            {
                var AverageScore = 0;
                var AddedScore = 0;
                foreach (var r in db.RoundEntries.Where(a => a.TeamID == t.TeamID).Where(a => a.Usable == true))
                {
                    AddedScore++;
                    AverageScore = AverageScore + r.Score;
                }
                if (AddedScore != 0)
                {
                    AverageScore = AverageScore / 2;
                }

                var PresentationScoreboardModel = new PresentationScoreboardModel();
                if (AverageScore != 0)
                {
                    PresentationScoreboardModel.TeamID = t.TeamID;
                    PresentationScoreboardModel.TeamName = t.TeamName;
                    PresentationScoreboardModel.TeamNumberBranch = t.TeamNumberBranch;
                    PresentationScoreboardModel.TeamNumberSpecific = t.TeamNumberSpecific;
                    PresentationScoreboardModel.Average = AverageScore;
                    Scoreboard.Add(PresentationScoreboardModel);
                }

            }
            Scoreboard = Scoreboard.OrderByDescending(p => p.Average).Take(10).ToList();

            this._hubContext.Clients.All.SendAsync("changeTeamScores", Scoreboard);
        }

        public void StartTimer()
        {
            this._hubContext.Clients.All.SendAsync("changeGlobalTimer",2, 0);
        }

        public void UpdateScoresheet()
        {
            List<TeamDataModel> TeamDataModels = new List<TeamDataModel>();
            foreach (var t in db.StudentTeams.Where(a => a.CompID == 1).OrderByDescending(a => a.RoundEntries.Where(b => b.Usable == true).Average(b => b.Score)).ThenBy(a => a.TeamNumberBranch).ThenBy(a => a.TeamNumberSpecific))
            {
                TeamDataModel Data = new TeamDataModel();
                Data.TeamID = t.TeamID;
                Data.TeamName = t.TeamName;
                Data.TeamNumberBranch = t.TeamNumberBranch;
                Data.TeamNumberSpecific = t.TeamNumberSpecific;
                var Round1 = (from a in db.RoundEntries where a.TeamID == t.TeamID && a.Usable == true && a.Round == 1 select a).FirstOrDefault();
                if (Round1 != null)
                {
                    Data.Round1Score = Round1.Score;
                    Data.Round1Time = Round1.Time;
                }
                var Round2 = (from a in db.RoundEntries where a.TeamID == t.TeamID && a.Usable == true && a.Round == 2 select a).FirstOrDefault();
                if (Round2 != null)
                {
                    Data.Round2Score = Round2.Score;
                    Data.Round2Time = Round2.Time;
                }

                Data.RoundAverage = Data.Round1Score + Data.Round2Score;
                Data.RoundAverage = Data.RoundAverage / 2;
                Data.ReadyR1 = true;
                Data.ReadyR2 = true;
                TeamDataModels.Add(Data);


            }

            TeamDataModels = TeamDataModels.OrderByDescending(p => p.RoundAverage).ThenBy(p => p.TeamID).ToList();
            this._hubContext.Clients.All.SendAsync("changeScoreboard", TeamDataModels);

        }
        public ActionResult Presentation(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var PresentationViewModel = new PresentationViewModel();
            PresentationViewModel.CompData = (from a in db.Competitions where a.CompID == id select a).FirstOrDefault();
            int i = 0;
            foreach (var t in db.StudentTeams.Where(a => a.CompID == id))
            {
                var AverageScore = 0;
                var Round1Score = (from r in db.RoundEntries where r.TeamID == t.TeamID && r.Round == 1 select r).FirstOrDefault();
                var Round2Score = (from r in db.RoundEntries where r.TeamID == t.TeamID && r.Round == 2 select r).FirstOrDefault();
                if (Round1Score != null)
                {
                    AverageScore += Round1Score.Score;
                }
                if (Round2Score != null)
                {
                    AverageScore += Round2Score.Score;
                }
                if (Round1Score != null || Round2Score != null)
                {
                    AverageScore = AverageScore / 2;
                }

                var PresentationScoreboardModel = new PresentationScoreboardModel();
                if (Round1Score != null || Round2Score != null)
                {
                    PresentationScoreboardModel.TeamID = t.TeamID;
                    PresentationScoreboardModel.TeamName = t.TeamName;
                    PresentationScoreboardModel.TeamNumberBranch = t.TeamNumberBranch;
                    PresentationScoreboardModel.TeamNumberSpecific = t.TeamNumberSpecific;
                    PresentationScoreboardModel.Average = AverageScore;
                    PresentationViewModel.Scoreboard.Add(PresentationScoreboardModel);
                }

            }
            int c = 0;
            foreach (var count in db.StudentTeams.Where(a => a.CompID == id))
            {
                c++;
            }
            PresentationViewModel.TeamCount = c;
            PresentationViewModel.Scoreboard = PresentationViewModel.Scoreboard.OrderByDescending(s => s.Average).ToList();
            return View(PresentationViewModel);
        }

        public ActionResult IsNotAuthenticated()
        {
            return View();
        }
        // GET: Entry
        public async Task<ActionResult> ManageUsers()
        {
            if (User.IsInRole("Admin") || User.IsInRole("Main") || User.IsInRole("Tech"))
            {
                var Userlist = new List<UserListModel>();
                var users = await context.Users.ToListAsync();
                foreach (var user in users)
                {
                    var listitem = new UserListModel();
                    if (await userManager.IsInRoleAsync(user, "Judge"))
                    {
                        listitem.Roles.Add("Judge");
                        if (await userManager.IsInRoleAsync(user, "Field1"))
                        {
                            listitem.Roles.Add("Field1");
                        }
                        if (await userManager.IsInRoleAsync(user, "Field2"))
                        {
                            listitem.Roles.Add("Field2");
                        }
                        if (await userManager.IsInRoleAsync(user, "Field3"))
                        {
                            listitem.Roles.Add("Field3");
                        }
                        if (await userManager.IsInRoleAsync(user, "Field4"))
                        {
                            listitem.Roles.Add("Field4");
                        }
                        if (await userManager.IsInRoleAsync(user, "Field5"))
                        {
                            listitem.Roles.Add("Field5");
                        }
                        if (await userManager.IsInRoleAsync(user, "Field6"))
                        {
                            listitem.Roles.Add("Field6");
                        }
                        if (await userManager.IsInRoleAsync(user, "AllFields"))
                        {
                            listitem.Roles.Add("AllFields");
                        }
                    }
                    if (await userManager.IsInRoleAsync(user, "Admin"))
                    {
                        listitem.Roles.Add("Admin");
                    }
                    if (await userManager.IsInRoleAsync(user, "FieldStaff"))
                    {
                        listitem.Roles.Add("FieldStaff");
                    }
                    if (await userManager.IsInRoleAsync(user, "Manager"))
                    {
                        listitem.Roles.Add("Manager");
                    }
                    if (await userManager.IsInRoleAsync(user, "Main"))
                    {
                        listitem.Roles.Add("Main");
                    }
                    if (await userManager.IsInRoleAsync(user, "Tech"))
                    {
                        listitem.Roles.Add("Tech");
                    }
                    if (await userManager.IsInRoleAsync(user, "Locked"))
                    {
                        listitem.Roles.Add("Locked");
                    }
                    listitem.UserID = user.Id;
                    listitem.UserName = user.UserName;
                    Userlist.Add(listitem);
                }
                //users = userManager.Users.Where(u => u.Roles)
                return View(Userlist);
            }
            else
            {
                return View("IsNotAuthenticated");
            }
            

        }
        public ActionResult Index(int id)
        {


                var TeamDataModelList = new List<TeamDataModel>();
                int i = 0;
                foreach (var s in db.StudentTeams.Where(x => x.CompID == id).ToList())
                {
                    i++;
                    var TeamData = db.StudentTeams.Find(s.TeamID);
                    var Round1 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 1 select a).FirstOrDefault();
                    var Round2 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 2 select a).FirstOrDefault();
                    var TeamDataModel = new TeamDataModel();
                    TeamDataModel.TeamName = TeamData.TeamName;
                    TeamDataModel.TeamID = TeamData.TeamID;
                    TeamDataModel.TeamNumberBranch = TeamData.TeamNumberBranch;
                    TeamDataModel.TeamNumberSpecific = TeamData.TeamNumberSpecific;

                    if (Round2 != null && Round1 != null)
                    {
                        TeamDataModel.Round1Score = Round1.Score;
                        TeamDataModel.Round2Score = Round2.Score;
                        TeamDataModel.RoundAverage = (Round1.Score + Round2.Score) / 2;
                    }
                    else if (Round2 != null && Round1 == null)
                    {
                        //Round 1 is null
                        TeamDataModel.Round1Score = 0;
                        TeamDataModel.Round2Score = Round2.Score;
                        TeamDataModel.RoundAverage = Round2.Score / 2;
                    }
                    else if (Round2 == null && Round1 != null)
                    {
                        //Round 2 is null
                        TeamDataModel.Round1Score = Round1.Score;
                        TeamDataModel.Round2Score = 0;
                        TeamDataModel.RoundAverage = Round1.Score / 2;
                    }
                    else if (Round2 == null && Round1 == null)
                    {
                        //Round 2 is null
                        TeamDataModel.Round1Score = 0;
                        TeamDataModel.Round2Score = 0;
                        TeamDataModel.RoundAverage = 0;
                    }

                    TeamDataModelList.Add(TeamDataModel);
                }
                return View(TeamDataModelList.OrderByDescending(a => a.RoundAverage));



        }
        public ActionResult MatchManager(int id)
        {
                var MatchDataModel = new MatchDataModel();
                var Competition = (from a in db.Competitions where a.CompID == id select a).FirstOrDefault();
                MatchDataModel.RunningFields = Competition.RunningFields;
                int i = 0;
                foreach (var s in db.StudentTeams.Where(x => x.CompID == id).ToList())
                {
                    var StudentTeam = new StudentTeam();
                    i++;
                    var TeamData = db.StudentTeams.Find(s.TeamID);
                    StudentTeam.TeamName = TeamData.TeamName;
                    StudentTeam.TeamNumberBranch = TeamData.TeamNumberBranch;
                    StudentTeam.TeamNumberSpecific = TeamData.TeamNumberSpecific;
                    StudentTeam.TeamID = TeamData.TeamID;
                    StudentTeam.FieldR1 = TeamData.FieldR1;
                    StudentTeam.FieldR2 = TeamData.FieldR2;
                    MatchDataModel.R1List.Add(StudentTeam);
                    MatchDataModel.R2List.Add(StudentTeam);
                }


                return View(MatchDataModel);

        }
        public ActionResult Competition(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var CompetitionPageModel = new CompetitionPageModel();
            int i = 0;


            //COMPETITION ID CHANGES BASED ON WHATEVER IS PASSED THROUGH CONTROLLER
            //1 IS A TEST VALUE
            var Competition = (from a in db.Competitions where a.CompID == id select a).FirstOrDefault();
            CompetitionPageModel.CompID = Competition.CompID;
            CompetitionPageModel.Date = Competition.Date;
            CompetitionPageModel.Location = Competition.Location;
            CompetitionPageModel.ExtraData = Competition.ExtraData;
            CompetitionPageModel.GameID = Competition.GameID;
            CompetitionPageModel.FieldPreferred.Add(Competition.field1preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field2preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field3preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field4preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field5preferred);
            CompetitionPageModel.FieldPreferred.Add(Competition.field6preferred);
            CompetitionPageModel.validmatches[0] = Competition.validmatch1;
            CompetitionPageModel.validmatches[1] = Competition.validmatch2;
            CompetitionPageModel.validmatches[2] = Competition.validmatch3;
            CompetitionPageModel.validmatches[3] = Competition.validmatch4;
            CompetitionPageModel.validmatches[4] = Competition.validmatch5;
            CompetitionPageModel.validmatches[5] = Competition.validmatch6;
            int sitem = 0;

            foreach (var s in db.StudentTeams.Where(x => x.CompID == id).ToList())
            {
                var TeamData = db.StudentTeams.Find(s.TeamID);
                var Round1 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 1 && a.Usable == true orderby DateTime.Parse(a.TimeStamp) select a).FirstOrDefault();
                var Round2 = (from a in db.RoundEntries where a.TeamID == s.TeamID && a.Round == 2 && a.Usable == true orderby DateTime.Parse(a.TimeStamp) select a).FirstOrDefault();
                i++;

                var TeamDataModel = new TeamDataModel();
                TeamDataModel.TeamName = TeamData.TeamName;
                TeamDataModel.TeamID = TeamData.TeamID;
                TeamDataModel.TeamNumberBranch = TeamData.TeamNumberBranch;
                TeamDataModel.TeamNumberSpecific = TeamData.TeamNumberSpecific;
                TeamDataModel.Round1Score = 0;
                TeamDataModel.Round2Score = 0;
                if (Round2 != null)
                {
                    TeamDataModel.Round2Score = Round2.Score;
                }
                if (Round1 != null)
                {
                    TeamDataModel.Round1Score = Round1.Score;
                }
                TeamDataModel.RoundAverage = TeamDataModel.Round1Score + TeamDataModel.Round2Score;
                TeamDataModel.RoundAverage = TeamDataModel.RoundAverage / 2;
                CompetitionPageModel.Teams.Add(TeamDataModel);
            }

            return View(CompetitionPageModel);
        }
        public ActionResult GAME(int id)
        {
            if (User.IsInRole("Judge") || User.IsInRole("Manager"))
            {
                if (id == 0)
                {
                    //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var GamePageModel = new GamePageModel();

                //GAME ID CHANGES BASED ON WHATEVER IS PASSED THROUGH CONTROLLER
                //1 IS A TEST VALUE
                var GAME = (from a in db.GAMES where a.GameID == id select a).FirstOrDefault();
                //Count the amount of teams
                //Where function will have to change based on competition
                //Create variable "i" to count with each competition so it can find amount of teams attached to each competition
                //Attach "i" to the where function



                GamePageModel.Desc = GAME.Desc;
                GamePageModel.GameID = GAME.GameID;
                GamePageModel.Name = GAME.Name;
                foreach (var c in db.Competitions.Where(a => a.GameID == 1).ToList())
                {
                    int i = 0;
                    foreach (var s in db.StudentTeams.Where(a => a.CompID == c.CompID))
                    {
                        i++;
                    }
                    var Competition = (from a in db.Competitions where a.CompID == c.CompID select a).FirstOrDefault();
                    var CompetitionPageModel = new CompetitionPageModel();
                    CompetitionPageModel.CompID = Competition.CompID;
                    CompetitionPageModel.Date = Competition.Date;
                    CompetitionPageModel.Location = Competition.Location;
                    CompetitionPageModel.ExtraData = Competition.ExtraData;
                    CompetitionPageModel.TeamCount = i;
                    GamePageModel.Competitions.Add(CompetitionPageModel);
                }

                return View(GamePageModel);
            }
            else
            {
                return View("IsNotAuthenticated");
            }
            
        }
        // GET: Entry/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var TeamData = (from a in db.StudentTeams where a.TeamID == id select a).FirstOrDefault();
            var Round1 = (from a in db.RoundEntries where a.TeamID == id && a.Round == 1 select a).FirstOrDefault();
            var Round2 = (from a in db.RoundEntries where a.TeamID == id && a.Round == 2 select a).FirstOrDefault();
            var TeamDetailsModel = new TeamDetailsModel();
            TeamDetailsModel.TeamName = TeamData.TeamName;
            TeamDetailsModel.TeamID = TeamData.TeamID;
            TeamDetailsModel.TeamNumberBranch = TeamData.TeamNumberBranch;
            TeamDetailsModel.TeamNumberSpecific = TeamData.TeamNumberSpecific;
            TeamDetailsModel.Location = TeamData.Location;
            TeamDetailsModel.Coach = TeamData.Coach;
            TeamDetailsModel.CompID = TeamData.CompID;
            int i = 0;
            int average = 0;
            bool R1Recorded = false;
            bool R2Recorded = false;
            foreach (var round in db.RoundEntries.Where(a => a.TeamID == id && a.Round == 1).OrderBy(a => DateTime.Parse(a.TimeStamp)).ToList())
            {
                i++;
                if (round.Usable == true && R1Recorded == false)
                {
                    average = average + round.Score;
                    R1Recorded = true;
                }
                TeamDetailsModel.Round.Add(round);
            }
            foreach (var round in db.RoundEntries.Where(a => a.TeamID == id && a.Round == 2).OrderBy(a => DateTime.Parse(a.TimeStamp)).ToList())
            {
                i++;
                if (round.Usable == true && R2Recorded == false)
                {
                    average = average + round.Score;
                    R2Recorded = true;
                }
                TeamDetailsModel.Round.Add(round);
            }
            TeamDetailsModel.RoundAverage = average / 2;
            return View(TeamDetailsModel);
        }

        // GET: Entry/Create
        public ActionResult RoundCreate(int id, int compid)
        {
            var Model = new RoundEntryViewModel();
            var RoundEntry = new RoundEntry();
            var team = (from d in db.StudentTeams where d.TeamID == id select d).FirstOrDefault();
            RoundEntry.TeamID = id;
            var RoundsCompleted = (from a in db.RoundEntries where a.TeamID == id select a);
            bool R1 = false;
            bool R2 = false;
            bool Rerun = false;
            foreach (var Round in RoundsCompleted.OrderBy(a => a.Round).ToList())
            {
                if (Round.Round == 1)
                {
                    R1 = true;
                }
                else if (Round.Round == 2)
                {
                    R2 = true;
                }
            }
            if (R1 == true && R2 == true)
            {
                Rerun = true;
            }
            RoundEntry.Rerun = Rerun;
            RoundEntry.Usable = true;
            Model.RoundEntryCreated = RoundEntry;
            ViewBag.CompID = compid;
            Model.UserName = userManager.GetUserName(User);
            
            return View(RoundEntry);

        }

        public ActionResult ScoreInfo(int id)
        {
            var Round = (from a in db.RoundEntries where a.EntryID == id select a).FirstOrDefault();

            return View(Round);
        }

        public ActionResult TeamMatches(int id)
        {
            var MatchDataModel = new TeamMatchDataModel();
            MatchDataModel.NumFields = db.Competitions.Where(a => a.CompID == id).FirstOrDefault().RunningFields;
            var Matches = (from m in db.TeamMatches where m.CompID == id select m).ToList();
            MatchDataModel.Matches = Matches;
            ViewBag.CompID = id;
            return View(MatchDataModel);
        }
        public ActionResult TeamMatchesEdit(int id)
        {
            var Matches = (from m in db.TeamMatches where m.CompID == id select m).ToList();
            ViewBag.CompID = id;
            return View(Matches);
        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoundCreate([Bind("TeamID,Score,Time,Round,Data,Rerun,Usable,TimeStamp,Field,JudgeConfirmNotes,StudentInitials")] RoundEntry roundEntry)
        {
            Random random = new Random();
            roundEntry.EntryID = random.Next(1, 100000);
            roundEntry.TimeStamp = DateTime.Now.ToString();
            db.RoundEntries.Add(roundEntry);
            db.SaveChanges();

            var TeamNumberBranch = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberBranch;
            var TeamNumberSpecific = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberSpecific;
            string TeamNumber = TeamNumberBranch + "-" + TeamNumberSpecific;
            this._hubContext.Clients.All.SendAsync("initFieldView",roundEntry.Field, 3, roundEntry.Score, TeamNumber, false, false, "0/0/0/0/0^0/0/0/0^0/0^0/0");
            this._hubContext.Clients.All.SendAsync("checkThisScore",roundEntry.Field, roundEntry.Data, roundEntry.Score, roundEntry.EntryID, TeamNumber);
            string page = roundEntry.TeamID.ToString();
            page = "Details/" + page;
            return RedirectToAction(page);


        }

        public ActionResult RoundCreateBlank()
        {
                return View();

        }
        public ActionResult FieldStatus()
        {
            return View();

        }
        public ActionResult RawLeaderboard(int id)
        {
            _logger.LogInformation("Test 1");
            var ranklist = new List<ReturnRank>();
            foreach (var team in db.StudentTeams.Where(x => x.CompID == id))
            {
                var teamtoadd = new ReturnRank();
                teamtoadd.TeamNumber = team.TeamNumberBranch.ToString() + "-" + team.TeamNumberSpecific.ToString();
                var Round1 = db.RoundEntries.Where(r => r.Round == 1).Where(r => r.Usable == true).Where(r => r.TeamID == team.TeamID).FirstOrDefault();
                var Round2 = db.RoundEntries.Where(r => r.Round == 2).Where(r => r.Usable == true).Where(r => r.TeamID == team.TeamID).FirstOrDefault();
                if(Round1 == null)
                {
                    teamtoadd.Round1Score = 0;
                }
                else
                {
                    teamtoadd.Round1Score = Round1.Score;
                }
                if (Round2 == null)
                {
                    teamtoadd.Round2Score = 0;
                }
                else
                {
                    teamtoadd.Round2Score = Round2.Score;
                }
                teamtoadd.AverageScore = (teamtoadd.Round1Score + teamtoadd.Round2Score) / 2;
                ranklist.Add(teamtoadd);
            }
            _logger.LogInformation("Test 2");
            int i = 0;
            foreach(var team in ranklist.OrderByDescending(x => x.AverageScore).ThenBy(x => x.TeamNumber))
            {
                i++;
                team.Rank = i;
            }
            _logger.LogInformation("Test 3");
            ranklist = ranklist.OrderBy(x => x.Rank).ToList();
            var json = JsonConvert.SerializeObject(ranklist);
            _logger.LogInformation("Test 4");
            return Content(json);
        }
        public ActionResult RawTeamData(string TeamNumber)
        {
            var TeamNumberStrings = TeamNumber.Split("-");
            var trackteam = db.StudentTeams.Where(x => x.TeamNumberBranch.ToString() == TeamNumberStrings[0] && x.TeamNumberSpecific.ToString() == TeamNumberStrings[1]).FirstOrDefault();
            if(trackteam != null)
            {
                var modeltoreturn = new RawTeamData();
                modeltoreturn.TeamNumber = TeamNumber;
                modeltoreturn.TeamID = trackteam.TeamID;
                modeltoreturn.TeamName = trackteam.TeamName;
                modeltoreturn.Coach = trackteam.Coach;
                modeltoreturn.Location = trackteam.Location;
                var Round1 = db.RoundEntries.Where(r => r.Round == 1).Where(r => r.Usable == true).Where(r => r.TeamID == trackteam.TeamID).FirstOrDefault();
                if(Round1 != null)
                {
                    modeltoreturn.AverageScore += Round1.Score;
                }
                var Round2 = db.RoundEntries.Where(r => r.Round == 2).Where(r => r.Usable == true).Where(r => r.TeamID == trackteam.TeamID).FirstOrDefault();
                if (Round2 != null)
                {
                    modeltoreturn.AverageScore += Round2.Score;
                }
                modeltoreturn.AverageScore = modeltoreturn.AverageScore / 2;
                foreach (var round in db.RoundEntries.OrderBy(x => x.Round).Where(x => x.TeamID == trackteam.TeamID))
                {
                    var roundtoadd = new RawRound();

                    if(round != null)
                    {
                        roundtoadd.RoundNum = round.Round;
                        roundtoadd.Score = round.Score;
                        roundtoadd.Time = round.Time;
                        roundtoadd.Usable = round.Usable;
                        modeltoreturn.RoundEntries.Add(roundtoadd);
                    }
                    
                }
                var json = JsonConvert.SerializeObject(modeltoreturn);

                return Content(json);
            }
            else
            {
                return Content("Hi");
            }
            
        }
        public ActionResult RawSchedule(int id)
        {
            var schedulelist = new List<RawScheduleItem>();
            int i = 0;
            foreach(var item in db.TeamMatches.Where(x => x.CompID == id).OrderBy(x => x.MatchID).ThenBy(x => x.MatchID))
            {
                i++;
                var scheduleitem = new RawScheduleItem();
                scheduleitem.Completed = item.Completed;
                scheduleitem.TeamNumber = item.TeamNumber;
                if(item.TeamNumber.ToLower() == "empty")
                {
                    scheduleitem.Valid = false;
                }
                else
                {
                    var TeamNumString = item.TeamNumber.Split("-");
                    var FindTeam = db.StudentTeams.Where(x => x.TeamNumberBranch.ToString() == TeamNumString[0] && x.TeamNumberSpecific.ToString() == TeamNumString[1]).FirstOrDefault();
                    if(FindTeam == null)
                    {
                        scheduleitem.Valid = false;
                    }
                    else
                    {
                        scheduleitem.Valid = true;
                    }
                }
                scheduleitem.OrderNum = i;
                scheduleitem.Round = item.RoundNum;
                scheduleitem.TestMatch = item.Test;
                schedulelist.Add(scheduleitem);
            }
            var json = JsonConvert.SerializeObject(schedulelist);
            return Content(json);
        }
        public ActionResult RawCompetitions()
        {
            var CompetitionList = new List<CompetitionPassModel>();
            var CompDBList = db.Competitions.OrderBy(x => x.Date).ToList();
            foreach(var item in CompDBList)
            {
                var comptoadd = new CompetitionPassModel();
                comptoadd.CompID = item.CompID;
                comptoadd.Date = item.Date;
                comptoadd.Location = item.Location;
                comptoadd.RunningState = item.RunningState;
                comptoadd.SetUp = true;
                
                CompetitionList.Add(comptoadd);
            }
            var json = JsonConvert.SerializeObject(CompetitionList);
            return Content(json);
        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoundCreateBlank([Bind("TeamID,Score,Time,Round,Data,Rerun,Usable,TimeStamp,Field")] RoundEntry roundEntry)
        {
                db.RoundEntries.Add(roundEntry);
                db.SaveChanges();
                this._hubContext.Clients.All.SendAsync("initFieldView",roundEntry.Field, 3);

                string page = roundEntry.TeamID.ToString();
                page = "Details/" + page;
                return RedirectToAction(page);

        }

        public ActionResult JudgeIndex(int id)
        {
            ViewBag.Message = "Your application description page.";
            var JudgeIndexPageModel = new JudgeIndexPageModel();
            foreach (var field in db.Fields.Where(f => f.CompID == id).OrderBy(f => f.FieldNumber))
            {
                JudgeIndexPageModel.Fields.Add(field);
                JudgeIndexPageModel.FieldAmount = JudgeIndexPageModel.FieldAmount + 1;
                field.CurrentTeamNumber = (from t in db.StudentTeams where t.CompID == id && t.TeamID == field.CurrentTeamID select t).FirstOrDefault().TeamNumberBranch + "-" + (from t in db.StudentTeams where t.CompID == id && t.TeamID == field.CurrentTeamID select t).FirstOrDefault().TeamNumberSpecific;
            }
            JudgeIndexPageModel.Competition = (from c in db.Competitions where c.CompID == id select c).FirstOrDefault();
            return View(JudgeIndexPageModel);
        }
        public ActionResult TimerDemo()
        {
            return View();
        }
        public ActionResult MatchKeeper(int id)
        {
            var MatchDataModel = new MatchDataModel();
            
            MatchDataModel.Competition = (from c in db.Competitions where c.CompID == id select c).FirstOrDefault();
            MatchDataModel.RunningFields = MatchDataModel.Competition.RunningFields;
            foreach (var s in db.StudentTeams.ToList())
            {
                var StudentTeam = new StudentTeam();
                var TeamData = db.StudentTeams.Find(s.TeamID);
                StudentTeam.TeamName = TeamData.TeamName;
                StudentTeam.TeamNumberBranch = TeamData.TeamNumberBranch;
                StudentTeam.TeamNumberSpecific = TeamData.TeamNumberSpecific;
                StudentTeam.TeamID = TeamData.TeamID;
                StudentTeam.FieldR1 = TeamData.FieldR1;
                StudentTeam.FieldR2 = TeamData.FieldR2;
                MatchDataModel.R1List.Add(StudentTeam);
                MatchDataModel.R2List.Add(StudentTeam);
            }
            var GetMatches = (from m in db.TeamMatches where m.CompID == id select m).ToList();
            foreach(var item in GetMatches)
            {
                MatchDataModel.Matches++;
            }
            float numofmatches = (float)MatchDataModel.Matches / (float)MatchDataModel.RunningFields;
            MatchDataModel.Matches = (int)Math.Ceiling(numofmatches);
            return View(MatchDataModel);
        }

        // GET: Entry/Edit/5*/
        public ActionResult RoundEdit(int id)
        {
                if (id == null)
                {
                    //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                RoundEntry score = db.RoundEntries.Find(id);
                if (score == null)
                {
                    //return HttpNotFound();
                }
                return View(score);

        }


        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RoundEdit([Bind("EntryID,TeamID,Score,Time,Round,Data,Rerun,Usable,TimeStamp")] RoundEntry roundEntry)
        {
                if (ModelState.IsValid)
                {
                    var TeamNumberBranch = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberBranch;
                    var TeamNumberSpecific = (from t in db.StudentTeams where t.TeamID == roundEntry.TeamID select t).FirstOrDefault().TeamNumberSpecific;
                    string TeamNumber = TeamNumberBranch + "-" + TeamNumberSpecific;
                    var PreviousField = (from r in db.RoundEntries where r.EntryID == roundEntry.EntryID select r).FirstOrDefault().Field;
                await this._hubContext.Clients.All.SendAsync("checkThisScore", PreviousField, roundEntry.Data, roundEntry.Score, roundEntry.EntryID, TeamNumber);
                RoundEntry roundEntrytoUpdate = db.RoundEntries.Where(x => x.EntryID == roundEntry.EntryID).FirstOrDefault();
                if(roundEntrytoUpdate != null)
                {
                    roundEntrytoUpdate.Field = roundEntry.Field;
                    roundEntrytoUpdate.Time = roundEntry.Time;
                    roundEntrytoUpdate.Data = roundEntry.Data;
                    roundEntrytoUpdate.Score = roundEntry.Score;
                    roundEntrytoUpdate.StudentInitials = roundEntry.StudentInitials;
                    roundEntrytoUpdate.JudgeConfirmNotes = roundEntry.JudgeConfirmNotes;
                    roundEntrytoUpdate.Round = roundEntry.Round;
                    roundEntrytoUpdate.Rerun = roundEntry.Rerun;
                    roundEntrytoUpdate.Usable = roundEntry.Usable;
                    roundEntrytoUpdate.TimeStamp = DateTime.Now.ToString();
                    db.Update(roundEntrytoUpdate);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Competition/1");
                }
            }
                return View(roundEntry);

        }

        public ActionResult TeamEdit(int id)
        {
                if (id == null)
                {
                    //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                StudentTeam score = db.StudentTeams.Find(id);
                if (score == null)
                {
                    //return HttpNotFound();
                }
                return View(score);

        }


        // POST: Entry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeamEdit([Bind("TeamID,CompID,TeamName,TeamNumberBranch,TeamNumberSpecific,Location,Coach,ReadyR1,ReadyR2")] StudentTeam studentTeam)
        {
                if (ModelState.IsValid)
                {
                    db.Entry(studentTeam).State = EntityState.Modified;
                    db.SaveChanges();
                    string page = studentTeam.CompID.ToString();
                    page = "Competition/" + page;
                    return RedirectToAction(page);
                }
                return View(studentTeam);

        }

        // GET: Entry/Create
        public ActionResult TeamCreate()
        {
                return View();

        }

        // POST: Entry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeamCreate([Bind("TeamID,CompID,TeamName,TeamNumberBranch,TeamNumberSpecific,Location,Coach,ReadyR1,ReadyR2")] StudentTeam studentTeam)
        {
            Random random = new Random();
            studentTeam.TeamID = random.Next(1, 100000);
            db.StudentTeams.Add(studentTeam);
            db.SaveChanges();
            string page = studentTeam.CompID.ToString();
            page = "Competition/" + page;
            return RedirectToAction(page);

        }
        /*
                // GET: Entry/Delete/5
                public ActionResult Delete(string id)
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    RoundEntry score = db.RoundEntries.Find(id);
                    if (score == null)
                    {
                        return HttpNotFound();
                    }
                    return View(score);
                }

                // POST: Entry/Delete/5
                [HttpPost, ActionName("Delete")]
                [ValidateAntiForgeryToken]
                public ActionResult DeleteConfirmed(string id)
                {
                    RoundEntry score = db.RoundEntries.Find(id);
                    db.RoundEntries.Remove(score);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}