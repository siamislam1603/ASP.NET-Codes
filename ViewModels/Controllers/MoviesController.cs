using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.Models;
using ViewModels.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;

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
            var list = context.Movies.Include(c=>c.genre).ToList();
            var viewModel = new RandomMovieViewModel
            {
                movie = list
            };
            return View(viewModel);
        }
        public ActionResult CustomersList()
        {
            var list = context.Customers.Include(c => c.membershipType).ToList();
            var viewModel = new RandomMovieViewModel
            {
                customers = list
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var customer = context.Customers.Include(c => c.membershipType).SingleOrDefault(c => c.id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public ActionResult MovieDetails(int id)
        {
            var movie = context.Movies.Include(c => c.genre).SingleOrDefault(c => c.id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ActionResult MoviesForm() {
            var genre = context.Genres.ToList();
            var viewModel = new MoviesFormViewModel
            {
                movie=new Movie
                {
                    id=0,
                    ReleaseDate=DateTime.Now,
                    NoInStock=0
                },
                genre=genre
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult SaveMovie(Movie movie) {
            if (!ModelState.IsValid)
            {
                var viewModel = new MoviesFormViewModel
                {
                    movie = movie,
                    genre = context.Genres.ToList()
                };
                return View("MoviesForm", viewModel);
            }
            if (movie.id == 0)
            {
                movie.AddedDate = DateTime.Now;
                context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = context.Movies.Single(m => m.id == movie.id);
                movieInDb.name = movie.name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NoInStock = movie.NoInStock;
                movieInDb.genreId = movie.genreId;
            }
            context.SaveChanges();
            return RedirectToAction("MoviesList","Movies");
        }
        public ActionResult EditMovieInfo(int id)
        {
            var movie = context.Movies.SingleOrDefault(m => m.id == id);
            var viewModel = new MoviesFormViewModel
            {
                movie=movie,
                genre=context.Genres.ToList()
            };
            return View("MoviesForm",viewModel);
        }

        public ActionResult CustomerForm() {
            var membershipType = context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                customer=new Customer(),
                membershiptype=membershipType
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(CustomerFormViewModel newCustomer) {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    customer = newCustomer.customer,
                    membershiptype = context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if(newCustomer.customer.id==0)
                context.Customers.Add(newCustomer.customer);
            else
            {
                var customerInDb = context.Customers.Single(c => c.id == newCustomer.customer.id);
                customerInDb.name = newCustomer.customer.name;
                customerInDb.birthdate = newCustomer.customer.birthdate;
                customerInDb.membershipTypeId = newCustomer.customer.membershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = newCustomer.customer.IsSubscribedToNewsLetter;
            }
            context.SaveChanges();
            return RedirectToAction("CustomersList", "Movies");
        }
        public ActionResult EditCustomerInfo(int id) {
            var customer = context.Customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                customer = customer,
                membershiptype = context.MembershipTypes.ToList()
            };
            return View("CustomerForm",viewModel);
        }
    }
}