using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MakeupStore.BLL;
using Microsoft.Extensions.Logging;

namespace MakeupStore.App.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryRepository _inventoryRepo;
        private readonly ILogger<InventoryController> _logger;

        public InventoryController(IInventoryRepository inventoryRepo, ILogger<InventoryController> logger)
        {
            _inventoryRepo = inventoryRepo;
            _logger = logger;
        }

        public IInventoryRepository InventoryRepo { get; set; }

        public ActionResult Index()
        {
            try
            {
                List<Models.Inventory> inv = new List<Models.Inventory>();

                foreach (var i in _inventoryRepo.AllInventoryData())
                {
                    Models.Inventory newInv = new Models.Inventory
                    {
                        Id = i.Id,
                        ItemName = i.ItemName,
                        Price = i.Price,
                        Quantity = i.Quanity
                    };

                    inv.Add(newInv);
                }


                return View(inv);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Create(Models.Inventory i)
        {
            try
            {
                Inventory newItem = new BLL.Inventory
                {
                    ItemName = i.ItemName,
                    Price = i.Price,
                    Quanity = i.Quantity
                };


                _inventoryRepo.CreateInventoryItem(newItem);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        //public IActionResult Display(Models.Inventory i)
        //{
        //    try
        //    {
        //        List<Models.Inventory> inv = new List<Models.Inventory>();

        //        foreach (var a in _inventoryRepo.AllInventoryData())
        //        {
        //            Models.Inventory newInv = new Models.Inventory
        //            {
        //                Id = i.Id,
        //                ItemName = i.ItemName,
        //                Price = i.Price,
        //                Quantity = i.Quantity
        //            };

        //            inv.Add(newInv);
        //        }


        //        return View(inv);
        //    }
        //    catch
        //    {
        //        return RedirectToAction("Error", "Home");
        //    }
        //}

        //public IActionResult Display()
        //{
        //    return View();
        //}

    } 
}
