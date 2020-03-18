using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType membershipType { get; set; }
        public bool membershipTypeId { get; set; }
    }
}