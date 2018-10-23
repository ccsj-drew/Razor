using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers{
    public class HomeController : Controller {
        public IActionResult Index() {
            Product[] array = {
                new Product {Name = "Kayak", Price = 275m},
                new Product {Name = "Lifejacket", Price = 48.95m},
                new Product {Name = "Soceer ball", Price = 19.50m},
                new Product {Name = "Corner flag", Price = 34.95m},



            };
            return View(array);
        }
    }
}
