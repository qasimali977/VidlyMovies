using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMovies.Models;
using VidlyMovies.ViewModels;

namespace VidlyMovies.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movies/Random

        public ActionResult Random()
        {
            var movies = new Movies() { Name = "Shrek...!" };

            var customers = new List<Customers>
            {
                new Customers { Name = "Customers 1"},
                new Customers { Name = "Customers 2"},
                new Customers { Name = "Customers 3"},
                new Customers { Name = "Customers 4"},
                new Customers { Name = "Customers 5"}
            
            };

            var ViewModel = new RandomMoviesViewModels
            {
                Movies = movies,
                Customers = customers
            };

            return View(ViewModel);
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name"  });
            //return Content("Qasim");
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        //movies

        public ActionResult Pages(int? PageIndex, string SortBy)
        {
            if (!PageIndex.HasValue)
            {
                PageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(SortBy))
            {
                SortBy = "Name";
            }
            return Content(String.Format("PageIndex = {0} and SortBy = {1} ", PageIndex, SortBy));
        }


        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate( int year, int month)
        {
            return Content( year +"/"+ month );
        }
    }
}