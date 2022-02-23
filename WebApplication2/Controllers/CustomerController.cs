using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Models.ViewModel;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = dbContext.Locations.ToList();
            return View(locations);
        }

        public IActionResult CustomerList(int id)
        {
            //List<Customer> customers = dbContext.Customers.Where(e => e.Location.Id == id).ToList();

            List<CustomerViewModel> customers=(from c in
            dbContext.Customers join l in dbContext.Locations
                                                on
               c.Location.Id equals l.Id
                                                where
               c.Location.Id==id select new CustomerViewModel()
                                                {
                       Name=c.Name,
                       Email=c.Email,
                       Mobile=c.Mobile,
               
               Location=l.Place     }
                                   ).ToList();
               

            return View(customers);
        }
    }
}
