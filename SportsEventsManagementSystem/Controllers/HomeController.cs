using SportsEventsManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEventsManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private SEMSContext db = new SEMSContext();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                Session.Add("Username", user.Username);
                Session.Add("Role", user.Role);
                Session.Add("Name", user.Name);
                Session.Add("Surname", user.Surname);
                Session.Add("User", user.Id);
                ViewBag.Message = "Anasayfa";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı..";
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("Username");
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Message = "Kayıt Ol";

            return View();
        }

        [HttpPost]
        public ActionResult Register(User model)
        {
            User user = new User();
            user.Username = model.Username;
            user.Email = model.Email;
            user.Password = model.Password;
            user.Name = model.Name;
            user.Surname = model.Surname;

            db.Users.Add(user);
            db.SaveChanges();

            ViewBag.Message = "Kayıt başarılı.";

            return View();
        }

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(string username, string email)
        {
            var user = db.Users.Where(u => u.Username == username && u.Email == email).FirstOrDefault();
            if (user != null)
            {
                ViewBag.Message = "Giriş bilgileriniz için mail gönderildi..";
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "Kullanıcı adı veya email hatalı..";
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddPlayer()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult AddPlayer(Player model)
        {
            if (Session["Username"] != null)
            {
                Player player = new Player();
                player.Name = model.Name;
                player.Surname = model.Surname;
                player.UniformNumber = model.UniformNumber;
                player.Nationality = model.Nationality;
                player.DateofBirth = model.DateofBirth;
                player.Team = model.Team;

                db.Players.Add(player);
                db.SaveChanges();

                ViewBag.Message = "Kayıt başarılı.";

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult AddReferee()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult AddReferee(Referee model)
        {
            if (Session["Username"] != null)
            {
                Referee referee = new Referee();
                referee.Name = model.Name;
                referee.Surname = model.Surname;
                referee.Nationality = model.Nationality;
                referee.DateofBirth = model.DateofBirth;
                referee.MissionField = model.MissionField;

                db.Referees.Add(referee);
                db.SaveChanges();

                ViewBag.Message = "Kayıt başarılı.";

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult AddCompetition()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult AddCompetition(Competition model)
        {
            if (Session["Username"] != null)
            {
                Competition competition = new Competition();
                competition.Home = model.Home;
                competition.Away = model.Away;
                competition.Referee = model.Referee;
                competition.Date = model.Date;
                competition.Time = model.Time;
                competition.Type = model.Type;

                db.Competitions.Add(competition);
                db.SaveChanges();

                ViewBag.Message = "Kayıt başarılı.";

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult AddScore()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult AddScore(Score model)
        {
            if (Session["Username"] != null)
            {
                Score score = new Score();
                score.CompId = model.CompId;
                score.Home = model.Home;
                score.Away = model.Away;
                score.HomeScore = model.HomeScore;
                score.AwayScore = model.AwayScore;
                score.CompType = model.CompType;

                db.Scores.Add(score);
                db.SaveChanges();

                ViewBag.Message = "Kayıt başarılı.";

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult DeletePlayer(int id)
        {
            if (Session["Username"] != null)
            {
                Player player = db.Players.Where(p => p.Id == id).FirstOrDefault();
                db.Players.Remove(player);
                db.SaveChanges();
                return RedirectToAction("PlayerList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult DeleteReferee(int id)
        {
            if (Session["Username"] != null)
            {
                Referee referee = db.Referees.Where(r => r.Id == id).FirstOrDefault();
                db.Referees.Remove(referee);
                db.SaveChanges();
                return RedirectToAction("RefereeList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult DeleteCompetition(int id)
        {
            if (Session["Username"] != null)
            {
                Competition competition = db.Competitions.Where(c => c.Id == id).FirstOrDefault();
                db.Competitions.Remove(competition);
                db.SaveChanges();
                return RedirectToAction("CompetitionList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult DeleteScore(int id)
        {
            if (Session["Username"] != null)
            {
                Score score = db.Scores.Where(s => s.Id == id).FirstOrDefault();
                db.Scores.Remove(score);
                db.SaveChanges();
                return RedirectToAction("ScoreList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult UpdatePlayer(int id)
        {
            Player player = db.Players.Find(id);
            return View("UpdatePlayer", player);
        }

        [HttpPost]
        public ActionResult UpdatePlayer(Player model)
        {
            if (Session["Username"] != null)
            {
                Player player = db.Players.Find(model.Id);
                player.Name = model.Name;
                player.Surname = model.Surname;
                player.UniformNumber = model.UniformNumber;
                player.Nationality = model.Nationality;
                player.DateofBirth = model.DateofBirth;
                player.Team = model.Team;
                db.SaveChanges();

                ViewBag.Message = "Güncelleme başarılı.";

                return RedirectToAction("PlayerList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult UpdateReferee(int id)
        {
            Referee referee = db.Referees.Find(id);
            return View("UpdateReferee", referee);
        }

        [HttpPost]
        public ActionResult UpdateReferee(Referee model)
        {
            if (Session["Username"] != null)
            {
                Referee referee = db.Referees.Find(model.Id);
                referee.Name = model.Name;
                referee.Surname = model.Surname;
                referee.Nationality = model.Nationality;
                referee.DateofBirth = model.DateofBirth;
                referee.MissionField = model.MissionField;
                db.SaveChanges();

                ViewBag.Message = "Güncelleme başarılı.";

                return RedirectToAction("RefereeList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult UpdateCompetition(int id)
        {
            Competition competition = db.Competitions.Find(id);
            return View("UpdateCompetition", competition);
        }

        [HttpPost]
        public ActionResult UpdateCompetition(Competition model)
        {
            if (Session["Username"] != null)
            {
                Competition competition = db.Competitions.Find(model.Id);
                competition.Home = model.Home;
                competition.Away = model.Away;
                competition.Referee = model.Referee;
                competition.Date = model.Date;
                competition.Time = model.Time;
                competition.Type = model.Type;
                db.SaveChanges();

                ViewBag.Message = "Güncelleme başarılı.";

                return RedirectToAction("CompetitionList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult UpdateScore(int id)
        {
            Score score = db.Scores.Find(id);
            return View("UpdateScore", score);
        }

        [HttpPost]
        public ActionResult UpdateScore(Score model)
        {
            if (Session["Username"] != null)
            {
                Score score = db.Scores.Find(model.Id);
                score.CompId = model.CompId;
                score.Home = model.Home;
                score.Away = model.Away;
                score.HomeScore = model.HomeScore;
                score.AwayScore = model.AwayScore;
                score.CompType = model.CompType;
                db.SaveChanges();

                ViewBag.Message = "Güncelleme başarılı.";

                return RedirectToAction("ScoreList");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Index()
        {
            if (Session["Username"] != null)
            {
                ViewBag.UserCount = db.Users.Count();
                ViewBag.CompCount = db.Competitions.Count();
                ViewBag.PlayerCount = db.Players.Count();
                ViewBag.RefereeCount = db.Referees.Count();
                ViewBag.YoungPlayer = db.Players.OrderByDescending(p => p.DateofBirth).Take(5).ToList();
                ViewBag.Comp = db.Competitions.OrderBy(p => p.Date).Take(5).ToList();
                ViewBag.Message = "Anasayfa";

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult PlayerList()
        {
            if (Session["Username"] != null)
            {
                var players = db.Players.ToList();
                ViewBag.Message = "Oyuncular";

                return View(players);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult CompetitionList()
        {
            if (Session["Username"] != null)
            {
                var competitions = db.Competitions.ToList();
                ViewBag.Message = "Müsabakalar";

                return View(competitions);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult RefereeList()
        {
            if (Session["Username"] != null)
            {
                var referees = db.Referees.ToList();
                ViewBag.Message = "Hakemler";

                return View(referees);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult ScoreList()
        {
            if (Session["Username"] != null)
            {
                var scores = db.Scores.ToList();
                ViewBag.Message = "Sonuçlar";

                return View(scores);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpGet]
        public ActionResult Profil()
        {
            if (Session["Username"] != null)
            {
                User user = db.Users.Find(Session["User"]);
                ViewBag.Message = "Profil";

                return View(user);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult UpdateUserPassword(string password)
        {
            if (Session["Username"] != null)
            {
                User user = db.Users.Find(Session["User"]);
                user.Password = password;
                db.SaveChanges();

                ViewBag.Message = "Güncelleme başarılı.";

                return RedirectToAction("Profil");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult UpdateUser(User model)
        {
            if (Session["Username"] != null)
            {
                User user = db.Users.Find(Session["User"]);
                user.Username= model.Username;
                user.Email = model.Email;
                user.Name = model.Name;
                user.Surname = model.Surname;
                db.SaveChanges();

                ViewBag.Message = "Güncelleme başarılı.";

                return RedirectToAction("Profil");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}