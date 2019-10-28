using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly1.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext dbContext;

        public CustomersController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Customers
        [HttpGet]
        public ActionResult Index()
        {
            var customers = dbContext.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customer customer = dbContext.Customers.Find(id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

    }
}
