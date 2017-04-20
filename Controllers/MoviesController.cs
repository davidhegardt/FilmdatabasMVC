using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //movies
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = GetMovies().SingleOrDefault(c => c.Id == id);

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Casablanca", Year = 1942, Description = "A cynical American expatriate encounters a former lover", IMDB = "http://www.imdb.com/title/tt0034583/" },
                new Movie {Id = 2, Name = "1984", Year = 1956, Description = "George Orwell's novel of a totalitarian future society", IMDB = "http://www.imdb.com/title/tt0048918/"},
                new Movie {Id = 3, Name = "Tarzan", Year = 1932, Description = "A wild man raised by apes", IMDB = "http://www.imdb.com/title/tt0023551/" },
                new Movie {Id = 4, Name = "The Stig", Year = 2003, Description = "Top Gears favorite driver", IMDB = "http://www.imdb.com/name/nm5103457/" }
            };
        }
    }
}