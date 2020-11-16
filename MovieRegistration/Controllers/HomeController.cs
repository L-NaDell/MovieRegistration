using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class HomeController : Controller
    {
        private static List<Movie> _movies = GetMovies();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Register(Movie newMovie)
        {
            _movies.Add(newMovie);

            return View("Submitted", newMovie);
        }

        public IActionResult MovieList()
        {
            return View(_movies);
        }
        public IActionResult Search()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(1, "Avatar", 2005, "Aang", "Katara", new List<string>{"Comedy", "Drama", "Animation"}),
                new Movie(2, "Ocean's Eleven", 2010, "Brad Pitt", "George Clooney", new List<string>{ "Drama", "Action"}),
                new Movie(3, "Easy A", 2015, "Emma Stone", "Will Gluck", new List<string>{"Comedy", "Drama"}),
                new Movie(4, "Spiderman", 1908, "Peter Parker", "Aunt May", new List<string>{"Comedy", "Animation"}),
                new Movie(5, "Coneheads", 1985, "MyGirl Guy", "SNL", new List<string>{"Comedy", "Drama"}),
                new Movie(6, "Scary Movie", 1998, "Snoop", "D-o-double-g", new List<string>{"Comedy", "Drama", "Horror"}),
                new Movie(7, "Waiting", 1989, "Rob Benadict", "Deadpool", new List<string>{"Comedy", "Drama"}),
                new Movie(8, "V for Vendetta", 2011, "Nat Port", "V", new List<string>{"Drama", "Action"}),
                new Movie(9, "Indiana Jones", 1976, "Harrison Ford", "Tom Holland", new List<string>{"Comedy", "Drama", "Action"}),
                new Movie(10, "Moneyball", 1945, "Johna Hill", "Brad Pitt", new List<string>{"Comedy", "Drama"}),
            };
        }
    }
}
