using School.Entities;
using School.Manager.Interfaces;
using School.Repository.Implimentations;
using School.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Implimentations
{
    public class FoodItemManager : IFoodItemManager
    {
        IFoodItemRepository _foodItemRepository;
        public FoodItemManager()
        {
            _foodItemRepository = new FoodItemRepository();
        }
        public bool Create(FoodItem foodItem)
        {
            return _foodItemRepository.Create(foodItem);
        }

        public bool Delete(int id)
        {
            return _foodItemRepository.Delete(id);
        }

        public bool Update(int id, FoodItem foodItem)
         {
            return _foodItemRepository.Update(id, foodItem);
        }

        public List<FoodItem> Get()
        {
            return _foodItemRepository.Get();
        }
    }
}

