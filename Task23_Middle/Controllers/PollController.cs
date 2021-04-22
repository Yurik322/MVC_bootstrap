using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task23_Middle.Controllers
{
    public class PollController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string[] genres, string wantback = "Not choose")
        {
            ViewBag.Name = name;
            if (genres is null)
            {
                genres = new string[] { "No choose" };
                ViewBag.Genres = genres;
            }
            else
            {
                ViewBag.Genres = genres;
            }
            ViewBag.Back = wantback;
            return View("PollResult");
        }
    }
}