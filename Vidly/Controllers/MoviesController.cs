using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using  System.Data.Entity;
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
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //public ActionResult Edit(int movieid)
        //{
        //    return Content("Edit" + movieid);
        //}
        //[Route("Movies/releaseDate/{year:regex(\\d{4}):range(1930,2100)}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseYear(int? year, int? month)
        //{
        //    return Content("Year " + year + " month " + month);
        //}

        //public ActionResult Random()
        //{
        //     Movie movie =new Movie{Name = "Srink"};
            
        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name = "Customer 1"},
        //        new Customer {Name = "Customer 2"}
        //    };
        //    var ViewModel = new RandomMovieViewModel {Movie = movie, Customers = customers};
        //  return  View(ViewModel);
        //}

        public ActionResult Index()
        {
            var movies =_context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Detail(int? id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(x => x.Id == id);


            return View (movie);
        }

        public ActionResult New()
        {
            var geners = _context.Genres.ToList();
            var movieView = new MovieFormViewModel
            {
                Genres = geners
            };
            return View("MovieForm",movieView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.DateAdded = System.DateTime.Now;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;


                
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            if (movie ==null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList(),
                Movie = movie
            };
            return View("MovieForm", viewModel);
        }
    }
}