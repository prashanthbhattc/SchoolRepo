using School.Entities;
using School.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository.Implimentations
{
    public class CategoryRepository : ICategoryRepository
    {
        public bool Create(Category category)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }

        public IList<Category> Get()
        {
            return GenarateData();
        }

        public bool Update(int id, Category category)
        {
            return true;
        }


        private static List<Category > GenarateData()
        {
            return new List<Category> {
                new Category{Id=1,Name="Veg",CreatedBy="Prashanth",ModifiedBy="Prashanth",CreatedTime=DateTime.Now,ModifiedDate=DateTime.Now },
                new Category{Id=2,Name="Non Veg",CreatedBy="Prashanth",ModifiedBy="Prashanth",CreatedTime=DateTime.Now,ModifiedDate=DateTime.Now }
            };
        }
    }
}
