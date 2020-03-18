using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        public short signUpFee { get; set; }
        public short durationInMonths { get; set; }
        public short discountRate { get; set; }
    }
}