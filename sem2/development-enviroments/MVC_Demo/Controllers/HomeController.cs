using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using MVC_Demo.Models;
using MVC_Demo.ViewModels.Garage;
using MVC_Demo.ViewModels.BasicProductCalculator;
using System.Web.Helpers;
using System.Data.Entity;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchCriteria)
        {
            var factory = new ShopFactory();
            //var products = factory.Products.ToList();
            //return View(products);

            IQueryable<Product> prods = factory.Products.OrderBy(p => p.Name);
            if(searchCriteria != null)
            {
                prods = prods.Where(p => p.Name.Contains(searchCriteria));
            }
            var products = prods.Take(10).ToList();
            return View(products);
        }

        /*
        public ActionResult Product()
        {
            var languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            ViewBag.LanguageList = languages;
            return View();
        }
        */

        public ActionResult Action1(string id)
        {
            /*
            var languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            ViewBag.LanguagesList = languages;
            */
            CultureInfo[] languages = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            return View(languages);
        }

        public ActionResult ShowLanguages()
        {
            var viewModel = new ViewModels.Home.ShowLanguagesViewModel(
                CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            );

            return View(viewModel);
        }

        public ActionResult CarsList()
        {
            var factory = new GarageFactory();
            var viewModel = new CarsListViewModel(factory.Cars);
            return View(viewModel);
        }

        //diy
        public ActionResult MyDiy1()
        {
            var factory = new ShopFactory();
            var products = factory.Products.ToList();
            return View(products);
        }

        //product url page
        public ActionResult Details(int id)
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            return View(found);
        }

        //calculator
        public ActionResult ComputeProduct(decimal? number1, decimal? number2)
        {
            var viewModel = new ComputeProductViewModel(number1, number2);
            return View(viewModel);
        }

        //diy - add images
        public ActionResult Picture(int id)
        {
            var factory = new ShopFactory();
            var product = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            if(product == null)
            {
                return HttpNotFound();
            }
            var img = new WebImage(string.Format("~/Content/Images/{0}", product.ImageName));
            img.Resize(50, 50);
            return File(img.GetBytes(), "image/jpeg");
        }

    }
}