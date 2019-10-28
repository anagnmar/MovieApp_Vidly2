using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext dbContext;

        public MoviesController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movies = dbContext.Movies.ToList();

            return View(movies);
        }

        // GET: Players/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            Movie movie = dbContext.Movies.Find(id);
            //
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(movie);
        }

    }
}
