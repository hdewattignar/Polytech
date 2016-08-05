using firstMVC.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstMVC.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome

        public Holiday CurrentHoliday {get;set;}
        

        public ActionResult Index()
        {
            Holiday christmas = new Holiday("christmas", new DateTime(2015, 12, 25), "christmas.jpg");
            Holiday easter = new Holiday("easter", new DateTime(2015, 04, 16), "easter.jpg");
            Holiday halloween = new Holiday("halloween", new DateTime(2015, 10, 31), "halloween.jpg");

            Holiday[] holidays = new Holiday[] { christmas, easter, halloween };
            Random rnd = new Random();
            CurrentHoliday = holidays[rnd.Next(3)];
            return View(CurrentHoliday);
        }
        
        public string getDaysUntill()
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan daysTil = CurrentHoliday.Date - currentDate;
            return Convert.ToString(daysTil.Days);
        }
    }
}