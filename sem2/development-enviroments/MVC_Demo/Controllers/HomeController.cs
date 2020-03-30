using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using MVC_Demo.Models;
using MVC_Demo.ViewModels.Garage;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var factory = new ShopFactory();
            var products = factory.Products.ToList();
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

        public ActionResult Action1()
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

    }
}