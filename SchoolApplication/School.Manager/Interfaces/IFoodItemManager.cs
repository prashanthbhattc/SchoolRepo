﻿using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Interfaces
{
    public interface IFoodItemManager
    {
        bool Create(FoodItem foodItem);
        bool Delete(int id);  
        bool Update(int id,FoodItem foodItem);
        List<FoodItem> Get();
    }
}
