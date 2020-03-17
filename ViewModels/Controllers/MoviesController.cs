using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;
using ViewModels.ViewModels;

namespace ViewModels.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult MoviesList()
        {
            var list = new List<Movie>
            {
                new Movie{id=1,name="Avengers"},
                new Movie{id=2,name="Thor"}
            };
            var viewModel = new RandomMovieViewModel
            {
                movie=list
            };
            return View(viewModel);
        }
        public ActionResult CustomersList()
        {
            var list = new List<Customer>
            {
                new Customer{id=1,name="Customer1"},
                new Customer{id=2,name="Customer2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                customers = list
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer { id = 1, name = "Customer1" },
                new Customer { id = 2, name = "Customer2" }
            };
        }
    }
}