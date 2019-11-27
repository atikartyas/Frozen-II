using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using utproject.Models;

namespace utproject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movie/random
        public ActionResult random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
    }
}