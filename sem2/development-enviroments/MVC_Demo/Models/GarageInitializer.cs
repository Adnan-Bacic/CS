using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class GarageInitializer : DropCreateDatabaseIfModelChanges<GarageFactory>
    {
        protected override void Seed(GarageFactory context)
        {
            context.Cars.Add(new Car() { model = "Rabbit", maxSpeed = 300 });
            context.Cars.Add(new Car() { model = "Turtle", maxSpeed = 150 });
        }
    }
}