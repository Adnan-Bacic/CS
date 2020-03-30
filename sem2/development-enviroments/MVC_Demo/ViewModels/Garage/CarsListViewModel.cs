using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Data.Entity;

//must using own project name
using MVC_Demo.Models;

namespace MVC_Demo.ViewModels.Garage
{
    public class CarsListViewModel
    {
        public CarsListViewModel(IEnumerable<Car> cars)
        {
            CarsList = cars.Select(
                c => new SelectListItem() { Text = c.model }
            );
            FastestCar = cars.OrderByDescending(c => c.maxSpeed).FirstOrDefault();
        }

        public IEnumerable<SelectListItem> CarsList { get; private set; }
        public Car FastestCar { get; set; }
    }
}