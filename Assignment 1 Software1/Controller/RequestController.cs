using Assignment1EnterpriseSoftware.Models;
using Assignment1EnterpriseSoftware.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1EnterpriseSoftware.Controllers
{
    public class RequestController : Controller
    {
        private readonly RequestRepository _requestRepo;

        public RequestController(RequestRepository requestRepo) // Use dependency injection
        {
            _requestRepo = requestRepo;
        }

        public IActionResult AvailableEquipment()
        {
            var equipment = new List<Equipment>
    {
        new Equipment { Id = 1, EquipmentType = EquipmentType.Laptop, Description = "Dell XPS 13", IsAvailable = true },
        new Equipment { Id = 2, EquipmentType = EquipmentType.Tablet, Description = "iPad Pro", IsAvailable = false },
        new Equipment { Id = 3, EquipmentType = EquipmentType.Phone, Description = "iPhone 12", IsAvailable = true },
    };

            var availableEquipment = equipment.Where(e => e.IsAvailable).ToList();
            return View(availableEquipment); // Ensure the view file exists
        }

        public IActionResult AllEquipment()
        {
            var equipment = new List<Equipment>
    {
        new Equipment { Id = 1, EquipmentType = EquipmentType.Laptop, Description = "Dell XPS 13", IsAvailable = true },
        new Equipment { Id = 2, EquipmentType = EquipmentType.Tablet, Description = "iPad Pro", IsAvailable = false },
        new Equipment { Id = 3, EquipmentType = EquipmentType.Phone, Description = "iPhone 12", IsAvailable = true },
    };

            return View(equipment); // Ensure "AllEquipment.cshtml" exists in Views/Request/
        }


        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(Request request)
        {
            if (ModelState.IsValid)
            {
                _requestRepo.AddRequest(request);
                return RedirectToAction("Requests");
            }

            return View(request);
        }

        public IActionResult Requests()
        {
            var requests = _requestRepo.GetAllRequests();
            return View(requests);
        }

    }
}
