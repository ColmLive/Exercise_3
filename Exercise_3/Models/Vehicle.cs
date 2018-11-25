using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exercise_3.Models
{
    public enum Category { Car,PSV,Bus,Goods }
    public enum Tag { No, Yes}
    public class Vehicle
    {
        [Display(Name="Type")]
        public string VehicleType { get; set; }
        [Display(Name = "Category")]
        public Category VehicleCategory {get;set;}
        [Display(Name = "Electronic Tag")]
        public Tag VehicleTag { get; set; }
        [Display(Name = "Toll Charge")]
        public double VehicleCost { get; set; }
        [Display(Name = "Discounted Toll Charge")]
        public double VehicleDiscCost { get; set; }

             




    }
}