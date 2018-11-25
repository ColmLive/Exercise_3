using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise_3.Models;

namespace Exercise_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
           var vehicle = new Vehicle();
//          var viewResult = new ViewResult();
           

//            ViewData["Vehicle"] = vehicle;

            return View();
        }
        [HttpPost]
        public ActionResult Index(Vehicle vehicle)
        {
            //var vehicle = new Vehicle();
                       
            string vehicletype = vehicle.VehicleType;
            string vehiclecategory = vehicle.VehicleCategory.ToString();
            string vehicletag = vehicle.VehicleTag.ToString();
            double vehiclecost = 0;
            if ((vehicletag == "No") && (vehiclecategory == "Car"))
            { vehicle.VehicleCost = 2.00; }
            if ((vehicletag == "No") && (vehiclecategory == "Bus"))
            { vehicle.VehicleCost = 2.80; }
            if ((vehicletag == "Yes") && (vehiclecategory == "Car"))
            { vehicle.VehicleCost = 2.00;
              vehicle.VehicleDiscCost = 2.00/100*80; }
            if ((vehicletag == "Yes") && (vehiclecategory == "Bus"))
            { vehicle.VehicleCost = 2.80;
              vehicle.VehicleDiscCost = 2.80/100*80; }



            //double vehiclecost = vehicle.VehicleCost;

            ViewData["Vehicle"] = vehicle;

            return View(vehicle);
        }

    }
    /*
    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";

        return View();
    }

    public ActionResult Contact()
    {
        ViewBag.Message = "Your contact page.";

        return View();
    }
    */
}
