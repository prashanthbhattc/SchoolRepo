using School.Entities;
using School.Manager.Implimentations;
using School.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.web.Controllers
{
    public class CategoryController : Controller
    {
       private ICategoryManager _categoryManager;

        public CategoryController()
        {
            _categoryManager = new CategoryManager();
        }
        // GET: Category
        public ActionResult Index()
        {
            var categories = _categoryManager.Get();
            ViewData["category"] = categories;

            ViewBag.Mydata = categories;
            return View(categories);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category c)
        {
            _categoryManager.Create(c);
            var categories = _categoryManager.Get();
            return View("Index", categories);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

    }
}