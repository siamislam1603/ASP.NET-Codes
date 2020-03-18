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
        private MyDBContext context;
        // GET: Movies
        public MoviesController()
        {
            context = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        public ActionResult MoviesList()
        {
            var list = context.Movies.ToList();
            var viewModel = new RandomMovieViewModel
            {
                movie = list
            };
            return View(viewModel);
        }
        public ActionResult CustomersList()
        {
            var list = context.Customers.ToList();
            var viewModel = new RandomMovieViewModel
            {
                customers = list
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
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