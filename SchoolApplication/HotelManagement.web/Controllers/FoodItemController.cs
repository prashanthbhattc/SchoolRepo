using School.Manager.Implimentations;
using School.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.web.Controllers
{
    public class FoodItemController : Controller
    {
        private IFoodItemManager _fooditemManager;

        public FoodItemController()
        {
            _fooditemManager = new FoodItemManager();
        }
        // GET: fooditem
        public ActionResult Index()
        {
            var foodItems = _fooditemManager.Get();
            ViewData["fooditem"] = foodItems;

            ViewBag.Mydata = foodItems;
            return View(foodItems);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

    }
}