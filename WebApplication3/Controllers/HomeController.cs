using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoopThroughAListInMvcView.Models;

namespace LoopThroughAListInMvcView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Conference acc = new Conference()
            {
                schools = new List<School>()
            };

            acc.schools.Add(new School() { UniversityName = "Louisville", Mascot = "Cardinals" });
            acc.schools.Add(new School() { UniversityName = "Clemson", Mascot = "Tigers" });
            acc.schools.Add(new School() { UniversityName = "Virginia", Mascot = "Hoos" });

            

            return View(acc);
        }
    }
}