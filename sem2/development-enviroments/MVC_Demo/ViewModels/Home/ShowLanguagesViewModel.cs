using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.ViewModels.Home
{
    public class ShowLanguagesViewModel
    {
        public ShowLanguagesViewModel(CultureInfo[] cultures)
        {
            CultureList = cultures.Select(c => new SelectListItem() { Text = c.EnglishName }
            );
        }
        public IEnumerable<SelectListItem> CultureList { get; private set; }
    }
}