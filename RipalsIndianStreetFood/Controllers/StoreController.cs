using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace RipalsIndianStreetFood.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "+ genre);
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}