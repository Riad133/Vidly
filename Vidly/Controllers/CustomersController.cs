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
        public ActionResult Index()
        {
            var customers = GetData();
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
           var customer = GetData().FirstOrDefault(x => x.Id == id);
            return View(customer);
        }

        private List<Customer> GetData()
        {
            var customers = new List<Customer>
            {
                new Customer{Id = 1, Name = "Customer 1"},
                new Customer{Id = 2, Name = "Customer 2"}
            };
            return customers;
        }
    }
}