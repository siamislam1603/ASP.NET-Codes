using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class Genre
    {
        public byte id { get; set; }
        public string genre { get; set; }
    }
}