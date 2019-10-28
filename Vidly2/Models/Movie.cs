using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vidly2.Models;

namespace Vidly2.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        //
        //public List<Customer> Customers { get; set; }

    }
}