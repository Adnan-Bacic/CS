using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MVC_Demo.Models
{
    public class ShopFactory : DbContext
    {
        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer());
        }
        public DbSet<Product> Products { get; set; }

    }

    //db conn and create
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product() { Name = "Yogurt", Description = "desc", Price = 5 });
            context.Products.Add(new Product() { Name = "Cleaning", Description = "desc2", Price = 3 });
            context.Products.Add(new Product() { Name = "Banana", Description = "desc3", Price = 1 });
        }
    }
}