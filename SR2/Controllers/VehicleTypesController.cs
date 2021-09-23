using Microsoft.AspNetCore.Mvc;
using SR2.Models;
using SR2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SR2.Controllers
{
    public class VehicleTypesController : Controller
    {
        private readonly IVehicleTypeRepository _vehicleType;
        public VehicleTypesController(IVehicleTypeRepository vehicleType)
        {
            _vehicleType = vehicleType;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _vehicleType.GetVehicleTypes());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleType vehicle)
        {
            if (ModelState.IsValid)
            {
                if (await _vehicleType.Save(vehicle))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(vehicle);
        }
    }
}
