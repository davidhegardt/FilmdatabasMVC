using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Johan Brohan", Phone = "070771122" },
                new Customer {Id = 2, Name = "Palle Kalle", Phone = "070771123" },
                new Customer {Id = 3, Name = "Lasse Göran", Phone = "070771124" },
                new Customer {Id = 4, Name = "Brasse Lennart", Phone = "070771125" }
            };
        }
    }
}