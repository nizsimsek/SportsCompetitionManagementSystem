using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEventsManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Message = "Giriş Yap";

            return View();
        }

        public ActionResult LogOut()
        {
            Session.RemoveAll();
            return View(Login());
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Anasayfa";

            return View();
        }
        public ActionResult PlayerList()
        {
            ViewBag.Message = "Oyuncular";

            return View();
        }

        public ActionResult CompetitionList()
        {
            ViewBag.Message = "Müsabakalar";

            return View();
        }

        public ActionResult RefereeList()
        {
            ViewBag.Message = "Hakemler";

            return View();
        }

        public ActionResult Profil()
        {
            ViewBag.Message = "Profil";

            return View();
        }
    }
}