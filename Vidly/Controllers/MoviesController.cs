using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        
        public ActionResult Edit(int movieid)
        {
            return Content("Edit" + movieid);
        }
        [Route("Movies/releaseDate/{year:regex(\\d{4}):range(1930,2100)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int? year, int? month)
        {
            return Content("Year " + year + " month " + month);
        }

        public ActionResult Random()
        {
             Movie movie =new Movie{Name = "Srink"};
            
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var ViewModel = new RandomMovieViewModel {Movie = movie, Customers = customers};
          return  View(ViewModel);
        }

        public ActionResult Index()
        {
            var movies = Getdata();
            return View(movies);
        }

        private List<Movie> Getdata()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Lord of the kings"},
                new Movie {Id = 2, Name = "Srinks"}
            };
            return movies;
        }
    }
}