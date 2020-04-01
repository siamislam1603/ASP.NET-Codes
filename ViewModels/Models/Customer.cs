using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Please Enter your name.")]
        [StringLength(255)]
        [Display(Name ="Name")]
        public string name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Date Of Birth")]
        public Nullable<DateTime> birthdate { get; set; }
        public MembershipType membershipType { get; set; }
        [Display(Name ="Membership Type")]
        public byte membershipTypeId { get; set; }
    }
}