using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Siam" };
            //return View(movie); //return ViewResult
            //return Content("Hello World!"); //return ContentResult
            //return HttpNotFound(); //return HttpNotFoundResult
            //return new EmptyResult(); //return EmptyResult
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });//return redirectTo another action
        }
        
        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }
        public ActionResult Index(int? index,string sortBy) {
            if (!index.HasValue)
            {
                index = 1;
            }
            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "name";
            }
            return Content(String.Format("PageIndex={0}&SortBy={1}", index, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
    }
}