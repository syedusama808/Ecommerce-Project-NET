using Ecommerce_Project_NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Project_NET.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Helper.Helper helper;
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryManagement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(CategoryBindingModel model) 
        {
            return View("CategoryManagement");
        }
    }
}