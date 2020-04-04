using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.Dtos
{
    public class CustomerDto
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter your name.")]
        [StringLength(255)]
        public string name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        [DataType(DataType.Date)]
        [Min18YearsIfAMember]
        public Nullable<DateTime> birthdate { get; set; }
        public byte membershipTypeId { get; set; }
    }
}