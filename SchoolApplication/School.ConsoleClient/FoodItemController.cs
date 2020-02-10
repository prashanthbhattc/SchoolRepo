using School.Entities;
using School.Manager.Implimentations;
using School.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.ConsoleClient
{
    public class FoodItemController
    {
        IFoodItemManager _FoodItemManager;

        public FoodItemController()
        {
            _FoodItemManager = new FoodItemManager();
        }

        public bool Create(FoodItem foodItem)
        {
            return _FoodItemManager.Create(foodItem);
        }

        public bool Delete(int id)
        {
            return _FoodItemManager.Delete(id);
        }

        public bool Get(FoodItem foodItem)
        {
            return _FoodItemManager.Get();
        }

        public bool Update(int id, FoodItem foodItem)
        {
            return _FoodItemManager.Update(id, foodItem);
        }
    }
}
