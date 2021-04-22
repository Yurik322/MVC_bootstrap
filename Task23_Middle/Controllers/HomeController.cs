using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task23_Middle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime date1 = new DateTime(2021, 4, 21);
            ViewBag.News = new List<(string title, string test, DateTime date)>
            {
                ("Yurii", "Futryk", date1), ("M-L", "Andrii", date1)
            };
            return View();
        }
    }
}