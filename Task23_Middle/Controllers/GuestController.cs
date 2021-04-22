using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task23_Middle.App_Start;

namespace Task23_Middle.Controllers
{
    public class GuestController : Controller
    {
        static DateTime date1 = new DateTime(2021, 4, 21);
        private List<(string name, string text, DateTime date)> myList = new List<(string name, string text, DateTime date)>
        {
            ("Futryk", "This book was very hard to read. Not that it was wordy, but in the way that the plot was confusing, but predictable. The author threw in all of the main and important facts right at the start, so it was overwhelmingly confusing. Not only that, but the plot was predictable. I won’t spoil any of it, but I could tell how it was going to turn out not very far into the book. I agree that this book should not be compared to Percy Jackson. They both involve old mythology and modern concepts, but in none of the same ways. The plot would only be interesting for a twelve year old kid, in my opinion.", date1)
        };

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Comments = myList;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string author, string comment, DateTime date)
        {
            ViewBag.author = author;
            ViewBag.comment = comment;
            ViewBag.date = date;
            myList.Add((author, comment, date));
            ViewBag.Comments = myList;
            return View("NewGuestList");
        }
    }
}