using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Dtos
{
    public class MovieDto
    {
        public int id { get; set; }
        [StringLength(255)]
        [Required]
        public string name { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
        [Range(1, 20)]
        [Required]
        public int NoInStock { get; set; }
        [Required]
        public GenreDto genre { get; set; }
        public byte genreId { get; set; }
    }
}