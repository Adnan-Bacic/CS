using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MVC_Demo.Models
{
    //add dbcontext
    public class GarageFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public GarageFactory()
        {
            Database.SetInitializer(new GarageInitializer());
        }
    }
}