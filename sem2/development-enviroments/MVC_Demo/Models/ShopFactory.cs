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
            context.Products.Add(new Product() { Name = "Yogurt", Description = "All naturel taste!", Price = 5, ImageName="yogurt.jpg" });
            context.Products.Add(new Product() { Name = "Apple", Description = "An apple a day keeps the doctor away!", Price = 3, ImageName = "apple.jpg" });
            context.Products.Add(new Product() { Name = "Banana", Description = "Two for the price of one", Price = 1, ImageName = "banana.jpg" });
        }        
    }
}