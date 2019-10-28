using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Vidly2.Models
{
    public class MembershipType
    {

        public int MembershipTypeId { get; set; }

        [Display(Name = "Membership Type")]
        public string MembershipTypeName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        
    }
}