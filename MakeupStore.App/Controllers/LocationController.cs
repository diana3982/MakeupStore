using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeupStore.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeupStore.App.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationRepository _LocationRepo;
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILocationRepository inventoryRepo, ILogger<LocationController> logger)
        {
            _LocationRepo = inventoryRepo;
            _logger = logger;
        }

        public ILocationRepository LocationRepo { get; set; }

        public ActionResult Index()
        {
            try
            {
                List<Models.Location> loc = new List<Models.Location>();

                foreach (var i in _LocationRepo.AllLocations())
                {
                    Models.Location newInv = new Models.Location
                    {
                        Id = i.Id,
                        LocationName = i.LocationName
                    };

                    loc.Add(newInv);
                }


                return View(loc);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Create(Models.Location i)
        {
            try
            {
                Location newLoc = new BLL.Location
                {
                    LocationName = i.LocationName
                };


                _LocationRepo.AddStore(newLoc);
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
    }
}