using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart1.Web.Controllers
{
    
    public class CategoryController : Controller
    {
        private readonly ICategory _category;
        [HttpGet]
        public IActionResult Index()
        {
            var AllCategories =
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
