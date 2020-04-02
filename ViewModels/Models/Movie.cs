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
        [Display(Name ="Name")]
        [StringLength(255)]
        [Required]
        public string name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Released Date")]
        public DateTime ReleaseDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
        [Display(Name = "Number In Stock")]
        [Range(1,20)]
        [Required]
        public int NoInStock { get; set; }
        public Genre genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte genreId { get; set; }
    }
}