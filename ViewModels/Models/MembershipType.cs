using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        [Required]
        public string name { get; set; }
        public short signUpFee { get; set; }
        public short durationInMonths { get; set; }
        public short discountRate { get; set; }
        public static readonly byte Unknown = 0, PayAsGo = 1;
    }
}