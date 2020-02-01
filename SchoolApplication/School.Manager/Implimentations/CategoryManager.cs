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
   public class CategoryManager : ICategoryManager
    {
        ICategoryRepository _categoryRepository;
        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }
        public bool Create(Category category)
        {
           return _categoryRepository.Create(category);
        }

        public bool Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }

        public IList<Category> Get()
        {
            return _categoryRepository.Get();
        }

        public bool Update(int id, Category category)
        {
            return _categoryRepository.Update(id, category);
        }
    }
}
