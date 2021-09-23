using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
