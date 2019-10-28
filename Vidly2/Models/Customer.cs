using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vidly2.Models;

namespace Vidly2.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(99, MinimumLength = 1)]
        public string CustomerName { get; set; }
        public bool IsSubscribed { get; set; }

     //
        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }


     //  navigations properties

            //public int MovieId { get; set; }
            //public Movie M { get; set; }

            //public List<Movie> Movies { get; set; }
    }
}