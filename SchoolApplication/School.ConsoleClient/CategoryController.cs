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
   public class CategoryController
    {
        ICategoryManager _categoryManager;
        public CategoryController()
        {
            _categoryManager = new CategoryManager();
        }

        public bool Create(Category category)
        {
            return _categoryManager.Create(category);
        }

        public bool Delete(int id)
        {
            return _categoryManager.Delete(id);
        }

        public IList<Category> Get()
        {
            return _categoryManager.Get();
        }

        public bool Update(int id, Category category)
        {
            return _categoryManager.Update(id, category);
        }
    }
}
