﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> membershiptype { get; set; }
        public Customer customer { get; set; }
    }
}