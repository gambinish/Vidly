using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET REQUESTS
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movie/all")]
        public ActionResult MovieList()
        {
            var movieList = new List<Movie>
            {
                new Movie() {Name = "The Fellowship of the Ring"},
                new Movie() {Name = "The Two Towers"}

            };
            var viewModel = new MovieViewModel
            {
                Movie = movieList
            };
            return View(viewModel);
        }
    }
}