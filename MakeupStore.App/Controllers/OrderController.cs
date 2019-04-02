using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeupStore.BLL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeupStore.App.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepo;
        private readonly ICustomerRepository _customerRepo;
        private readonly ILocationRepository _locationRepo;
        private readonly IOrderItemRepository _orderItemRepo;

        public OrderController(IOrderRepository orderRepository, ICustomerRepository customerRepository, ILocationRepository locationRepository)
        {
            _orderRepo = orderRepository;
            _customerRepo = customerRepository;
            _locationRepo = locationRepository;
        }

        // GET: /<controller>/
        public IActionResult Index(Models.Order ord)
        {
            try
            {
                List<Models.Order> order = new List<Models.Order>();

                foreach (var o in _orderRepo.AllOrderData())
                {
                    Models.Order newOrder = new Models.Order
                    {
                        Id = o.Id,
                       //OrderLocation = o.OrderLocation,
                       //OrderCustomer = o.OrderCustomer,
                        OrderTime = DateTime.Now

                    };
                    order.Add(newOrder);
                }

                return View(order);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }

        }

        [HttpPost]
        public IActionResult Create(Models.Order o)
        {
            try
            { 
                BLL.Order newOrder = new BLL.Order();


                BLL.Customer newCust = new BLL.Customer
                {
                    FirstName = o.OrderCustomer.FirstName,
                    LastName = o.OrderCustomer.LastName,
                };

                BLL.Location newLoc = new BLL.Location
                {
                    LocationName = o.OrderLocation.LocationName,
                };
                _customerRepo.AddCustomer(newCust);
                _locationRepo.AddStore(newLoc);

                newOrder.OrderCustomer = newCust;
                newOrder.OrderLocation = newLoc;

                return RedirectToAction(nameof(SelectItems));
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


        public IActionResult SelectItems(List<Models.OrderItem> o)
        {
            try
            {
                // how do i change an BLL.orderitem to model.orderitem

                foreach (var it in _orderItemRepo.AllOrderItemData())
                {
                    OrderItem newOrdItems = new OrderItem();
                    newOrdItems.Id = it.Id;
                    newOrdItems.IsLtdEd = it.IsLtdEd;
                    newOrdItems.Quantity = it.Quantity;
                    //newOrdItems.Product = it.Product;
                    //newOrdItems.Order = it.Order;

                    _orderItemRepo.AddOrderItem(newOrdItems);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }


        public IActionResult SelectItems()
        {
            return View();
        }

    }
}
