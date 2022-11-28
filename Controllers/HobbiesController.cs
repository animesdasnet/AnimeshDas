using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animesh.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: Hobbies
        public ActionResult Hobbies()
        {
            ViewBag.Hobbies = "Playing Guitar";
            return View();
        }
    }
}