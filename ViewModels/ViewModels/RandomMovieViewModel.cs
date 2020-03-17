using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}