using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeupStore.App.Models;
using MakeupStore.BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeupStore.App.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerController(ICustomerRepository custRepository)
        {
            _customerRepo = custRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            try
            {
                List<Models.Customer> customers = new List<Models.Customer>();


                foreach (var c in _customerRepo.AllCustomerData())
                {
                    Models.Customer newCust = new Models.Customer
                    {   
                        Id = c.Id,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Email = c.Email
                    };

                    customers.Add(newCust);
                }
                

                return View(customers);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Create(Models.Customer c)
        {
            try
            {
                BLL.Customer newCust = new BLL.Customer{
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email
             };


                _customerRepo.AddCustomer(newCust);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
