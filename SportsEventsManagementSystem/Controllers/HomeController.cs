using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEventsManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username.Equals("acc1") && password.Equals("123"))
            {
                Session["Username"] = username.ToString().ToUpper();
                ViewBag.Message = "Anasayfa";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Yanlış kullanıcı adı veya şifre..";
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
        public ActionResult Register(string username, string email, string password, string name, string surname)
        {
            // TODO: Kayıt işlemleri yapılacak
            return View();
        }

        [HttpGet]
        public ActionResult UpdatePlayer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateReferee()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UpdateCompetition()
        {
            return View();
        }

        public ActionResult Index()
        {
            if (Session["Username"] != null)
            {
                ViewBag.Message = "Anasayfa";

                return View();
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult PlayerList()
        {
            if (Session["Username"] != null)
            {
                ViewBag.Message = "Oyuncular";

                return View();
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult CompetitionList()
        {
            if (Session["Username"] != null)
            {
                ViewBag.Message = "Müsabakalar";

                return View();
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult RefereeList()
        {
            if (Session["Username"] != null)
            {
                ViewBag.Message = "Hakemler";

                return View();
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult Profil()
        {
            if (Session["Username"] != null)
            {
                ViewBag.Message = "Profil";

                return View();
            }
            else
            {
                return View("Login");
            }
        }
    }
}