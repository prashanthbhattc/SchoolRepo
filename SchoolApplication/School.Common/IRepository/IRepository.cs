using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{

    public interface IRepository<TEntity, TFiltr, Tid> 
        where TEntity : class
        where TFiltr:class 
        where Tid:struct
    {
        IEnumerable<TEntity> SelectAll();
        IEnumerable<TEntity> SelectAllByFilter(TFiltr filter);
        TEntity SelectById(Tid id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(Tid id);
        void Save();
    }

    public interface IRepositoryAsync<TEntity, TFiltr, Tid>
        where TEntity : class
        where TFiltr : class
        where Tid : struct
    {
        Task<IEnumerable<TEntity>> SelectAllAsync();
        Task<IEnumerable<TEntity>> SelectAllByFilterAsync(TFiltr filter);
        Task<TEntity> SelectByIdAsync(Tid id);
        Task InsertAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task DeleteAsync(Tid id);
        Task SaveAsync();
    }

}
