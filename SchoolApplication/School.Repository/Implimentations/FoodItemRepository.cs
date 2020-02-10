using School.Entities;
using School.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository.Implimentations
{
    public class FoodItemRepository : IFoodItemRepository
    {
        public bool Create(FoodItem foodItem)
        {
            //write code to insert data into database
            return true;
        }

        public bool Delete(int id)
        {
            //write code to insert data into database
            return true;
        }


        public List<FoodItem> Get()
        {
            //write code to insert data into database
            return new List<FoodItem>();
        }

        public bool Update(int id, FoodItem foodItem)
        {
            //write code to insert data into database
            return true;
        }


        
        }
    }

