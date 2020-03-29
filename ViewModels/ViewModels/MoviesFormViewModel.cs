using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genre> genre { get; set; }
        public Movie movie { get; set; }
    }
}