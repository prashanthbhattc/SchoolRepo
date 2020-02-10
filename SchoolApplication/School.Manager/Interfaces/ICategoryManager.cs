using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Interfaces
{
   public interface ICategoryManager
    {
        bool Create(Category category);
        bool Update(int id,Category category);
        IList<Category> Get() ;
        bool Delete(int id);

    }
}
