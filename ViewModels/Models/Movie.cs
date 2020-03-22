using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
        public int NoInStock { get; set; }
        public Genre genre { get; set; }
        public byte genreId { get; set; }
    }
}